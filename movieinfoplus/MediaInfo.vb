Option Strict Off

'' MediaInfoDLL - All info about media files, for DLL
'' Copyright (C) 2002-2006 Jerome Martinez, Zen@MediaArea.net
'' Portions (C) 2008-2009 MDI under GPL
'' This library is free software; you can redistribute it and/or
'' modify it under the terms of the GNU Lesser General Public
'' License as published by the Free Software Foundation; either
'' version 2.1 of the License, or (at your option) any later version.
''
'' This library is distributed in the hope that it will be useful,
'' but WITHOUT ANY WARRANTY; without even the implied warranty of
'' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
'' Lesser General Public License for more details.
''
'' You should have received a copy of the GNU Lesser General Public
'' License along with this library; if not, write to the Free Software
'' Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
''
''+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
''+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
''
'' Microsoft Visual Basic wrapper for MediaInfo Library - Modified for use with Movie Info Plus
'' See MediaInfo.h for help
''
'' To make it working, you must put MediaInfo.Dll
'' in the executable folder
''
''+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

Imports System.Runtime.InteropServices
Imports System.IO

Public Enum StreamKind As UInteger
    General
    Visual
    Audio
    Text
    Chapters
    Image
    Menu
    Max
End Enum

Public Enum InfoKind As UInteger
    Name
    Text
    Measure
    Options
    NameText
    MeasureText
    Info
    HowTo
    Max
End Enum

Public Enum InfoOptions As UInteger
    ShowInInform
    Reserved
    ShowInSupported
    TypeOfValue
    Max
End Enum

Public Class MediaInfo
    Private Declare Unicode Function MediaInfo_New Lib "MediaInfo.DLL" () As IntPtr
    Private Declare Unicode Sub MediaInfo_Delete Lib "MediaInfo.DLL" (ByVal Handle As IntPtr)
    Private Declare Unicode Function MediaInfo_Open Lib "MediaInfo.DLL" (ByVal Handle As IntPtr, ByVal FileName As String) As UIntPtr
    Private Declare Unicode Sub MediaInfo_Close Lib "MediaInfo.DLL" (ByVal Handle As IntPtr)
    Private Declare Unicode Function MediaInfo_Inform Lib "MediaInfo.DLL" (ByVal Handle As IntPtr, ByVal Reserved As UIntPtr) As IntPtr
    Private Declare Unicode Function MediaInfo_GetI Lib "MediaInfo.DLL" (ByVal Handle As IntPtr, ByVal StreamKind As UIntPtr, ByVal StreamNumber As UIntPtr, ByVal Parameter As UIntPtr, ByVal KindOfInfo As UIntPtr) As IntPtr 'See MediaInfoDLL.h for enumeration values
    Private Declare Unicode Function MediaInfo_Get Lib "MediaInfo.DLL" (ByVal Handle As IntPtr, ByVal StreamKind As UIntPtr, ByVal StreamNumber As UIntPtr, ByVal Parameter As String, ByVal KindOfInfo As UIntPtr, ByVal KindOfSearch As UIntPtr) As IntPtr
    Private Declare Unicode Function MediaInfo_Option Lib "MediaInfo.DLL" (ByVal Handle As IntPtr, ByVal Option_ As String, ByVal Value As String) As IntPtr
    Private Declare Unicode Function MediaInfo_State_Get Lib "MediaInfo.DLL" (ByVal Handle As IntPtr) As UIntPtr 'see MediaInfo.h for details
    Private Declare Unicode Function MediaInfo_Count_Get Lib "MediaInfo.DLL" (ByVal Handle As IntPtr, ByVal StreamKind As UIntPtr, ByVal StreamNumber As IntPtr) As UIntPtr 'see MediaInfoDLL.h for enumeration values

    Dim Handle As IntPtr

    Sub New()
        Handle = MediaInfo_New()
    End Sub
    Protected Overrides Sub Finalize()
        MediaInfo_Delete(Handle)
    End Sub
    Function Open(ByVal FileName As String) As Integer
        Return MediaInfo_Open(Handle, FileName)
    End Function
    Sub Close()
        MediaInfo_Close(Handle)
    End Sub
    Function Inform() As String
        Return Marshal.PtrToStringUni(MediaInfo_Inform(Handle, 0))
    End Function
    Function Get_(ByVal StreamKind As StreamKind, ByVal StreamNumber As Integer, ByVal Parameter As Integer, Optional ByVal KindOfInfo As InfoKind = InfoKind.Text) As String
        Return Marshal.PtrToStringUni(MediaInfo_GetI(Handle, StreamKind, StreamNumber, Parameter, KindOfInfo))
    End Function
    Function Get_(ByVal StreamKind As StreamKind, ByVal StreamNumber As Integer, ByVal Parameter As String, Optional ByVal KindOfInfo As InfoKind = InfoKind.Text, Optional ByVal KindOfSearch As InfoKind = InfoKind.Name) As String
        Return Marshal.PtrToStringUni(MediaInfo_Get(Handle, StreamKind, StreamNumber, Parameter, KindOfInfo, KindOfSearch))
    End Function
    Function Option_(ByVal Option__ As String, Optional ByVal Value As String = "") As String
        Return Marshal.PtrToStringUni(MediaInfo_Option(Handle, Option__, Value))
    End Function
    Function State_Get() As Integer
        Return MediaInfo_State_Get(Handle)
    End Function
    Function Count_Get(ByVal StreamKind As StreamKind, Optional ByVal StreamNumber As UInteger = UInteger.MaxValue) As Integer
        If StreamNumber = UInteger.MaxValue Then
            Dim A As Long
            A = 0
            A = A - 1 'If you know how to have (IntPtr)(-1) easier, I am interested ;-)
            Return MediaInfo_Count_Get(Handle, StreamKind, A)
        Else
            Return MediaInfo_Count_Get(Handle, StreamKind, StreamNumber)
        End If
    End Function
    Private Function addfiletofolder(ByVal tvar_path As String, ByVal tvar_filename As String) As String
        If Not Strings.Right(tvar_path, 1) = "\" Then
            tvar_path += "\"
        End If
        Dim rFullPath As String = tvar_path + tvar_filename
        Return rFullPath
    End Function
    Private Function getfilenamefrommovie(ByRef currentmovie As movieinfoplus.movie, ByVal moviemode As String) As String
        Dim filenamewithfullpath As String = ""
        If moviemode = "file" Then
            'curmovienamebasedonmode = stripstackforfilemode(removeextension(currentmovie.preservedmoviename))
            filenamewithfullpath = addfiletofolder(currentmovie.getmoviepath, currentmovie.preservedmoviename)
            Return filenamewithfullpath
        End If

        Dim filelisting As New ArrayList
        For Each item In Directory.GetFiles(currentmovie.getmoviepath)
            filelisting.Add(item)
        Next

        If filelisting.Count = 0 Then
            Return "nofile"
        End If

        For Each fileinlisting In filelisting
            Dim fourr_ext As String = ""
            Try
                fourr_ext = Strings.Right(fileinlisting.ToString, 4).ToLower
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try

            Dim fnPeices1() As String = fileinlisting.ToString.Split(CChar("\"))
            Dim tfname As String = fnPeices1(fnPeices1.Length - 1)

            Select Case fourr_ext
                Case ".iso", ".img", ".dat", ".bin", ".cue", ".vob", ".dvb", ".m2t", ".mts", ".evo", ".mp4", ".avi", ".asf", ".asx", ".wmv", ".wma", ".mov", ".flv", ".swf", ".nut", ".avs", ".nsv", ".mp4", ".ram", ".ogg", ".ogm", ".ogv", ".mkv", ".viv", ".pva", ".mpg", ".mp4", ".m4v"
                    'make sure it's not a trailer file
                    If Not tfname.ToLower.Contains("-trailer") Then
                        filenamewithfullpath = currentmovie.getmoviepath + "\" + tfname
                        Exit For
                    End If
                Case Else
                    'do nothing it's not a movie
            End Select
        Next
        Return filenamewithfullpath
    End Function
    Public Sub getmusicdata(ByRef currentmusic As movieinfoplus.Music) ', ByVal moviemode As String)
        'getdata function
        Dim results As String = ""
        Dim MI As MediaInfo
        Dim To_Display As String = ""
        MI = New MediaInfo

        'open the file
        MI.Open(currentmusic.Filename)

        'find the longest stream in the file

        'get music data
        currentmusic.Duration = MI.Get_(StreamKind.General, 0, "Duration/String")
        currentmusic.Encoder = MI.Get_(StreamKind.Audio, 0, "Format")
        currentmusic.Filesize = MI.Get_(StreamKind.General, 0, "FileSize/String")
        currentmusic.genre = MI.Get_(StreamKind.General, 0, "Genre")
        currentmusic.Title = MI.Get_(StreamKind.General, 0, "Track")
        currentmusic.Tracknum = MI.Get_(StreamKind.General, 0, "Track/Position")
        currentmusic.Year = MI.Get_(StreamKind.General, 0, "Recorded_Date")
        currentmusic.Album = MI.Get_(StreamKind.General, 0, "Album")
        currentmusic.Artist = MI.Get_(StreamKind.General, 0, "Performer")
        currentmusic.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        currentmusic.Comment = MI.Get_(StreamKind.General, 0, "Comment")

        ''get video data
        'currentmovie.fileinfo.Video.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        'currentmovie.fileinfo.Video.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        ''switch avs to h264
        'Dim codecfound As String = ""
        'codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        'If codecfound.ToLower = "avc" Then codecfound = "h264"
        'currentmovie.fileinfo.Video.Codec = codecfound

        'currentmovie.fileinfo.Video.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        ''To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        'currentmovie.fileinfo.Video.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        'currentmovie.fileinfo.Video.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        'currentmovie.fileinfo.Video.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        'currentmovie.fileinfo.Video.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        'currentmovie.fileinfo.Video.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        'currentmovie.fileinfo.Video.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        'currentmovie.fileinfo.Video.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        'currentmovie.fileinfo.Video.Container = "This is the extension of the file"
        ''get audio data
        'currentmovie.fileinfo.Audio.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        'currentmovie.fileinfo.Audio.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        'currentmovie.fileinfo.Audio.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        MI.Close()
    End Sub
    Public Sub getdata(ByRef currentmovie As movieinfoplus.movie, ByVal moviemode As String)
        'getdata function
        Dim results As String = ""
        Dim MI As MediaInfo
        Dim To_Display As String = ""
        MI = New MediaInfo

        'get the moviefilename
        Dim moviefilename As String = ""
        moviefilename = getfilenamefrommovie(currentmovie, moviemode)
        If moviefilename = "nofile" Then Exit Sub

        'open the file
        MI.Open(moviefilename)

        'find the longest stream in the file

        'get video data
        currentmovie.fileinfo.Video.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        currentmovie.fileinfo.Video.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        'switch avs to h264
        Dim codecfound As String = ""
        codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        If codecfound.ToLower = "avc" Then codecfound = "h264"
        currentmovie.fileinfo.Video.Codec = codecfound

        currentmovie.fileinfo.Video.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        currentmovie.fileinfo.Video.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        currentmovie.fileinfo.Video.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        currentmovie.fileinfo.Video.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        currentmovie.fileinfo.Video.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        currentmovie.fileinfo.Video.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        currentmovie.fileinfo.Video.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        currentmovie.fileinfo.Video.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        currentmovie.fileinfo.Video.Container = Strings.Right(moviefilename, 4) '"This is the extension of the file"
        'get audio data
        currentmovie.fileinfo.Audio.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        currentmovie.fileinfo.Audio.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        currentmovie.fileinfo.Audio.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        currentmovie.fileinfo.Audio.Language = MI.Get_(StreamKind.Audio, 0, "Language/String")
        'get subtitle data
        currentmovie.fileinfo.Subtitle.Language = MI.Get_(StreamKind.Text, 0, "Language/String")
        MI.Close()
    End Sub
    Public Sub getdata(ByRef currentshow As tvdblang.tvdblangEpisode, ByVal nfofill As Boolean)
        'getdata function
        Dim results As String = ""
        Dim MI As MediaInfo
        Dim To_Display As String = ""
        MI = New MediaInfo

        'get the curtvepfilename
        Dim curtvepfilename As String = ""
        curtvepfilename = currentshow.fullfilenameandpath 'getfilenamefrommovie(currentmovie, moviemode)
        If curtvepfilename = "" Then Exit Sub

        'open the file
        MI.Open(curtvepfilename)

        'find the longest stream in the file

        'get video data
        currentshow.fileinfo.Video.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        currentshow.fileinfo.Video.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        'switch avs to h264
        Dim codecfound As String = ""
        codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        If codecfound.ToLower = "avc" Then codecfound = "h264"
        currentshow.fileinfo.Video.Codec = codecfound

        currentshow.fileinfo.Video.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        currentshow.fileinfo.Video.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        currentshow.fileinfo.Video.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        currentshow.fileinfo.Video.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        currentshow.fileinfo.Video.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        currentshow.fileinfo.Video.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        currentshow.fileinfo.Video.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        currentshow.fileinfo.Video.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        currentshow.fileinfo.Video.Container = Strings.Right(curtvepfilename, 4) '"This is the extension of the file"
        'get audio data
        currentshow.fileinfo.Audio.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        currentshow.fileinfo.Audio.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        currentshow.fileinfo.Audio.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        currentshow.fileinfo.Audio.Language = MI.Get_(StreamKind.Audio, 0, "Language/String")
        'get subtitle data
        currentshow.fileinfo.Subtitle.Language = MI.Get_(StreamKind.Text, 0, "Language/String")
        MI.Close()
        'MI.Close()
    End Sub

    Private Sub donate()
        'hhttps://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3377230
    End Sub
    Public Sub getdata_XBMC_EP(ByRef currentshow As xbmc.xbmcEpisodedetails)
        'getdata function
        Dim results As String = ""
        Dim MI As MediaInfo
        Dim To_Display As String = ""
        MI = New MediaInfo

        'get the curtvepfilename
        Dim curtvepfilename As String = ""
        curtvepfilename = currentshow.filename 'getfilenamefrommovie(currentmovie, moviemode)
        If curtvepfilename = "" Then Exit Sub

        'open the file
        MI.Open(curtvepfilename)

        'find the longest stream in the file

        'get video data
        currentshow.fileinfo.Video.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        currentshow.fileinfo.Video.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        'switch avs to h264
        Dim codecfound As String = ""
        codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        If codecfound.ToLower = "avc" Then codecfound = "h264"
        currentshow.fileinfo.Video.Codec = codecfound

        currentshow.fileinfo.Video.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        currentshow.fileinfo.Video.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        currentshow.fileinfo.Video.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        currentshow.fileinfo.Video.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        currentshow.fileinfo.Video.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        currentshow.fileinfo.Video.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        currentshow.fileinfo.Video.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        currentshow.fileinfo.Video.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        currentshow.fileinfo.Video.Container = Strings.Right(curtvepfilename, 4) '"This is the extension of the file"
        'get audio data
        currentshow.fileinfo.Audio.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        currentshow.fileinfo.Audio.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        currentshow.fileinfo.Audio.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        currentshow.fileinfo.Audio.Language = MI.Get_(StreamKind.Audio, 0, "Language/String")
        'get subtitle data
        currentshow.fileinfo.Subtitle.Language = MI.Get_(StreamKind.Text, 0, "Language/String")
        MI.Close()
        MI.Close()
    End Sub
End Class

