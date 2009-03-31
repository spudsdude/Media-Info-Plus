Imports System.IO

Module modFileUtils
    Private Function getFileSizeExact(ByVal vFile As String) As Double
        'Dim curFile As FileInfo
        Dim curfile As FileInfo = My.Computer.FileSystem.GetFileInfo(vFile)
        Dim fileSize As Double = curfile.Length
        Return fileSize
    End Function


    Public Sub checkzerofilesize(ByVal filename As String)
        'make sure it's not a 0k file
        If File.Exists(filename) Then
            'check it's size, 0k files need to be removed
            Try
                File.SetAttributes(filename, FileAttributes.Normal)
            Catch ex As Exception
                Console.Out.WriteLine(ex.ToString)
            End Try

            Try
                If getFileSizeExact(filename) < 1 Then
                    'Console.Out.WriteLine("Image invalid - Deleteing " & Strings.Left(item.ToString, item.Length - 4) + ".tbn")
                    File.Delete(filename)
                End If

            Catch ex As Exception
                Console.Out.WriteLine(ex.ToString)
            End Try
        End If
    End Sub
End Module
