Imports System.Windows.Forms
Imports System.Net
Imports System.IO
'Imports dlobject


Public Class dlgDownloadingFile
    Dim cconf As configuration = maincollection.rconf
    Public whereToSave As String 'Where the program save the file
    Public nomultidownload As Boolean = True
    Public downloadingmutliimages As Boolean = False
    Public downloadlist As ArrayList
    Public downloadlist_t1 As New ArrayList
    Public downloadlist_t2 As New ArrayList
    Public downloadlist_t3 As New ArrayList
    Public downloadlist_t4 As New ArrayList
    Public downloadlist_t5 As New ArrayList
    Public thread1_completed As Boolean = False
    Public thread2_completed As Boolean = False
    Public thread3_completed As Boolean = False
    Public thread4_completed As Boolean = False
    Public thread5_completed As Boolean = False
    Public precaching As Boolean = False
    Public binfilelocal As String = cconf.wgetfolder + "wget.exe"
    Delegate Sub closemyselfsafe()
    'Private Declare Function GetSystemMenu Lib "user32" Alias "GetSystemMenu" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
    'Private Declare Function DeleteMenu Lib "user32" Alias "DeleteMenu" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer
    'Private Const MF_BYPOSITION As Integer = &H400&
    'Private iMenu As Integer = 0
    Private Sub closemyself()
        Me.Dispose()
        Me.Close()

    End Sub
#Region "Thread 1 Delegates"
    Delegate Sub changelabelsSafe(ByVal item As miplibfc.mip.dlobject, ByVal curitemcounter As String, ByVal counter As String)
    Delegate Sub logSafe(ByVal text As Int32)
    Delegate Sub logSafeClear()
#End Region
#Region "Thread 2 Delegates"
    Delegate Sub changelabelsSafe2(ByVal item As miplibfc.mip.dlobject, ByVal curitemcounter As String, ByVal counter As String)
    Delegate Sub logSafe2(ByVal text As Int32)
    Delegate Sub logSafeClear2()
#End Region
#Region "Thread 3 Delegates"
    Delegate Sub changelabelsSafe3(ByVal item As miplibfc.mip.dlobject, ByVal curitemcounter As String, ByVal counter As String)
    Delegate Sub logSafe3(ByVal text As Int32)
    Delegate Sub logSafeClear3()
#End Region
#Region "Thread 4 Delegates"
    Delegate Sub changelabelsSafe4(ByVal item As miplibfc.mip.dlobject, ByVal curitemcounter As String, ByVal counter As String)
    Delegate Sub logSafe4(ByVal text As Int32)
    Delegate Sub logSafeClear4()
#End Region
#Region "Thread 5 Delegates"
    Delegate Sub changelabelsSafe5(ByVal item As miplibfc.mip.dlobject, ByVal curitemcounter As String, ByVal counter As String)
    Delegate Sub logSafe5(ByVal text As Int32)
    Delegate Sub logSafeClear5()
#End Region

    Delegate Sub ChangeTextsSafe(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
    Delegate Sub DownloadCompleteSafe(ByVal cancelled As Boolean, ByVal retry As Boolean)
    'Thread 1 Subroutines
    Private Sub log(ByVal textlog As Int32)

        'If textlog = 13 Then
        '    rtbLog.Text = ""
        'End If

        rtbLog.AppendText(CStr(Convert.ToChar(textlog)))
        rtbLog.SelectionStart = rtbLog.Text.Length
    End Sub
    Private Sub logClear()
        rtbLog.Text = ""
    End Sub
    Private Sub changelabels(ByVal item As miplibfc.mip.dlobject, ByVal curitemcounter As String, ByVal counter As String)
        Me.downloaderlblSpeed.Text = "Currently downloading item " + curitemcounter.ToString + " of " + counter.ToString

        'Me.pbar.MarqueeAnimationSpeed = 20
        Me.downloadertxtFileName.Text = item.URL
        Me.downloaderlblSavingFileTo.Text = item.Destination
        Me.downloaderlblFileSize.Text = "File Size: " & "Unable to determine dynamic sizes"
        If Not item.hideurl Then
            Me.downloaderlblFileDownloading.Text = "Downloading: " & Me.downloadertxtFileName.Text
        Else
            Me.downloaderlblFileDownloading.Text = "Downloading: Full Sized Image from Freecovers.net" '& Me.downloadertxtFileName2.Text
        End If
    End Sub
    'Thread 2 Subroutines
    Private Sub log2(ByVal textlog2 As Int32)

        'If textlog = 13 Then 'clear on newline, look funky
        '    rtbLog.Text = ""
        'End If

        rtbLog2.AppendText(CStr(Convert.ToChar(textlog2)))
        rtbLog2.SelectionStart = rtbLog2.Text.Length
    End Sub
    Private Sub logClear2()
        rtbLog2.Text = ""
    End Sub
    Private Sub changelabels2(ByVal item2 As miplibfc.mip.dlobject, ByVal curitemcounter2 As String, ByVal counter2 As String)
        Me.downloaderlblSpeed2.Text = "Currently downloading item " + curitemcounter2.ToString + " of " + counter2.ToString

        'Me.pbar.MarqueeAnimationSpeed = 20
        Me.downloadertxtFileName2.Text = item2.URL
        Me.downloaderlblSavingFileTo2.Text = item2.Destination
        Me.downloaderlblFileSize2.Text = "File Size: " & "Unable to determine dynamic sizes"
        If Not item2.hideurl Then
            Me.downloaderlblFileDownloading2.Text = "Downloading: " & Me.downloadertxtFileName2.Text
        Else
            Me.downloaderlblFileDownloading2.Text = "Downloading: Full Sized Image from Freecovers.net" '& Me.downloadertxtFileName2.Text
        End If

    End Sub
    'Thread 3 Subroutines
    Private Sub log3(ByVal textlog3 As Int32)

        'If textlog = 13 Then 'clear on newline, look funky
        '    rtbLog.Text = ""
        'End If

        rtbLog3.AppendText(CStr(Convert.ToChar(textlog3)))
        rtbLog3.SelectionStart = rtbLog3.Text.Length
    End Sub
    Private Sub logClear3()
        rtbLog3.Text = ""
    End Sub
    Private Sub changelabels3(ByVal item3 As miplibfc.mip.dlobject, ByVal curitemcounter3 As String, ByVal counter3 As String)
        Me.downloaderlblSpeed3.Text = "Currently downloading item " + curitemcounter3.ToString + " of " + counter3.ToString

        'Me.pbar.MarqueeAnimationSpeed = 20
        Me.downloadertxtFileName3.Text = item3.URL
        Me.downloaderlblSavingFileTo3.Text = item3.Destination
        Me.downloaderlblFileSize3.Text = "File Size: " & "Unable to determine dynamic sizes"
        If Not item3.hideurl Then
            Me.downloaderlblFileDownloading3.Text = "Downloading: " & Me.downloadertxtFileName3.Text
        Else
            Me.downloaderlblFileDownloading3.Text = "Downloading: Full Sized Image from Freecovers.net" '& Me.downloadertxtFileName2.Text
        End If
    End Sub
    'Thread 4 Subroutines
    Private Sub log4(ByVal textlog4 As Int32)

        'If textlog = 13 Then 'clear on newline, look funky
        '    rtbLog.Text = ""
        'End If

        rtbLog4.AppendText(CStr(Convert.ToChar(textlog4)))
        rtbLog4.SelectionStart = rtbLog4.Text.Length
    End Sub
    Private Sub logClear4()
        rtbLog4.Text = ""
    End Sub
    Private Sub changelabels4(ByVal item4 As miplibfc.mip.dlobject, ByVal curitemcounter4 As String, ByVal counter4 As String)
        Me.downloaderlblSpeed4.Text = "Currently downloading item " + curitemcounter4.ToString + " of " + counter4.ToString

        'Me.pbar.MarqueeAnimationSpeed = 20
        Me.downloadertxtFileName4.Text = item4.URL
        Me.downloaderlblSavingFileTo4.Text = item4.Destination
        Me.downloaderlblFileSize4.Text = "File Size: " & "Unable to determine dynamic sizes"
        If Not item4.hideurl Then
            Me.downloaderlblFileDownloading4.Text = "Downloading: " & Me.downloadertxtFileName4.Text
        Else
            Me.downloaderlblFileDownloading4.Text = "Downloading: Full Sized Image from Freecovers.net" '& Me.downloadertxtFileName2.Text
        End If
    End Sub
    'Thread 5 Subroutines
    Private Sub log5(ByVal textlog5 As Int32)

        'If textlog = 13 Then 'clear on newline, look funky
        '    rtbLog.Text = ""
        'End If

        rtbLog5.AppendText(CStr(Convert.ToChar(textlog5)))
        rtbLog5.SelectionStart = rtbLog5.Text.Length
    End Sub
    Private Sub logClear5()
        rtbLog5.Text = ""
    End Sub
    Private Sub changelabels5(ByVal item5 As miplibfc.mip.dlobject, ByVal curitemcounter5 As String, ByVal counter5 As String)
        Me.downloaderlblSpeed5.Text = "Currently downloading item " + curitemcounter5.ToString + " of " + counter5.ToString

        'Me.pbar.MarqueeAnimationSpeed = 20
        Me.downloadertxtFileName5.Text = item5.URL
        Me.downloaderlblSavingFileTo5.Text = item5.Destination
        Me.downloaderlblFileSize5.Text = "File Size: " & "Unable to determine dynamic sizes"
        If Not item5.hideurl Then
            Me.downloaderlblFileDownloading5.Text = "Downloading: " & Me.downloadertxtFileName5.Text
        Else
            Me.downloaderlblFileDownloading5.Text = "Downloading: Full Sized Image from Freecovers.net" '& Me.downloadertxtFileName2.Text
        End If
    End Sub

    Public Sub DownloadComplete(ByVal cancelled As Boolean, Optional ByVal dlretry As Boolean = False)
        Me.downloadertxtFileName.Enabled = True
        'Me.btnDownload.Enabled = True
        Me.downloaderbtnCancel.Enabled = False
        If Not File.Exists(whereToSave) Then
            Dim binfilelocal As String = cconf.wgetfolder + "wget.exe"
            Dim filenameuri As String = Me.downloadertxtFileName.Text
            Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
            pro1.StartInfo.FileName = binfilelocal
            pro1.StartInfo.Arguments = filenameuri + " -O " + """" + whereToSave + """"
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            pro1.Start()
            pro1.WaitForExit()
        End If
        If Not File.Exists(whereToSave) Then
            System.Threading.Thread.Sleep(3000) 'wait 3 seconds
            dlretry = True 'retry it again '3rd attempt 
        End If
        If dlretry Then 'retrycount 4th attempt
            System.Threading.Thread.Sleep(5000) 'wait 5 seconds and try again
            Me.downloaderlblAmountDownloaded.Text = "Stream failed - retrying with backup method..."
            Debug.Print(" ==== ==== ===== ==== ==== ")
            Debug.Print(" ==== ==== ===== ==== ==== ")
            Debug.Print(" ==== ==== RETRY ==== ==== ")
            Debug.Print(" ==== ==== ===== ==== ==== ")

            dlretry = False
            'try again with wget 
            Dim binfilelocal As String = cconf.wgetfolder + "wget.exe"
            Dim filenameuri As String = Me.downloadertxtFileName.Text
            'Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
            Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
            pro1.StartInfo.FileName = binfilelocal
            pro1.StartInfo.Arguments = filenameuri + " -O " + """" + whereToSave + """"
            pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            pro1.Start()
            pro1.WaitForExit()

        End If
        If cancelled Then
            Me.downloaderlblAmountDownloaded.Text = "Cancelled"
            'MessageBox.Show("Download aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
            Me.Close()

        Else
            Me.downloaderlblAmountDownloaded.Text = "Successfully downloaded"
            'MessageBox.Show("Successfully downloaded!", "All OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
            Me.Close()
        End If

        Me.downloaderpbar.Value = 0
        Me.downloaderlblFileDownloading.Text = "Downloading: "
        Me.downloaderlblSavingFileTo.Text = "Save to: "
        Me.downloaderlblFileSize.Text = "File size: "
        Me.downloaderlblSpeed.Text = "Download speed: "
        Me.downloaderlblAmountDownloaded.Text = ""

    End Sub

    Public Sub ChangeTexts(ByVal length As Long, ByVal position As Integer, ByVal percent As Integer, ByVal speed As Double)
        Dim filesizetmp As Double = Math.Round((length / 1024), 2)
        If filesizetmp = 0 Then
            'no file size.. hide status bar and change labels
            Me.downloaderpbar.Style = ProgressBarStyle.Marquee
            'Me.pbar.MarqueeAnimationSpeed = 20
            Me.downloaderlblFileSize.Text = "File Size: " & "Unable to determine dynamic sizes"
            Me.downloaderlblFileDownloading.Text = "Downloading: " & Me.downloadertxtFileName.Text
            Me.downloaderlblAmountDownloaded.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB"

        Else
            Me.downloaderpbar.Style = ProgressBarStyle.Blocks
            Me.downloaderlblFileSize.Text = "File Size: " & Math.Round((length / 1024), 2) & " KB"
            Me.downloaderlblFileDownloading.Text = "Downloading: " & Me.downloadertxtFileName.Text
            Me.downloaderlblAmountDownloaded.Text = "Downloaded " & Math.Round((position / 1024), 2) & " KB of " & Math.Round((length / 1024), 2) & "KB (" & Me.downloaderpbar.Value & "%)"

        End If
        If speed = -1 Then
            Me.downloaderlblSpeed.Text = "Speed: calculating..."
        Else
            Me.downloaderlblSpeed.Text = "Speed: " & Math.Round((speed / 1024), 2) & " KB/s"
        End If
        Me.downloaderpbar.Value = percent
    End Sub

    Public Sub go() '(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownload.Click
        'If Me.txtFileName.Text <> "" AndAlso Me.txtFileName.Text.StartsWith("http://") Then
        '    Me.SaveFileDialog1.FileName = Me.txtFileName.Text.Split("/"c)(Me.txtFileName.Text.Split("/"c).Length - 1)
        '    If Me.SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        Me.whereToSave = Me.SaveFileDialog1.FileName
        '        Me.SaveFileDialog1.FileName = ""
        nomultidownload = False
        If nomultidownload = False Then
            wgetandforget()
            Me.Dispose()
            Me.Close()
        Else
            Me.downloaderlblSavingFileTo.Text = "Save to: " & Me.whereToSave
            'Me.txtFileName.Enabled = False
            'Me.btnDownload.Enabled = False
            Me.downloaderbtnCancel.Enabled = True
            System.Threading.Thread.Sleep(100)
            Me.bwDownloader.RunWorkerAsync() 'Start download
        End If



        '    End If
        'Else
        'MessageBox.Show("Please insert valid URL for download", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub
    Private Sub wgetandforget()
        Dim binfilelocal As String = cconf.wgetfolder + "wget.exe"
        Dim filenameuri As String = Me.downloadertxtFileName.Text
        'Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
        Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        pro1.StartInfo.FileName = binfilelocal
        pro1.StartInfo.Arguments = filenameuri + " -O " + """" + whereToSave + """"
        pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        System.Threading.Thread.Sleep(100) 'wait .03 second(s) before firing off this thread
        pro1.Start()
        pro1.WaitForExit()
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwDownloader.DoWork

        'Creating the request and getting the response
        Dim theResponse As HttpWebResponse
        Dim theRequest As HttpWebRequest
        Try 'Checks if the file exist

            theRequest = CType(WebRequest.Create(Me.downloadertxtFileName.Text), HttpWebRequest)
            theResponse = CType(theRequest.GetResponse, HttpWebResponse)
        Catch ex As Exception

            'MessageBox.Show("An error occurred while downloading file. Possibe causes:" & ControlChars.CrLf & _
            '"1) File doesn't exist" & ControlChars.CrLf & _
            '"2) Remote server error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)

            Me.Invoke(cancelDelegate, True, False)

            Exit Sub
        End Try
        Dim length As Long = theResponse.ContentLength 'Size of the response (in bytes)

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Me.Invoke(safedelegate, length, 0, 0, 0) 'Invoke the TreadsafeDelegate

        Dim writeStream As New IO.FileStream(Me.whereToSave, IO.FileMode.Create)

        'Replacement for Stream.Position (webResponse stream doesn't support seek)
        Dim nRead As Integer

        'To calculate the download speed
        Dim speedtimer As New Stopwatch
        Dim currentspeed As Double = -1
        Dim readings As Integer = 0
        Dim locretry As Boolean = False
        Do

            If bwDownloader.CancellationPending Then 'If user abort download
                Exit Do
            End If

            speedtimer.Start()

            Dim readBytes(4095) As Byte
            Dim bytesread As Integer = 0
            Try
                bytesread = theResponse.GetResponseStream.Read(readBytes, 0, 4096)
            Catch ex As Exception
                Debug.Print(ex.ToString)
                locretry = True
                Exit Do

            End Try


            nRead += bytesread
            Dim percent As Short
            Try
                If length = -1 Then
                    percent = 0
                Else
                    percent = CShort((nRead / length) * 100)
                End If

            Catch ex As Exception
                percent = 0
            End Try


            Me.Invoke(safedelegate, length, nRead, percent, currentspeed)

            If bytesread = 0 Then Exit Do

            writeStream.Write(readBytes, 0, bytesread)

            speedtimer.Stop()

            readings += 1
            If readings >= 15 Then 'For increase precision, the speed it's calculated only every fifteen cicles
                currentspeed = 20480 / (speedtimer.ElapsedMilliseconds / 1000)
                speedtimer.Reset()
                readings = 0
            End If
        Loop

        'Close the streams
        theResponse.GetResponseStream.Close()
        writeStream.Close()

        If locretry = True Then
            IO.File.Delete(Me.whereToSave)
            Dim retryDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(retryDelegate, False, True)
            Exit Sub
        End If

        If Me.bwDownloader.CancellationPending Then
            IO.File.Delete(Me.whereToSave)
            Dim cancelDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
            Me.Invoke(cancelDelegate, True, False)
            Exit Sub
        End If

        Dim completeDelegate As New DownloadCompleteSafe(AddressOf DownloadComplete)
        Me.Invoke(completeDelegate, False, False)

    End Sub
    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If precaching Then maincollection.Hide()
        'DeleteMenu(iMenu, 6, MF_BYPOSITION) ' Disable the 'X' (Control Box)
        'DeleteMenu(iMenu, 5, MF_BYPOSITION) ' Remove the seperator bar
        Me.downloaderlblAmountDownloaded.Text = ""
        Me.rtbLog.Text = ".. Starting .."
        If Not downloadingmutliimages Then
            rtbLog.Visible = False
            go()
        Else
            downloaderbtnCancel.Enabled = False
            downloaderbtnCancel.Visible = False
            downloaderlblAmountDownloaded.Visible = False
            'downloaderlblSpeed.Visible = False
            gomultidownloader()
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downloaderbtnCancel.Click
        Me.bwDownloader.CancelAsync() 'Send cancel request
        downloaderbtnCancel.Enabled = False
    End Sub
    Private Sub btngo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downloaderbtngo.Click
        go()

    End Sub


    Private Sub gomultidownloader()
        'split the download list in half
        Dim totalcou As Integer = downloadlist.Count
        Dim halfcou As Integer = CInt(totalcou / 2)
        Dim n As Integer = CInt(totalcou / 5)

        'take that counter (halfcou) and put those items in downloadlist_t1
        Dim curcount As Integer = 0
        'While curcount < totalcou
        For Each itemObj In downloadlist
            If curcount < n Then
                'put it into t1
                downloadlist_t1.Add(itemObj)
            ElseIf curcount > n And curcount < (n + n) Then
                'put it into t2
                downloadlist_t2.Add(itemObj)
            ElseIf curcount > (n + n) And curcount < (n + n + n) Then
                'put it into t3
                downloadlist_t3.Add(itemObj)
            ElseIf curcount > (n + n + n) And curcount < (n + n + n + n) Then
                'put it into t4
                downloadlist_t4.Add(itemObj)
            Else
                'put it into t5
                downloadlist_t5.Add(itemObj)
            End If
            curcount += 1
        Next
        'Debug.Print(downloadlist_t1.Count.ToString)
        'Debug.Print(downloadlist_t2.Count.ToString)
        'Debug.Print(downloadlist.Count.ToString)
        Me.Text = downloadlist.Count.ToString + " File Download(s) In Progress"
        'End While
        Me.downloaderpbar.Style = ProgressBarStyle.Blocks
        Me.downloaderpbar.Maximum = downloadlist_t1.Count
        Me.downloaderpbar2.Style = ProgressBarStyle.Blocks
        Me.downloaderpbar2.Maximum = downloadlist_t2.Count
        Me.downloaderpbar3.Style = ProgressBarStyle.Blocks
        Me.downloaderpbar3.Maximum = downloadlist_t3.Count
        Me.downloaderpbar4.Style = ProgressBarStyle.Blocks
        Me.downloaderpbar4.Maximum = downloadlist_t4.Count
        Me.downloaderpbar5.Style = ProgressBarStyle.Blocks
        Me.downloaderpbar5.Maximum = downloadlist_t5.Count
        btnCancel.Enabled = True
        bwmutlidownload = New System.ComponentModel.BackgroundWorker
        bwmutlidownload.WorkerReportsProgress = True
        bwmutlidownload.WorkerSupportsCancellation = True
        bwmutlidownload.RunWorkerAsync()
        bwmutlidownload2 = New System.ComponentModel.BackgroundWorker
        bwmutlidownload2.WorkerReportsProgress = True
        bwmutlidownload2.WorkerSupportsCancellation = True
        bwmutlidownload2.RunWorkerAsync()
        bwmutlidownload3 = New System.ComponentModel.BackgroundWorker
        bwmutlidownload3.WorkerReportsProgress = True
        bwmutlidownload3.WorkerSupportsCancellation = True
        bwmutlidownload3.RunWorkerAsync()
        bwmutlidownload4 = New System.ComponentModel.BackgroundWorker
        bwmutlidownload4.WorkerReportsProgress = True
        bwmutlidownload4.WorkerSupportsCancellation = True
        bwmutlidownload4.RunWorkerAsync()
        bwmutlidownload5 = New System.ComponentModel.BackgroundWorker
        bwmutlidownload5.WorkerReportsProgress = True
        bwmutlidownload5.WorkerSupportsCancellation = True
        bwmutlidownload5.RunWorkerAsync()
        'Dim procs() As Process
        '' get an array of all processes named "app" on server "serverName"
        'procs = Process.GetProcessesByName("wget.exe")

        '' go through each proc named "app" and wait for it to exit
        'For Each proc In procs
        '    proc.WaitForExit()
        'Next
    End Sub

#Region "Thread 1 handlers"
    Private Sub bwmultidownloader_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwmutlidownload.DoWork
        Dim counter As Integer = 0
        counter = downloadlist_t1.Count
        Dim curitemcounter As Integer = 0
        Try


            For Each item As miplibfc.mip.dlobject In downloadlist_t1
                If bwmutlidownload.CancellationPending Then Exit For
                bwmutlidownload.ReportProgress(curitemcounter, item)
                'clear the log portion
                'Try
                '    Dim safedelegate2clear As New logSafeClear(AddressOf logClear)
                '    Me.Invoke(safedelegate2clear)
                '    update text boxes
                '    Dim safedelegate As New changelabelsSafe(AddressOf changelabels)
                '    Me.Invoke(safedelegate, item, curitemcounter.ToString, counter.ToString) 'Invoke the TreadsafeDelegate
                'Catch ex As Exception
                '    Debug.Print(ex.ToString)
                'End Try

                curitemcounter += 1
                If Not File.Exists(item.Destination) Then
                    Dim filenameuri As String = item.URL
                    Dim pro1 As Process = New Process()
                    pro1.StartInfo.FileName = binfilelocal
                    pro1.StartInfo.Arguments = filenameuri + " -t 3 -T 60 -O " + """" + item.Destination + """"
                    pro1.StartInfo.RedirectStandardError = True
                    pro1.StartInfo.UseShellExecute = False
                    pro1.StartInfo.CreateNoWindow = True
                    pro1.Start()
                    'pro1.WaitForExit()
                    Dim sErr As System.IO.StreamReader = pro1.StandardError
                    Dim i32TmpInt As Int32
                    i32TmpInt = sErr.Read()
                    Dim safedelegate2 As New logSafe(AddressOf log)

                    While i32TmpInt <> -1
                        Try
                            ' Me.Invoke(safedelegate2, i32TmpInt)
                            i32TmpInt = sErr.Read()
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try

                    End While
                End If
                If File.Exists(item.Destination) Then
                    'check it's size, 0k files need to be removed
                    Try
                        File.SetAttributes(item.Destination, FileAttributes.Normal)
                    Catch ex As Exception

                    End Try

                End If
            Next
            Dim itemF As New miplibfc.mip.dlobject
            itemF.URL = "COMPLETED"
            itemF.Destination = "COMPLETED"
            bwmutlidownload.ReportProgress(curitemcounter, itemF)
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwmutlidownload.ProgressChanged
        Try
            downloaderpbar.Value = e.ProgressPercentage
            Dim item5 As miplibfc.mip.dlobject
            item5 = CType(e.UserState, miplibfc.mip.dlobject)
            Me.downloaderlblSpeed.Text = "Currently downloading item " + e.ProgressPercentage.ToString + " of " + downloadlist_t1.Count.ToString
            Me.downloadertxtFileName.Text = item5.URL
            Me.downloaderlblSavingFileTo.Text = item5.Destination
            Dim dltext As String = item5.URL
            If item5.hideurl Then dltext = item5.misc
            Me.downloaderlblFileDownloading.Text = "Downloading: " & dltext 'item5.URL
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        'lblPCWorking.Text = e.UserState.ToString
    End Sub
    Private Sub bwmutlidownload_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwmutlidownload.RunWorkerCompleted
        thread1_completed = True
        waitforthreadcompletion()
    End Sub
#End Region

#Region "Thread 2 handlers"
    Private Sub bwmultidownloader2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwmutlidownload2.DoWork
        Try
            Dim counter As Integer = 0
            counter = downloadlist_t2.Count
            Dim curitemcounter As Integer = 0


            For Each item As miplibfc.mip.dlobject In downloadlist_t2
                If bwmutlidownload2.CancellationPending Then Exit For
                bwmutlidownload2.ReportProgress(curitemcounter, item)
                'clear the log portion
                'Try
                '    Dim safedelegate2clear2 As New logSafeClear2(AddressOf logClear2)
                '    Me.Invoke(safedelegate2clear2)
                '    'update text boxes
                '    Dim safedelegate2 As New changelabelsSafe2(AddressOf changelabels2)
                '    Me.Invoke(safedelegate2, item, curitemcounter.ToString, counter.ToString) 'Invoke the TreadsafeDelegate
                'Catch ex As Exception
                '    Debug.Print(ex.ToString)
                'End Try
                curitemcounter += 1
                If Not File.Exists(item.Destination) Then
                    Dim filenameuri As String = item.URL
                    Dim pro2 As Process = New Process()
                    pro2.StartInfo.FileName = binfilelocal
                    pro2.StartInfo.Arguments = filenameuri + " -t 3 -T 60  -O " + """" + item.Destination + """"
                    pro2.StartInfo.RedirectStandardError = True
                    pro2.StartInfo.UseShellExecute = False
                    pro2.StartInfo.CreateNoWindow = True
                    pro2.Start()
                    'pro2.WaitForExit()
                    Dim sErr2 As System.IO.StreamReader = pro2.StandardError
                    Dim i32TmpInt2 As Int32
                    i32TmpInt2 = sErr2.Read()
                    Dim safedelegate22 As New logSafe2(AddressOf log2)

                    While i32TmpInt2 <> -1
                        Try
                            ' Me.Invoke(safedelegate22, i32TmpInt2)
                            i32TmpInt2 = sErr2.Read()
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try

                    End While
                End If

                If File.Exists(item.Destination) Then
                    'check it's size, 0k files need to be removed
                    Try
                        File.SetAttributes(item.Destination, FileAttributes.Normal)
                    Catch ex As Exception

                    End Try

                End If
            Next
            Dim itemF As New miplibfc.mip.dlobject
            itemF.URL = "COMPLETED"
            itemF.Destination = "COMPLETED"
            bwmutlidownload2.ReportProgress(curitemcounter, itemF)
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        'Dim consoleApp As New Process
        'With consoleApp
        '    .StartInfo.UseShellExecute = False
        '    .StartInfo.RedirectStandardOutput = True
        '    .StartInfo.FileName = "ConsoleApplication.exe"
        '    .Start()
        '    .WaitForExit()
        'End With

        'Dim output As String = consoleApp.StandardOutput.ReadToEnd()


        ''Dim binfilelocal As String = cconf.wgetfolder + "wget.exe"
        'Dim filenameuri As String = Me.downloadertxtFileName.Text
        ''Debug.Print(binfilelocal + url + " -P " + """" + folder + """")
        'Dim pro1 As System.Diagnostics.Process = New System.Diagnostics.Process()
        'pro1.StartInfo.FileName = binfilelocal
        'pro1.StartInfo.Arguments = filenameuri + " -O " + """" + Me.downloaderlblSavingFileTo.Text + """"
        'pro1.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        ''System.Threading.Thread.Sleep(100) 'wait .03 second(s) before firing off this thread
        'pro1.Start()
        'pro1.WaitForExit()
    End Sub
    Private Sub bwmutlidownload2_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwmutlidownload2.ProgressChanged
        Try
            downloaderpbar2.Value = e.ProgressPercentage
            Dim item5 As miplibfc.mip.dlobject
            item5 = CType(e.UserState, miplibfc.mip.dlobject)
            Me.downloaderlblSpeed2.Text = "Currently downloading item " + e.ProgressPercentage.ToString + " of " + downloadlist_t2.Count.ToString
            Me.downloadertxtFileName2.Text = item5.URL
            Me.downloaderlblSavingFileTo2.Text = item5.Destination
            Dim dltext As String = item5.URL
            If item5.hideurl Then dltext = item5.misc
            Me.downloaderlblFileDownloading2.Text = "Downloading: " & dltext 'item5.URL
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
        'lblPCWorking.Text = e.UserState.ToString
    End Sub
    Private Sub bwmutlidownload2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwmutlidownload2.RunWorkerCompleted
        thread2_completed = True
        waitforthreadcompletion()
    End Sub
#End Region

#Region "Thread 3 handlers"
    Private Sub bwmultidownloader3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwmutlidownload3.DoWork
        Try
            Dim counter As Integer = 0
            counter = downloadlist_t3.Count
            Dim curitemcounter As Integer = 0

            For Each item As miplibfc.mip.dlobject In downloadlist_t3
                If bwmutlidownload3.CancellationPending Then Exit For
                bwmutlidownload3.ReportProgress(curitemcounter, item)
                'clear the log portion
                'Try
                '    Dim safedelegate3clear3 As New logSafeClear3(AddressOf logClear3)
                '    Me.Invoke(safedelegate3clear3)
                '    'update text boxes
                '    Dim safedelegate3 As New changelabelsSafe3(AddressOf changelabels3)
                '    Me.Invoke(safedelegate3, item, curitemcounter.ToString, counter.ToString) 'Invoke the TreadsafeDelegate
                'Catch ex As Exception
                '    Debug.Print(ex.ToString)
                'End Try
                curitemcounter += 1
                If Not File.Exists(item.Destination) Then
                    Dim filenameuri As String = item.URL
                    Dim pro3 As Process = New Process()
                    pro3.StartInfo.FileName = binfilelocal
                    pro3.StartInfo.Arguments = filenameuri + " -t 3 -T 60 -O " + """" + item.Destination + """"
                    pro3.StartInfo.RedirectStandardError = True
                    pro3.StartInfo.UseShellExecute = False
                    pro3.StartInfo.CreateNoWindow = True
                    pro3.Start()
                    'pro3.WaitForExit()
                    Dim sErr3 As System.IO.StreamReader = pro3.StandardError
                    Dim i33TmpInt3 As Int32
                    i33TmpInt3 = sErr3.Read()
                    Dim safedelegate33 As New logSafe3(AddressOf log3)

                    While i33TmpInt3 <> -1
                        Try
                            ' Me.Invoke(safedelegate33, i33TmpInt3)
                            i33TmpInt3 = sErr3.Read()
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try

                    End While
                End If

                If File.Exists(item.Destination) Then
                    'check it's size, 0k files need to be removed
                    Try
                        File.SetAttributes(item.Destination, FileAttributes.Normal)
                    Catch ex As Exception

                    End Try

                End If
            Next
            Dim itemF As New miplibfc.mip.dlobject
            itemF.URL = "COMPLETED"
            itemF.Destination = "COMPLETED"
            bwmutlidownload3.ReportProgress(curitemcounter, itemF)
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload3_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwmutlidownload3.ProgressChanged
        Try
            downloaderpbar3.Value = e.ProgressPercentage
            Dim item5 As miplibfc.mip.dlobject
            item5 = CType(e.UserState, miplibfc.mip.dlobject)
            Me.downloaderlblSpeed3.Text = "Currently downloading item " + e.ProgressPercentage.ToString + " of " + downloadlist_t3.Count.ToString
            Me.downloadertxtFileName3.Text = item5.URL
            Me.downloaderlblSavingFileTo3.Text = item5.Destination
            Dim dltext As String = item5.URL
            If item5.hideurl Then dltext = item5.misc
            Me.downloaderlblFileDownloading3.Text = "Downloading: " & dltext 'item5.URL
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload3_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwmutlidownload3.RunWorkerCompleted

        thread3_completed = True
        waitforthreadcompletion()
    End Sub
#End Region

#Region "Thread 4 handlers"
    Private Sub bwmultidownloader4_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwmutlidownload4.DoWork
        Try
            Dim counter As Integer = 0
            counter = downloadlist_t4.Count
            Dim curitemcounter As Integer = 0

            For Each item As miplibfc.mip.dlobject In downloadlist_t4
                If bwmutlidownload4.CancellationPending Then Exit For
                bwmutlidownload4.ReportProgress(curitemcounter, item)
                'clear the log portion
                'Try
                '    Dim safedelegate4clear4 As New logSafeClear4(AddressOf logClear4)
                '    Me.Invoke(safedelegate4clear4)
                '    'update text boxes
                '    Dim safedelegate4 As New changelabelsSafe4(AddressOf changelabels4)
                '    Me.Invoke(safedelegate4, item, curitemcounter.ToString, counter.ToString) 'Invoke the TreadsafeDelegate
                'Catch ex As Exception
                '    Debug.Print(ex.ToString)
                'End Try
                curitemcounter += 1
                If Not File.Exists(item.Destination) Then
                    Dim filenameuri As String = item.URL
                    Dim pro4 As Process = New Process()
                    pro4.StartInfo.FileName = binfilelocal
                    pro4.StartInfo.Arguments = filenameuri + " -t 3 -T 60 -O " + """" + item.Destination + """"
                    pro4.StartInfo.RedirectStandardError = True
                    pro4.StartInfo.UseShellExecute = False
                    pro4.StartInfo.CreateNoWindow = True
                    pro4.Start()
                    ' pro4.WaitForExit()
                    Dim sErr4 As System.IO.StreamReader = pro4.StandardError
                    Dim i44TmpInt4 As Int32
                    i44TmpInt4 = sErr4.Read()
                    Dim safedelegate44 As New logSafe4(AddressOf log4)

                    While i44TmpInt4 <> -1
                        Try
                            'Me.Invoke(safedelegate44, i44TmpInt4)
                            i44TmpInt4 = sErr4.Read()
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try

                    End While
                End If

                If File.Exists(item.Destination) Then
                    'check it's size, 0k files need to be removed
                    Try
                        File.SetAttributes(item.Destination, FileAttributes.Normal)
                    Catch ex As Exception

                    End Try

                End If
            Next
            Dim itemF As New miplibfc.mip.dlobject
            itemF.URL = "COMPLETED"
            itemF.Destination = "COMPLETED"
            bwmutlidownload4.ReportProgress(curitemcounter, itemF)
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload4_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwmutlidownload4.ProgressChanged
        Try
            downloaderpbar4.Value = e.ProgressPercentage
            Dim item5 As miplibfc.mip.dlobject
            item5 = CType(e.UserState, miplibfc.mip.dlobject)
            Me.downloaderlblSpeed4.Text = "Currently downloading item " + e.ProgressPercentage.ToString + " of " + downloadlist_t4.Count.ToString
            Me.downloadertxtFileName4.Text = item5.URL
            Me.downloaderlblSavingFileTo4.Text = item5.Destination
            Dim dltext As String = item5.URL
            If item5.hideurl Then dltext = item5.misc

            Me.downloaderlblFileDownloading4.Text = "Downloading: " & dltext 'item5.URL
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload4_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwmutlidownload4.RunWorkerCompleted
        thread4_completed = True
        waitforthreadcompletion()
    End Sub
#End Region

#Region "Thread 5 handlers"
    Private Sub bwmultidownloader5_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwmutlidownload5.DoWork
        Try
            Dim counter As Integer = 0
            counter = downloadlist_t5.Count
            Dim curitemcounter As Integer = 0

            For Each item As miplibfc.mip.dlobject In downloadlist_t5
                If bwmutlidownload5.CancellationPending Then Exit For
                bwmutlidownload5.ReportProgress(curitemcounter, item)
                'clear the log portion
                'Try
                '    Dim safedelegate5clear5 As New logSafeClear5(AddressOf logClear5)
                '    Me.Invoke(safedelegate5clear5)
                '    'update text boxes
                '    Dim safedelegate5 As New changelabelsSafe5(AddressOf changelabels5)
                '    Me.Invoke(safedelegate5, item, curitemcounter.ToString, counter.ToString) 'Invoke the TreadsafeDelegate

                'Catch ex As Exception
                '    Debug.Print(ex.ToString)
                'End Try
                curitemcounter += 1
                If Not File.Exists(item.Destination) Then
                    Dim filenameuri As String = item.URL
                    Dim pro5 As Process = New Process()
                    pro5.StartInfo.FileName = binfilelocal
                    pro5.StartInfo.Arguments = filenameuri + " -t 3 -T 60 -O " + """" + item.Destination + """"
                    pro5.StartInfo.RedirectStandardError = True
                    pro5.StartInfo.UseShellExecute = False
                    pro5.StartInfo.CreateNoWindow = True
                    pro5.Start()
                    'pro5.WaitForExit()
                    Dim sErr5 As System.IO.StreamReader = pro5.StandardError
                    Dim i55TmpInt5 As Int32
                    i55TmpInt5 = sErr5.Read()
                    Dim safedelegate55 As New logSafe5(AddressOf log5)

                    While i55TmpInt5 <> -1
                        Try
                            '  Me.Invoke(safedelegate55, i55TmpInt5)
                            i55TmpInt5 = sErr5.Read()
                        Catch ex As Exception
                            Debug.Print(ex.ToString)
                        End Try

                    End While
                End If

                If File.Exists(item.Destination) Then
                    'check it's size, 0k files need to be removed
                    Try
                        File.SetAttributes(item.Destination, FileAttributes.Normal)
                    Catch ex As Exception

                    End Try

                End If
            Next
            Dim itemF As New miplibfc.mip.dlobject
            itemF.URL = "COMPLETED"
            itemF.Destination = "COMPLETED"
            bwmutlidownload5.ReportProgress(curitemcounter, itemF)
            System.Threading.Thread.Sleep(1000)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload5_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles bwmutlidownload5.ProgressChanged
        Try
            downloaderpbar5.Value = e.ProgressPercentage
            Dim item5 As miplibfc.mip.dlobject
            item5 = CType(e.UserState, miplibfc.mip.dlobject)
            Me.downloaderlblSpeed5.Text = "Currently downloading item " + e.ProgressPercentage.ToString + " of " + downloadlist_t5.Count.ToString
            Dim dltext As String = item5.URL
            If item5.hideurl Then dltext = item5.misc
            Me.downloadertxtFileName5.Text = item5.URL
            Me.downloaderlblSavingFileTo5.Text = item5.Destination
            Me.downloaderlblFileDownloading5.Text = "Downloading: " & dltext
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub
    Private Sub bwmutlidownload5_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwmutlidownload5.RunWorkerCompleted

        thread5_completed = True
        waitforthreadcompletion()
    End Sub
#End Region

    Private Sub waitforthreadcompletion()
        Try
            If thread1_completed And thread2_completed And thread3_completed And thread4_completed And thread5_completed Then
                System.Threading.Thread.Sleep(1000) 'give it time to process any bw's before disposing
                If precaching Then maincollection.Show()
                Dim scclosemyselfsafe As New closemyselfsafe(AddressOf closemyself)
                Me.Invoke(scclosemyselfsafe)
            End If
            System.Threading.Thread.Sleep(100)
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        bwmutlidownload.CancelAsync()
        bwmutlidownload2.CancelAsync()
        bwmutlidownload3.CancelAsync()
        bwmutlidownload4.CancelAsync()
        bwmutlidownload5.CancelAsync()
    End Sub
End Class
