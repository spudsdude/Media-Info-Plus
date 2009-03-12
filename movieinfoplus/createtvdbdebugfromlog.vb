Imports System.Windows.Forms
Imports System.IO
Imports System.Text.RegularExpressions

Public Class createtvdbdebugfromlog
    Dim fileselected As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub KryptonTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonTextBox1.Click


    End Sub

    Private Function stripnonchardigitfromstring(ByVal thestring As String) As String
        If thestring Is Nothing Then
            Return ""
        End If
        If thestring = "" Then
            Return ""
        End If



        Dim retstr As String = ""
        For Each curchar As Char In thestring
            If Char.IsLetterOrDigit(curchar) Then
                retstr += curchar
            End If
        Next
        retstr = retstr '.ToLower
        Return retstr
    End Function
    Private Sub createfolders()

        If Not File.Exists(KryptonTextBox1.Text) Then
            With ofd1
                If .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                    'MessageBox.Show("Canceling")
                Else
                    fileselected = ofd1.FileName
                    If ofd1.FileName = "" Then Exit Sub 'Or ofd1.FileName = "Select your custom image or enter URL" Then Exit Sub
                    If Not File.Exists(ofd1.FileName) Then Exit Sub
                    KryptonTextBox1.Text = ofd1.FileName

                End If
            End With
        End If
        Dim rootfolder As String = "c:\program files\movieinfoplus\testersfromlog\"
        Dim movieslist As New ArrayList
        Dim seasonfolder As New ArrayList
        Dim datafromfile As String = File.ReadAllText(fileselected)
        Try
            Dim RegexObject1 As New Regex("Processing: (.*)")
            Dim MObj As Match = RegexObject1.Match(datafromfile)
            While MObj.Success
                Dim i As Integer
                For i = 1 To MObj.Groups.Count
                    Dim GObj As Group = MObj.Groups(i)
                    If GObj.Success Then
                        'MsgBox(MObj.Groups(i).Value.ToString)
                        If Not Directory.Exists(rootfolder + MObj.Groups(i).Value.ToString) Then Directory.CreateDirectory(rootfolder + MObj.Groups(i).Value.ToString)
                        movieslist.Add(MObj.Groups(i).Value.ToString)
                    End If
                Next
                MObj = MObj.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try

        'create season folders
        For Each moviename As String In movieslist
            moviename = Strings.Replace(moviename, " ", "ZZZZZ")
            moviename = stripnonchardigitfromstring(moviename)
            moviename = Strings.Replace(moviename, "ZZZZZ", " ")
            Try
                Dim RegexObject1 As New Regex(moviename + "\\(.*)\\")
                Dim MObj As Match = RegexObject1.Match(datafromfile)
                While MObj.Success
                    Dim i As Integer
                    For i = 1 To MObj.Groups.Count
                        Dim GObj As Group = MObj.Groups(i)
                        If GObj.Success Then
                            Dim basefolder As String = rootfolder + moviename + "\"
                            Dim subfolder As String = MObj.Groups(i).Value.ToString
                            Dim fsubfolder As String = basefolder + subfolder
                            If Not Directory.Exists(fsubfolder) Then Directory.CreateDirectory(fsubfolder)
                            'being show create
                            Try
                                Dim RegexObject1Two As New Regex(moviename + "\\" + subfolder + "\\(.*\.avi) :")
                                Dim MObjTwo As Match = RegexObject1Two.Match(datafromfile)
                                While MObjTwo.Success
                                    Dim i2 As Integer
                                    For i2 = 1 To MObjTwo.Groups.Count
                                        Dim GObjTwo As Group = MObjTwo.Groups(i2)
                                        If GObjTwo.Success Then
                                            Dim newfilename As String = ""
                                            newfilename = fsubfolder + "\" + MObjTwo.Groups(i2).Value.ToString
                                            If Not File.Exists(newfilename) Then
                                                File.WriteAllText(newfilename, "00000")
                                            Else
                                                'MsgBox("dup for: " + newfilename)
                                            End If
                                        End If
                                    Next
                                    MObjTwo = MObjTwo.NextMatch()
                                End While
                            Catch ex As ArgumentException
                                'Syntax error in the regular expression
                            End Try

                            'end show create
                        End If
                    Next
                    MObj = MObj.NextMatch()
                End While
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
        Next

    End Sub

    Private Sub KryptonButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KryptonButton1.Click
        createfolders()
    End Sub
End Class
