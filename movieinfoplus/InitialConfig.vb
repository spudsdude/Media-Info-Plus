Imports System
Imports System.IO
Imports System.Net
Imports System.Text
'Imports System.Windows.Media.Imaging
'Imports System.Windows.Media
'Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Xml.Serialization
Public Class InitialConfig

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        saveconfig()
        Dim getres As New resource_extractor
        getres.createresources()
        'MsgBox("You ** MUST ** restart the application for the settings to take effect")
        Me.Close()


    End Sub
    Private Sub saveconfig()
        Dim curConfig As New configuration
        If cbGetIMDBInfo.Checked Then curConfig.pcbGetIMDBInfo = True
        If cbDownloadPoster.Checked Then curConfig.pcbDownloadPoster = True
        If cbDownloadPoster.Checked Then curConfig.pcbGetTMDBPosters = True
        If cbGenTBN.Checked Then curConfig.pcbGenTBN = True
        If cbGetFanart.Checked Then curConfig.pcbGetFanart = True
        If cbFanForBack.Checked Then curConfig.pdisplayfanart = True
        If cbSaveNFO.Checked Then curConfig.pcbSaveNFO = True
        If cbOverwriteNFO.Checked Then curConfig.pcbOverwriteNFO = True
        If cbf1s0.Checked Then curConfig.pcbf1s0 = True
        If cbf1s3.Checked Then curConfig.pcbf1s3 = True
        If cbf1s9.Checked Then curConfig.pcbf1s9 = True
        If cbf2s0.Checked Then curConfig.pcbf2s0 = True
        If cbf2s2.Checked Then curConfig.pcbf2s2 = True
        If cbf2s8.Checked Then curConfig.pcbf2s8 = True
        If cbf2s10.Checked Then curConfig.pcbf2s10 = True
        If cbf3s0.Checked Then curConfig.pcbf3s0 = True
        curConfig.pworkoffline = False
        If cbMaxIconPerStyle.SelectedIndex < 1 Then
            curConfig.pcbMaxIconPerStyle = 8 'cbMaxIconPerStyle.SelectedIndex
        Else
            curConfig.pcbMaxIconPerStyle = cbMaxIconPerStyle.SelectedIndex
        End If

        curConfig.pcbMaxIconsToDisplay = cbMaxIconsToDisplay.SelectedIndex
        curConfig.pcbDlFormat = cboxType.SelectedIndex
        'get length of clbpaths, then get each item, then add to arraylist
        Dim len As Integer = clbPaths.Items.Count
        If len = 0 Then
            'nothing to process
        Else
            Dim count As Integer = 0
            While count < len
                curConfig.pclbPaths.Add(clbPaths.Items(count))
                count += 1
            End While

        End If
        'For Each item In CType(clbPaths, ArrayList)

        'curConfig.pclbPaths1 = CStr(clbPaths.Items(0))
        'curConfig.pclbPaths2 = CStr(clbPaths.Items(1))
        If cbFilter1080p.Checked Then curConfig.pcbFilter1080p = True
        If cbFilter720p.Checked Then curConfig.pcbFilter720p = True
        If cbFilterAvi.Checked Then curConfig.pcbFilterAvi = True
        If cbFilterBluRay.Checked Then curConfig.pcbFilterBluRay = True
        If cbFilterCustom1.Checked Then curConfig.pcbFilterCustom1 = tbCustomFilter1.Text
        If cbFilterCustom2.Checked Then curConfig.pcbFilterCustom2 = tbCustomFilter2.Text
        If cbFilterCustom3.Checked Then curConfig.pcbFilterCustom3 = tbCustomFilter3.Text
        If cbFilterCustom4.Checked Then curConfig.pcbFilterCustom4 = tbCustomFilter4.Text
        If cbFilterDivx.Checked Then curConfig.pcbFilterDivx = True
        If cbFilterDVD.Checked Then curConfig.pcbFilterDVD = True
        If cbFilterH264.Checked Then curConfig.pcbFilterH264 = True
        If cbFilterHidef.Checked Then curConfig.pcbFilterHidef = True
        If cbFilterLq.Checked Then curConfig.pcbFilterLq = True
        If cbFilterXvid.Checked Then curConfig.pcbFilterXvid = True
        If cbIgnore1080i.Checked Then curConfig.pcbFilter1080i = True
        If cbIgnoreYears.Checked Then curConfig.pcbFilterYears = True
        curConfig.saveConfig(curConfig)
    End Sub

    Private Sub InitialConfig_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Directory.Exists("c:\Program Files\movieinfoplus") Then Directory.CreateDirectory("c:\Program Files\movieinfoplus")
    End Sub

    Private Sub btnAddtoclb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddtoclb.Click
       
        If Directory.Exists(tbFolder.Text) Then
        Else
            MsgBox("No such directory on system, check the path you entered in the box above")
            Exit Sub

        End If
        Dim clbarray As New ArrayList

        For Each listedpath In clbPaths.Items
            clbarray.Add(listedpath)
        Next

        If clbarray.Contains(tbFolder.Text) Then
            MsgBox("Path already added to list")
            Exit Sub
        Else
            clbPaths.Items.Add(tbFolder.Text, True)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        tbFolder.Text = FolderBrowserDialog1.SelectedPath
        addtolist()
    End Sub

    Private Sub addtolist()
        'check the added path to make sure it's valid on the system
        'TODO add check
        If Directory.Exists(tbFolder.Text) Then
            'MsgBox("valid")
        Else
            MsgBox("No such directory on system, check the path you entered in the box above")
            Exit Sub

        End If
        'create array of item in list
        Dim clbarray As New ArrayList

        For Each listedpath In clbPaths.Items
            clbarray.Add(listedpath)
        Next

        If clbarray.Contains(tbFolder.Text) Then
            MsgBox("Path already added to list")
            Exit Sub
        Else
            clbPaths.Items.Add(tbFolder.Text, True)

        End If

    End Sub

    Private Sub tbFolder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbFolder.TextChanged
        If Directory.Exists(tbFolder.Text) Then
            btnAddtoclb.Enabled = True
        Else
            btnAddtoclb.Enabled = False
        End If
    End Sub
End Class