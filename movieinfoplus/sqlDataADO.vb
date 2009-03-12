Option Strict Off

Imports System.IO.StreamReader
Imports System.Globalization
Imports System.Data.SQLite
Imports System.Data
Imports System.IO

Module sqlDataADO

    Private myConnection As New SQLiteConnection
    Private myDataAdapter() As SQLiteDataAdapter
    Public myCellCollection As New Collection
    Private myDataSet As New DataSet
    Private myWorkRow As DataRow
    Public IPAddress As String
    Public Password As String
    Public SQLStmt As String
    Public UserId As String

    Public Function OpenSQLConnection(ByVal Database As String) As Boolean

        Try
            If myConnection.State = ConnectionState.Closed Then
                myConnection.ConnectionString = "Data Source=" & Database & ";New=True;Compress=True;Synchronous=Off"
                myDataSet.Locale = CultureInfo.InvariantCulture
                myConnection.Open()
                myDataSet.Reset()
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Sub CloseSQLConnection()

        If myConnection.State = ConnectionState.Open Then
            myConnection.Close()
        End If

    End Sub

    Public Sub DisposeDAL()

        CloseSQLConnection()
        If myDataAdapter IsNot Nothing Then
            For a As Short = 0 To CShort(UBound(myDataAdapter))
                myDataAdapter(a).Dispose()
                myDataAdapter(a) = Nothing
            Next
            myDataAdapter = Nothing
        End If

        If myDataSet IsNot Nothing Then
            myDataSet.Dispose()
            myDataSet = Nothing
        End If

        If myConnection IsNot Nothing Then
            myConnection = Nothing
        End If

        myCellCollection = Nothing

    End Sub

    Public Function ExecuteSQLStmt(ByVal Database As String, _
                                   ByVal sSQL As String, _
                                   Optional ByVal Disconnect As Boolean = False) As Boolean

        If OpenSQLConnection(Database) = True Then
            Dim myCmd As New SQLiteCommand(sSQL, myConnection)

            Try
                myCmd.ExecuteNonQuery()
                Return True
            Catch ex As Exception
                MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
                ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                If Disconnect = True Then CloseSQLConnection()
                If myCmd IsNot Nothing Then
                    myCmd.Dispose()
                    myCmd = Nothing
                End If
            End Try
        Else
            Return False
        End If

    End Function
    ' Note: This function will return an arraylist of the data
    Public Function StreamDataIntoArrayList(ByVal Database As String, _
                                         ByVal sSQL As String, _
                                         ByVal Col As Short, _
                                        Optional ByVal Disconnect As Boolean = False) As ArrayList
        Dim objArrayList As New ArrayList
        If OpenSQLConnection(Database) = True Then
            Dim myCmd As New SQLiteCommand(sSQL, myConnection)

            Try
                'Dim strArray() As String
                Dim myReader As SQLiteDataReader
                myReader = myCmd.ExecuteReader()
                Do While (myReader.Read())
                    'strArray = myReader(Col).ToString().Split(CChar(","))
                    'For Each x As String In strArray
                    '    objArrayList.Add(x)
                    'Next
                    objArrayList.Add(myReader(Col).ToString())
                Loop

                If myReader IsNot Nothing Then
                    myReader.Close()
                    myReader = Nothing
                End If
                Return objArrayList
            Catch ex As Exception
                MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
                ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                objArrayList.Add("ERROR")
                Return objArrayList
            Finally
                If Disconnect = True Then CloseSQLConnection()
                If myCmd IsNot Nothing Then
                    myCmd.Dispose()
                    myCmd = Nothing
                End If
            End Try
        Else
            objArrayList.Add("Database not opened. ERROR ON ELSE")
            Return objArrayList
        End If

    End Function

    '
    ' Note: This function is compatible with ListBox and ComboBox only.
    '
    Public Function StreamDataIntoControl(ByVal Database As String, _
                                          ByVal sSQL As String, _
                                          ByVal Col As Short, _
                                          ByVal myControl As Object, _
                                          Optional ByVal ClearControl As Boolean = True, _
                                          Optional ByVal Disconnect As Boolean = False) As Boolean

        If OpenSQLConnection(Database) = True Then
            Dim myCmd As New SQLiteCommand(sSQL, myConnection)

            Try
                Dim strArray() As String
                Dim myReader As SQLiteDataReader
                myReader = myCmd.ExecuteReader()

                If ClearControl = True Then
                    myControl.items.clear()
                End If

                Do While (myReader.Read())
                    strArray = myReader(Col).ToString().Split(CChar(","))
                    For Each x As String In strArray
                        myControl.Items.Add(x)
                    Next
                Loop

                If myReader IsNot Nothing Then
                    myReader.Close()
                    myReader = Nothing
                End If
                Return True
            Catch ex As Exception
                MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
                ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                If Disconnect = True Then CloseSQLConnection()
                If myCmd IsNot Nothing Then
                    myCmd.Dispose()
                    myCmd = Nothing
                End If
            End Try
        Else
            Return False
        End If

    End Function
    '
    ' An optional myControl can be DataGridView control
    ' If OutputFile is specified a result will be saved to disk file
    '
    Public Function FillDataAdapter(ByVal Database As String, _
                                    ByVal TableIndex As Byte, _
                                    ByVal sSQL As String, _
                                    Optional ByVal myControl As Object = Nothing, _
                                    Optional ByVal OutputFile As String = "", _
                                    Optional ByVal Disconnect As Boolean = False) As Boolean

        If OpenSQLConnection(Database) = True Then
            Try
                If TableIndex + 1 > myDataSet.Tables.Count Then
                    ReDim Preserve myDataAdapter(TableIndex)
                    myDataSet.Tables.Add()
                End If

                myDataSet.Tables(TableIndex).Clear()
                myDataAdapter(TableIndex) = New SQLiteDataAdapter(sSQL, myConnection)
                myDataAdapter(TableIndex).Fill(myDataSet.Tables(TableIndex))

                If myControl IsNot Nothing Then
                    myControl.DataSource = myDataSet.Tables(TableIndex)
                End If

                If Not OutputFile = "" Then
                    Dim objWriter As StreamWriter
                    objWriter = New StreamWriter(OutputFile)

                    Try
                        Dim Cols As Integer = myDataSet.Tables(TableIndex).Columns.Count - 1
                        Dim Rows As Integer = myDataSet.Tables(TableIndex).Rows.Count - 1
                        Dim Col, Row As Integer
                        Dim Data As String = ""

                        For Row = 0 To Rows
                            For Col = 0 To Cols
                                Data += myDataSet.Tables(TableIndex).Rows(Row).Item(Col).ToString & ","
                            Next
                            objWriter.Write(Data.Remove(Len(Data) - 1, 1) & vbCrLf)
                            Data = ""
                        Next
                    Catch ex As Exception
                        MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
                        ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    Finally
                        objWriter.Close()
                        objWriter.Dispose()
                        objWriter = Nothing
                    End Try
                End If

                Return True
            Catch ex As Exception
                MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
                ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                If Disconnect = True Then CloseSQLConnection()
            End Try
        Else
            Return False
        End If

    End Function

    Public Function AddDataRowDA(ByVal TableIndex As Byte) As Boolean

        Try
            With myDataSet.Tables(TableIndex)

                myWorkRow = .NewRow
                For Cell As Short = 0 To CShort(myCellCollection.Count - 1)
                    myWorkRow(Cell) = myCellCollection.Item(Cell + 1)
                Next

                .Rows.Add(myWorkRow)
                Return True
            End With
        Catch ex As Exception
            MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            myCellCollection.Clear()
        End Try

    End Function

    Public Function DeleteDataRowDA(ByVal TableIndex As Byte, _
                                    ByVal Row As Short) As Boolean

        Try
            myDataSet.Tables(TableIndex).Rows(Row).Delete()
            Return True
        Catch ex As Exception
            MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function GetCellDataDA(ByVal TableIndex As Byte, _
                                  ByVal Row As Short, _
                                  ByVal Col As Short) As Object

        Try
            Return myDataSet.Tables(TableIndex).Rows(Row).Item(Col)
        Catch ex As Exception
            MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "error"
        End Try

    End Function

    Public Function PutCellDataDA(ByVal TableIndex As Byte, _
                                  ByVal Row As Short, _
                                  ByVal Col As Short, _
                                  ByVal NewData As Object) As Boolean

        Try
            myWorkRow = myDataSet.Tables(TableIndex).Rows(Row)
            myWorkRow(Col) = NewData
            Return True
        Catch ex As Exception
            MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function UpdateDataAdapter(ByVal TableIndex As Byte, _
                                      ByVal State As DataRowState) As Boolean

        Dim myDataRowsCommandBuilder As New SQLiteCommandBuilder(myDataAdapter(TableIndex))
        Dim ChildRecords As DataTable = myDataSet.Tables(TableIndex).GetChanges(State)

        Try
            Select Case State
                Case DataRowState.Added
                    myDataAdapter(TableIndex).InsertCommand = myDataRowsCommandBuilder.GetInsertCommand
                Case DataRowState.Deleted
                    myDataAdapter(TableIndex).DeleteCommand = myDataRowsCommandBuilder.GetDeleteCommand
                Case DataRowState.Modified
                    myDataAdapter(TableIndex).UpdateCommand = myDataRowsCommandBuilder.GetUpdateCommand
            End Select

            myDataAdapter(TableIndex).Update(ChildRecords)
            myDataSet.Tables(TableIndex).AcceptChanges()
            Return True
        Catch ex As Exception
            MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
            ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If myDataRowsCommandBuilder IsNot Nothing Then
                myDataRowsCommandBuilder.Dispose()
                myDataRowsCommandBuilder = Nothing
            End If
            If ChildRecords IsNot Nothing Then
                ChildRecords.Dispose()
                ChildRecords = Nothing
            End If
        End Try

    End Function
    '
    ' This function imports diskfile into a database
    ' Usage: ImportData("Database", "Table", "Field1,Field2", "c:\data.txt", [True])
    '
    Public Function ImportData(ByVal Database As String, _
                               ByVal Table As String, _
                               ByVal Fields As String, _
                               ByVal Filename As String, _
                               Optional ByVal Disconnect As Boolean = False) As Boolean

        If File.Exists(Filename) = True Then
            If OpenSQLConnection(Database) = True Then
                Dim objReader As New StreamReader(Filename)
                Dim myCmd As New SQLiteCommand
                Dim ValuesPart As String

                Try
                    myCmd.Connection = myConnection
                    Do While objReader.Peek() <> -1
                        ValuesPart = " VALUES (" & objReader.ReadLine() & ")"
                        myCmd.CommandText = "INSERT INTO " & Table & " (" & Fields & ") " & ValuesPart
                        myCmd.ExecuteNonQuery()
                    Loop
                    Return True
                Catch ex As Exception
                    MessageBox.Show("An error has occured!" & vbCrLf & vbCrLf & _
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                Finally
                    If Disconnect = True Then CloseSQLConnection()
                    If objReader IsNot Nothing Then
                        objReader.Close()
                        objReader.Dispose()
                        objReader = Nothing
                    End If
                    If myCmd IsNot Nothing Then
                        myCmd.Dispose()
                        myCmd = Nothing
                    End If
                End Try
            Else
                Return False
            End If
        Else
            MessageBox.Show("File does not exist!", "Error", _
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

    End Function
End Module

