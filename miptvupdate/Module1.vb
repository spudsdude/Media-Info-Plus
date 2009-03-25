Imports System.IO

Module Module1

    Sub Main()
        Dim curtv As New movieinfoplus.tvshowcollection
        Dim curdllist As New ArrayList
        curtv.precacheTVShowsCmdLine(curdllist)
        Console.Out.WriteLine("done curtv.precacheTVShowsCmdLine(curdllist)")

        Dim binfilelocal As String = movieinfoplus.maincollection.rconf.wgetfolder + "wget.exe"
        If Not curdllist.Count = 0 Then
            Dim counter As Integer = 0
            counter = curdllist.Count
            Dim curitemcounter As Integer = 1
            Try
                For Each item As miplibfc.mip.dlobject In curdllist
                    Console.Out.WriteLine("Processing Image " & curitemcounter.ToString & "/" & counter.ToString)
                    curitemcounter += 1
                    If Not File.Exists(item.Destination) Then
                        Console.Out.WriteLine("Downloading Image to: " & item.Destination)
                        Dim filenameuri As String = item.URL
                        Dim pro1 As Process = New Process()
                        pro1.StartInfo.FileName = binfilelocal
                        pro1.StartInfo.Arguments = filenameuri + " -t 3 -T 60 -O " + """" + item.Destination + """"
                        pro1.StartInfo.RedirectStandardError = True
                        pro1.StartInfo.UseShellExecute = False
                        pro1.StartInfo.CreateNoWindow = True
                        pro1.Start()
                        pro1.WaitForExit()
                    End If
                    If File.Exists(item.Destination) Then
                        'check it's size, 0k files need to be removed
                        Try
                            File.SetAttributes(item.Destination, FileAttributes.Normal)
                        Catch ex As Exception
                            Console.Out.WriteLine(ex.ToString)
                        End Try

                        Try
                            If getFileSizeExact(item.Destination) < 1 Then
                                Console.Out.WriteLine("Image invalid - Deleteing " & item.Destination)
                                File.Delete(item.Destination)
                            End If

                        Catch ex As Exception
                            Console.Out.WriteLine(ex.ToString)
                        End Try

                    End If

                Next
                Dim itemF As New miplibfc.mip.dlobject
                itemF.URL = "COMPLETED"
                itemF.Destination = "COMPLETED"
                System.Threading.Thread.Sleep(50)
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If

        curtv.kbLoadTvShowsCmdLine()

    End Sub
    Function getFileSizeExact(ByVal vFile As String) As Double
        'Dim curFile As FileInfo
        Dim curfile As FileInfo = My.Computer.FileSystem.GetFileInfo(vFile)
        Dim fileSize As Double = curfile.Length
        Return fileSize
    End Function

End Module
