Imports System.IO

Module cmdlinetvshowupdate
    Dim waittime As Double = 100
    Dim rechecktime As Double = 0
    Dim singlerun As Boolean = True
    Dim runrunrun As Boolean = True
    Dim waitforit As Boolean = True
    Dim showdebug As Boolean = False

    Sub Main()
        Console.Out.WriteLine("MIP TV Show Update - Version 2.1.1.2946")
        If Command.ToString.ToLower.Contains("help") Then
            Console.Out.WriteLine("Optional Parameters")
            Console.Out.WriteLine("-check10   'checks for new items every 10 minutes")
            Console.Out.WriteLine("-check30   'checks for new items every 30 minutes")
            Console.Out.WriteLine("-check60   'checks for new items every 60 minutes")
            Console.Out.WriteLine("-nfoupdate   'overwrites all existing episode .nfo files with new data")
            Console.Out.WriteLine("-fastimages   'download just the images as fast as possible")
            Console.Out.WriteLine("-debug   'show debug information about the commandline tool")
            Exit Sub
        End If
        If Command.ToString.ToLower.Contains("-debug") Then
            showdebug = True
        End If
        If Command.ToString.ToLower.Contains("-check10") Then
            waittime = 10 * 60 * 1000
            rechecktime = waittime
            runrunrun = True
            singlerun = False
            Console.Out.WriteLine("Checking every 10 minutes for new items.")
            If showdebug Then Console.Out.WriteLine("Waiting: " & waitforit.ToString & " ... SingleRun: " & singlerun.ToString)
        End If
        If Command.ToString.ToLower.Contains("-check30") Then
            waittime = 30 * 60 * 1000
            rechecktime = waittime
            runrunrun = True
            singlerun = False
            Console.Out.WriteLine("Checking every 30 minutes for new items.")
            If showdebug Then Console.Out.WriteLine("Waiting: " & waitforit.ToString & " ... SingleRun: " & singlerun.ToString)
        End If
        If Command.ToString.ToLower.Contains("-check60") Then
            waittime = 60 * 60 * 1000
            rechecktime = waittime
            runrunrun = True
            singlerun = False
            Console.Out.WriteLine("Checking every 60 minutes for new items.")
            If showdebug Then Console.Out.WriteLine("Waiting: " & waitforit.ToString & " ... SingleRun: " & singlerun.ToString)
        End If

        Dim currentoverwritesetting As Boolean = False
        Dim multimageonly As Boolean = False

        If Command.ToString.ToLower.Contains("-nfoupdate") Then
            currentoverwritesetting = True
            Console.Out.WriteLine("Overwrite of .nfo files is set .. all information will be refreshed")
        End If

        If Command.ToString.ToLower.Contains("-fastimages") Then
            'If waittime = 0 Then

            'End If
            multimageonly = True
            'Console.Out.WriteLine("Overwrite of .nfo files is set .. all information will be refreshed")
        End If
        If showdebug Then Console.Out.WriteLine("Waiting: " & waitforit.ToString & " ... SingleRun: " & singlerun.ToString & " ...Recheck Time: " & rechecktime.ToString)
        'If Not showdebug Then Console.Out.Write("Waiting.")
        Dim alldone As Boolean = False

        Do Until alldone = True
            Do Until waittime = 0
                System.Threading.Thread.Sleep(5000)
                Try
                    waittime = waittime - 5000
                    If showdebug Then
                        If waittime >= 0 Then Console.Out.WriteLine(waittime.ToString & ": until next update")
                    Else
                        'Console.Write(".")
                    End If

                Catch ex As Exception
                    waittime = 0
                    Console.Out.WriteLine("Error: " & ex.ToString)
                End Try
                If waittime <= 0 Then
                    waitforit = False
                    Dim curtv As New movieinfoplus.tvshowcollection
                    Dim curdllist As New ArrayList
                    curtv.precacheTVShowsCmdLine(curdllist)
                    If showdebug Then Console.Out.WriteLine("done curtv.precacheTVShowsCmdLine(curdllist)")

                    Dim binfilelocal As String = movieinfoplus.maincollection.rconf.wgetfolder + "wget.exe"
                    Try
                        If Not curdllist.Count = 0 Then
                            Console.Out.WriteLine("Processing " & curdllist.Count.ToString & " images.")
                            If showdebug Then Console.Out.WriteLine("Number of items to download: " & curdllist.Count.ToString)
                            Dim counter As Integer = 0
                            counter = curdllist.Count
                            Dim curitemcounter As Integer = 1
                            Try
                                For Each item As miplibfc.mip.dlobject In curdllist
                                    If showdebug Then Console.Out.WriteLine("Processing Image " & curitemcounter.ToString & "/" & counter.ToString)
                                    curitemcounter += 1
                                    If Not File.Exists(item.Destination) Then
                                        If showdebug Then Console.Out.WriteLine("Downloading Image to: " & item.Destination)
                                        Dim filenameuri As String = item.URL
                                        Dim pro1 As Process = New Process()
                                        pro1.StartInfo.FileName = binfilelocal
                                        pro1.StartInfo.Arguments = filenameuri + " -t 3 -T 60 -O " + """" + item.Destination + """"
                                        'pro1.StartInfo.RedirectStandardError = True
                                        'pro1.StartInfo.UseShellExecute = False
                                        'pro1.StartInfo.CreateNoWindow = True
                                        If showdebug Then
                                            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                                        Else
                                            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                                        End If
                                        pro1.Start()
                                        If Not multimageonly Then pro1.WaitForExit()
                                        If multimageonly Then System.Threading.Thread.Sleep(200)
                                        If showdebug Then Console.Out.WriteLine(item.URL.ToString)
                                    End If
                                    If File.Exists(item.Destination) Then
                                        'check it's size, 0k files need to be removed
                                        Try
                                            File.SetAttributes(item.Destination, FileAttributes.Normal)
                                        Catch ex As Exception
                                            If showdebug Then Console.Out.WriteLine(ex.ToString)
                                        End Try

                                        Try
                                            If getFileSizeExact(item.Destination) < 1 Then
                                                If showdebug Then Console.Out.WriteLine("Image invalid - Deleteing " & item.Destination)
                                                File.Delete(item.Destination)
                                            End If

                                        Catch ex As Exception
                                            If showdebug Then Console.Out.WriteLine(ex.ToString)
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
                    Catch ex As Exception
                        Console.Out.WriteLine("Error in miptvupdate download loop" + vbNewLine + ex.ToString)
                    End Try

                    If multimageonly Then Exit Sub
                    If showdebug Then Console.Out.WriteLine("Processing of episodes started")
                    curtv.kbLoadTvShowsCmdLine(currentoverwritesetting, showdebug)
                End If
                If singlerun Then Exit Sub
                If Not waitforit Then
                    If showdebug Then Console.Out.WriteLine("Resetting timer to: " & rechecktime.ToString & "...")
                    waittime = rechecktime
                    If showdebug Then Console.Out.WriteLine("Timer set to: " & waittime.ToString)
                    waitforit = True
                End If
                If showdebug Then Console.Out.WriteLine("Waiting: " & waitforit.ToString & " ... SingleRun: " & singlerun.ToString & " ...Recheck Time: " & rechecktime.ToString)
            Loop
            If showdebug Then Console.Out.WriteLine("OUTTER LOOP ... Waiting: " & waitforit.ToString & " ... SingleRun: " & singlerun.ToString & " ...Recheck Time: " & rechecktime.ToString)

        Loop
    End Sub
    Function getFileSizeExact(ByVal vFile As String) As Double
        'Dim curFile As FileInfo
        Dim curfile As FileInfo = My.Computer.FileSystem.GetFileInfo(vFile)
        Dim fileSize As Double = curfile.Length
        Return fileSize
    End Function

End Module
