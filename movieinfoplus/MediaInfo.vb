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
            Try
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
            Catch ex2 As Exception
                Debug.Print(ex2.ToString)
            End Try

            If filenamewithfullpath = "" Then
                Dim three_ext As String = ""
                Try
                    three_ext = Strings.Right(fileinlisting.ToString, 3).ToLower
                    Select Case three_ext
                        Case ".ts"
                            If Not tfname.ToLower.Contains("-trailer") Then
                                filenamewithfullpath = currentmovie.getmoviepath + "\" + tfname
                            End If
                    End Select
                Catch ex3 As Exception
                    Debug.Print(ex3.ToString)
                End Try
            End If
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
        If moviefilename = "nofile" Or moviefilename = "" Then
            'see if there's a VIDEO_TS folder, if so check the .ifo file
            If Directory.Exists(addfiletofolder(currentmovie.getmoviepath, "VIDEO_TS")) Then
                If File.Exists(addfiletofolder(currentmovie.getmoviepath, "VIDEO_TS\VTS_01_0.IFO")) Then
                    moviefilename = addfiletofolder(currentmovie.getmoviepath, "VIDEO_TS\VTS_01_0.IFO")
                Else
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
        'Exit Sub

        'open the file
        MI.Open(moviefilename)
        currentmovie.fileinfo = New xbmcMediaInfo.Fileinfo
        currentmovie.fileinfo.version = 1.3
        currentmovie.fileinfo.lastupdate = Now()
        Debug.Print(currentmovie.fileinfo.lastupdate.ToString)
        'find the longest stream in the file
        'find the number of video streams in the video file
        Dim numOfVideoStreams As Integer = MI.Count_Get(StreamKind.Visual)
        Dim curVS As Integer = 0
        Dim addVS As Boolean = False
        While curVS < numOfVideoStreams
            'for each video stream
            Dim vidstream As New xbmcMediaInfo.Video
            'get video data
            vidstream.Width = MI.Get_(StreamKind.Visual, curVS, "Width")
            vidstream.Height = MI.Get_(StreamKind.Visual, curVS, "Height")
            'switch avs to h264
            Dim codecfound As String = ""
            codecfound = MI.Get_(StreamKind.Visual, curVS, "Format")
            If codecfound.ToLower = "avc" Then codecfound = "h264"
            vidstream.Codec = codecfound

            vidstream.Formatinfo = MI.Get_(StreamKind.Visual, curVS, "Format")
            'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
            vidstream.Duration = MI.Get_(StreamKind.Visual, curVS, "Duration/String1")
            vidstream.Bitrate = MI.Get_(StreamKind.Visual, curVS, "BitRate/String")
            vidstream.Bitratemode = MI.Get_(StreamKind.Visual, curVS, "BitRate_Mode/String")
            vidstream.Bitratemax = MI.Get_(StreamKind.Visual, curVS, "BitRate_Maximum/String")
            vidstream.Codecid = MI.Get_(StreamKind.Visual, curVS, "CodecID")
            vidstream.Codecidinfo = MI.Get_(StreamKind.Visual, curVS, "CodecID/Info")
            vidstream.Scantype = MI.Get_(StreamKind.Visual, curVS, "ScanType")
            vidstream.Container = Strings.Right(moviefilename, 4) '"This is the extension of the file"
            vidstream.Aspectdisplayratio = MI.Get_(StreamKind.Visual, curVS, "DisplayAspectRatio")
            curVS = False
            With vidstream
                If Not .Bitrate Is Nothing Then
                    If .Bitrate.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Bitratemax Is Nothing Then
                    If .Bitratemax.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Bitratemode Is Nothing Then
                    If .Bitratemode.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codec Is Nothing Then
                    If .Codec.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codecid Is Nothing Then
                    If .Codecid.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codecidinfo Is Nothing Then
                    If .Codecidinfo.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Container Is Nothing Then
                    If .Container.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Duration Is Nothing Then
                    If .Duration.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Formatinfo Is Nothing Then
                    If .Formatinfo.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Height Is Nothing Then
                    If .Height.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Scantype Is Nothing Then
                    If .Scantype.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Width Is Nothing Then
                    If .Width.Length > 0 Then
                        addVS = True
                    End If
                End If
            End With
            If addVS Then currentmovie.fileinfo.streamdetails.Video.Add(vidstream)
            curVS += 1
        End While

        Dim numOfAudioStreams As Integer = MI.Count_Get(StreamKind.Audio)
        Dim curAS As Integer = 0
        Dim addAS As Boolean = False
        While curAS < numOfAudioStreams
            'get audio data
            Dim audstream As New xbmcMediaInfo.Audio
            audstream.Codec = MI.Get_(StreamKind.Audio, curAS, "Format")
            audstream.Channels = MI.Get_(StreamKind.Audio, curAS, "Channel(s)")
            audstream.Bitrate = MI.Get_(StreamKind.Audio, curAS, "BitRate/String")
            audstream.Language = getlangcode(MI.Get_(StreamKind.Audio, curAS, "Language/String"))
            addAS = False
            If Not audstream.Codec Is Nothing Then
                If audstream.Codec.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Channels Is Nothing Then
                If audstream.Channels.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Bitrate Is Nothing Then
                If audstream.Bitrate.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Language Is Nothing Then
                If audstream.Language.Length > 0 Then
                    addAS = True
                End If
            End If

            If addAS Then currentmovie.fileinfo.streamdetails.Audio.Add(audstream)
            curAS += 1
        End While

        Dim numOfSubtitleStreams As Integer = MI.Count_Get(StreamKind.Text)
        Dim curSS As Integer = 0
        While curSS < numOfSubtitleStreams
            'get subtitle data
            Dim subtitleStream As New xbmcMediaInfo.Subtitle
            subtitleStream.Language = getlangcode(MI.Get_(StreamKind.Text, curSS, "Language/String"))
            If Not subtitleStream.Language Is Nothing Then
                If subtitleStream.Language.Length > 0 Then currentmovie.fileinfo.streamdetails.Subtitle.Add(subtitleStream)
            End If
            curSS += 1
        End While

        MI.Close()
        ''open the file
        'MI.Open(moviefilename)
        'currentmovie.fileinfo.streamdetails = New xbmcMediaInfo.streamdetailsC
        ''find the number of video streams in the video file
        'Dim numOfVideoStreams As Integer = 1
        'Dim curVS As Integer = 0
        'While curVS < numOfVideoStreams
        '    'for each video stream
        '    Dim vidstream As New xbmcMediaInfo.Video
        '    'get video data
        '    vidstream.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        '    vidstream.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        '    'switch avs to h264
        '    Dim codecfound As String = ""
        '    codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        '    If codecfound.ToLower = "avc" Then codecfound = "h264"
        '    vidstream.Codec = codecfound

        '    vidstream.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        '    'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        '    vidstream.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        '    vidstream.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        '    vidstream.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        '    vidstream.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        '    vidstream.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        '    vidstream.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        '    vidstream.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        '    vidstream.Container = Strings.Right(moviefilename, 4) '"This is the extension of the file"

        '    currentmovie.fileinfo.streamdetails.Video.Add(vidstream)
        '    curVS += 1
        'End While

        'Dim numOfAudioStreams As Integer = 1
        'Dim curAS As Integer = 0
        'While curAS < numOfAudioStreams
        '    'get audio data
        '    Dim audstream As New xbmcMediaInfo.Audio
        '    audstream.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        '    audstream.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        '    audstream.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        '    audstream.Language = MI.Get_(StreamKind.Audio, 0, "Language/String")

        '    currentmovie.fileinfo.streamdetails.Audio.Add(audstream)
        '    curAS += 1
        'End While

        'Dim numOfSubtitleStreams As Integer = 1
        'Dim curSS As Integer = 0
        'While curSS < numOfSubtitleStreams
        '    'get subtitle data
        '    Dim subtitleStream As New xbmcMediaInfo.Subtitle
        '    subtitleStream.Language = MI.Get_(StreamKind.Text, 0, "Language/String")
        '    currentmovie.fileinfo.streamdetails.Subtitle.Add(subtitleStream)
        '    curSS += 1
        'End While

        'MI.Close()
    End Sub

    Private Function getlangcode(ByVal strLang As String) As String
        Select Case strLang.ToLower
            Case "english"
                Return "eng"
            Case "german"
                Return "deu"
            Case ""
                Return ""
            Case "afar"
                Return "aar"
            Case "abkhazian"
                Return "abk"
            Case "achinese"
                Return "ace"
            Case "acoli"
                Return "ach"
            Case "adangme"
                Return "ada"
            Case "adyghe", "adygei"
                Return "ady"
            Case "afro-asiatic (other)"
                Return "afa"
            Case "afrihili"
                Return "afh"
            Case "afrikaans"
                Return "afr"
            Case "ainu"
                Return "ain"
            Case "akan"
                Return "aka"
            Case "akkadian"
                Return "akk"
            Case "albanian"
                Return "alb"
            Case "aleut"
                Return "ale"
            Case "algonquian languages"
                Return "alg"
            Case "southern altai"
                Return "alt"
            Case "amharic"
                Return "amh"
            Case "english"
                Return "ang"
            Case "angika"
                Return "anp"
            Case "apache languages"
                Return "apa"
            Case "arabic"
                Return "ara"
            Case "official aramaic (700-300 bce)", "imperial aramaic (700-300 bce)"
                Return "arc"
            Case "aragonese"
                Return "arg"
            Case "armenian"
                Return "arm"
            Case "mapudungun", "mapuche"
                Return "arn"
            Case "arapaho"
                Return "arp"
            Case "artificial (other)"
                Return "art"
            Case "arawak"
                Return "arw"
            Case "assamese"
                Return "asm"
            Case "asturian", "bable", "leonese", "asturleonese"
                Return "ast"
            Case "athapascan languages"
                Return "ath"
            Case "australian languages"
                Return "aus"
            Case "avaric"
                Return "ava"
            Case "avestan"
                Return "ave"
            Case "awadhi"
                Return "awa"
            Case "aymara"
                Return "aym"
            Case "azerbaijani"
                Return "aze"
            Case "banda languages"
                Return "bad"
            Case "bamileke languages"
                Return "bai"
            Case "bashkir"
                Return "bak"
            Case "baluchi"
                Return "bal"
            Case "bambara"
                Return "bam"
            Case "balinese"
                Return "ban"
            Case "basque"
                Return "baq"
            Case "basa"
                Return "bas"
            Case "baltic (other)"
                Return "bat"
            Case "beja", "bedawiyet"
                Return "bej"
            Case "belarusian"
                Return "bel"
            Case "bemba"
                Return "bem"
            Case "bengali"
                Return "ben"
            Case "berber (other)"
                Return "ber"
            Case "bhojpuri"
                Return "bho"
            Case "bihari"
                Return "bih"
            Case "bikol"
                Return "bik"
            Case "bini", "edo"
                Return "bin"
            Case "bislama"
                Return "bis"
            Case "siksika"
                Return "bla"
            Case "bantu (other)"
                Return "bnt"
            Case "bosnian"
                Return "bos"
            Case "braj"
                Return "bra"
            Case "breton"
                Return "bre"
            Case "batak languages"
                Return "btk"
            Case "buriat"
                Return "bua"
            Case "buginese"
                Return "bug"
            Case "bulgarian"
                Return "bul"
            Case "burmese"
                Return "bur"
            Case "blin", "bilin"
                Return "byn"
            Case "caddo"
                Return "cad"
            Case "central american indian (other)"
                Return "cai"
            Case "galibi carib"
                Return "car"
            Case "catalan", "valencian"
                Return "cat"
            Case "caucasian (other)"
                Return "cau"
            Case "cebuano"
                Return "ceb"
            Case "celtic (other)"
                Return "cel"
            Case "chamorro"
                Return "cha"
            Case "chibcha"
                Return "chb"
            Case "chechen"
                Return "che"
            Case "chagatai"
                Return "chg"
            Case "chinese"
                Return "chi"
            Case "chuukese"
                Return "chk"
            Case "mari"
                Return "chm"
            Case "chinook jargon"
                Return "chn"
            Case "choctaw"
                Return "cho"
            Case "chipewyan", "dene suline"
                Return "chp"
            Case "cherokee"
                Return "chr"
            Case "church slavic", "old slavonic", "church slavonic", "old bulgarian", "old church slavonic"
                Return "chu"
            Case "chuvash"
                Return "chv"
            Case "cheyenne"
                Return "chy"
            Case "chamic languages"
                Return "cmc"
            Case "coptic"
                Return "cop"
            Case "cornish"
                Return "cor"
            Case "corsican"
                Return "cos"
            Case "creoles and pidgins"
                Return "cpe"
            Case "creoles and pidgins"
                Return "cpf"
            Case "creoles and pidgins"
                Return "cpp"
            Case "cree"
                Return "cre"
            Case "crimean tatar", "crimean turkish"
                Return "crh"
            Case "creoles and pidgins (other)"
                Return "crp"
            Case "kashubian"
                Return "csb"
            Case "cushitic (other)"
                Return "cus"
            Case "czech"
                Return "cze"
            Case "dakota"
                Return "dak"
            Case "danish"
                Return "dan"
            Case "dargwa"
                Return "dar"
            Case "land dayak languages"
                Return "day"
            Case "delaware"
                Return "del"
            Case "slave (athapascan)"
                Return "den"
            Case "dogrib"
                Return "dgr"
            Case "dinka"
                Return "din"
            Case "divehi", "dhivehi", "maldivian"
                Return "div"
            Case "dogri"
                Return "doi"
            Case "dravidian (other)"
                Return "dra"
            Case "lower sorbian"
                Return "dsb"
            Case "duala"
                Return "dua"
            Case "dutch"
                Return "dum"
            Case "dutch", "flemish"
                Return "dut"
            Case "dyula"
                Return "dyu"
            Case "dzongkha"
                Return "dzo"
            Case "efik"
                Return "efi"
            Case "egyptian (ancient)"
                Return "egy"
            Case "ekajuk"
                Return "eka"
            Case "elamite"
                Return "elx"
            Case "english"
                Return "eng"
            Case "english"
                Return "enm"
            Case "esperanto"
                Return "epo"
            Case "estonian"
                Return "est"
            Case "ewe"
                Return "ewe"
            Case "ewondo"
                Return "ewo"
            Case "fang"
                Return "fan"
            Case "faroese"
                Return "fao"
            Case "fanti"
                Return "fat"
            Case "fijian"
                Return "fij"
            Case "filipino", "pilipino"
                Return "fil"
            Case "finnish"
                Return "fin"
            Case "finno-ugrian (other)"
                Return "fiu"
            Case "fon"
                Return "fon"
            Case "french"
                Return "fre"
            Case "french"
                Return "frm"
            Case "french"
                Return "fro"
            Case "northern frisian"
                Return "frr"
            Case "eastern frisian"
                Return "frs"
            Case "western frisian"
                Return "fry"
            Case "fulah"
                Return "ful"
            Case "friulian"
                Return "fur"
            Case "ga"
                Return "gaa"
            Case "gayo"
                Return "gay"
            Case "gbaya"
                Return "gba"
            Case "germanic (other)"
                Return "gem"
            Case "georgian"
                Return "geo"
            Case "german"
                Return "ger"
            Case "geez"
                Return "gez"
            Case "gilbertese"
                Return "gil"
            Case "gaelic", "scottish gaelic"
                Return "gla"
            Case "irish"
                Return "gle"
            Case "galician"
                Return "glg"
            Case "manx"
                Return "glv"
            Case "german"
                Return "gmh"
            Case "german"
                Return "goh"
            Case "gondi"
                Return "gon"
            Case "gorontalo"
                Return "gor"
            Case "gothic"
                Return "got"
            Case "grebo"
                Return "grb"
            Case "greek"
                Return "grc"
            Case "greek"
                Return "gre"
            Case "guarani"
                Return "grn"
            Case "swiss german", "alemannic", "alsatian"
                Return "gsw"
            Case "gujarati"
                Return "guj"
            Case "gwich'in"
                Return "gwi"
            Case "haida"
                Return "hai"
            Case "haitian", "haitian creole"
                Return "hat"
            Case "hausa"
                Return "hau"
            Case "hawaiian"
                Return "haw"
            Case "hebrew"
                Return "heb"
            Case "herero"
                Return "her"
            Case "hiligaynon"
                Return "hil"
            Case "himachali"
                Return "him"
            Case "hindi"
                Return "hin"
            Case "hittite"
                Return "hit"
            Case "hmong"
                Return "hmn"
            Case "hiri motu"
                Return "hmo"
            Case "croatian"
                Return "hrv"
            Case "upper sorbian"
                Return "hsb"
            Case "hungarian"
                Return "hun"
            Case "hupa"
                Return "hup"
            Case "iban"
                Return "iba"
            Case "igbo"
                Return "ibo"
            Case "icelandic"
                Return "ice"
            Case "ido"
                Return "ido"
            Case "sichuan yi", "nuosu"
                Return "iii"
            Case "ijo languages"
                Return "ijo"
            Case "inuktitut"
                Return "iku"
            Case "interlingue", "occidental"
                Return "ile"
            Case "iloko"
                Return "ilo"
            Case "interlingua (international auxiliary language association)"
                Return "ina"
            Case "indic (other)"
                Return "inc"
            Case "indonesian"
                Return "ind"
            Case "indo-european (other)"
                Return "ine"
            Case "ingush"
                Return "inh"
            Case "inupiaq"
                Return "ipk"
            Case "iranian (other)"
                Return "ira"
            Case "iroquoian languages"
                Return "iro"
            Case "italian"
                Return "ita"
            Case "javanese"
                Return "jav"
            Case "lojban"
                Return "jbo"
            Case "japanese"
                Return "jpn"
            Case "judeo-persian"
                Return "jpr"
            Case "judeo-arabic"
                Return "jrb"
            Case "kara-kalpak"
                Return "kaa"
            Case "kabyle"
                Return "kab"
            Case "kachin", "jingpho"
                Return "kac"
            Case "kalaallisut", "greenlandic"
                Return "kal"
            Case "kamba"
                Return "kam"
            Case "kannada"
                Return "kan"
            Case "karen languages"
                Return "kar"
            Case "kashmiri"
                Return "kas"
            Case "kanuri"
                Return "kau"
            Case "kawi"
                Return "kaw"
            Case "kazakh"
                Return "kaz"
            Case "kabardian"
                Return "kbd"
            Case "khasi"
                Return "kha"
            Case "khoisan (other)"
                Return "khi"
            Case "central khmer"
                Return "khm"
            Case "khotanese", "sakan"
                Return "kho"
            Case "kikuyu", "gikuyu"
                Return "kik"
            Case "kinyarwanda"
                Return "kin"
            Case "kirghiz", "kyrgyz"
                Return "kir"
            Case "kimbundu"
                Return "kmb"
            Case "konkani"
                Return "kok"
            Case "komi"
                Return "kom"
            Case "kongo"
                Return "kon"
            Case "korean"
                Return "kor"
            Case "kosraean"
                Return "kos"
            Case "kpelle"
                Return "kpe"
            Case "karachay-balkar"
                Return "krc"
            Case "karelian"
                Return "krl"
            Case "kru languages"
                Return "kro"
            Case "kurukh"
                Return "kru"
            Case "kuanyama", "kwanyama"
                Return "kua"
            Case "kumyk"
                Return "kum"
            Case "kurdish"
                Return "kur"
            Case "kutenai"
                Return "kut"
            Case "ladino"
                Return "lad"
            Case "lahnda"
                Return "lah"
            Case "lamba"
                Return "lam"
            Case "lao"
                Return "lao"
            Case "latin"
                Return "lat"
            Case "latvian"
                Return "lav"
            Case "lezghian"
                Return "lez"
            Case "limburgan", "limburger", "limburgish"
                Return "lim"
            Case "lingala"
                Return "lin"
            Case "lithuanian"
                Return "lit"
            Case "mongo"
                Return "lol"
            Case "lozi"
                Return "loz"
            Case "luxembourgish", "letzeburgesch"
                Return "ltz"
            Case "luba-lulua"
                Return "lua"
            Case "luba-katanga"
                Return "lub"
            Case "ganda"
                Return "lug"
            Case "luiseno"
                Return "lui"
            Case "lunda"
                Return "lun"
            Case "luo (kenya and tanzania)"
                Return "luo"
            Case "lushai"
                Return "lus"
            Case "macedonian"
                Return "mac"
            Case "madurese"
                Return "mad"
            Case "magahi"
                Return "mag"
            Case "marshallese"
                Return "mah"
            Case "maithili"
                Return "mai"
            Case "makasar"
                Return "mak"
            Case "malayalam"
                Return "mal"
            Case "mandingo"
                Return "man"
            Case "maori"
                Return "mao"
            Case "austronesian (other)"
                Return "map"
            Case "marathi"
                Return "mar"
            Case "masai"
                Return "mas"
            Case "malay"
                Return "may"
            Case "moksha"
                Return "mdf"
            Case "mandar"
                Return "mdr"
            Case "mende"
                Return "men"
            Case "irish"
                Return "mga"
            Case "mi'kmaq", "micmac"
                Return "mic"
            Case "minangkabau"
                Return "min"
            Case "uncoded languages"
                Return "mis"
            Case "mon-khmer (other)"
                Return "mkh"
            Case "malagasy"
                Return "mlg"
            Case "maltese"
                Return "mlt"
            Case "manchu"
                Return ("mnc")
            Case "manipuri"
                Return "mni"
            Case "manobo languages"
                Return "mno"
            Case "mohawk"
                Return "moh"
            Case "mongolian"
                Return "mon"
            Case "mossi"
                Return "mos"
            Case "multiple languages"
                Return "mul"
            Case "munda languages"
                Return "mun"
            Case "creek"
                Return "mus"
            Case "mirandese"
                Return "mwl"
            Case "marwari"
                Return "mwr"
            Case "mayan languages"
                Return "myn"
            Case "erzya"
                Return "myv"
            Case "nahuatl languages"
                Return "nah"
            Case "north american indian"
                Return "nai"
            Case "neapolitan"
                Return "nap"
            Case "nauru"
                Return "nau"
            Case "navajo", "navaho"
                Return "nav"
            Case "ndebele"
                Return "nbl"
            Case "ndebele"
                Return "nde"
            Case "ndonga"
                Return "ndo"
            Case "low german", "low saxon", "german"
                Return "nds"
            Case "nepali"
                Return "nep"
            Case "nepal bhasa", "newari"
                Return "new"
            Case "nias"
                Return "nia"
            Case "niger-kordofanian (other)"
                Return "nic"
            Case "niuean"
                Return "niu"
            Case "norwegian nynorsk", "nynorsk"
                Return "nno"
            Case "bokmål"
                Return "nob"
            Case "nogai"
                Return "nog"
            Case "norse"
                Return "non"
            Case "norwegian"
                Return "nor"
            Case "n'ko"
                Return "nqo"
            Case "pedi", "sepedi", "northern sotho"
                Return "nso"
            Case "nubian languages"
                Return "nub"
            Case "classical newari", "old newari", "classical nepal bhasa"
                Return "nwc"
            Case "chichewa", "chewa", "nyanja"
                Return "nya"
            Case "nyamwezi"
                Return "nym"
            Case "nyankole"
                Return "nyn"
            Case "nyoro"
                Return "nyo"
            Case "nzima"
                Return "nzi"
            Case "occitan (post 1500)", "provençal"
                Return "oci"
            Case "ojibwa"
                Return "oji"
            Case "oriya"
                Return "ori"
            Case "oromo"
                Return "orm"
            Case "osage"
                Return "osa"
            Case "ossetian", "ossetic"
                Return "oss"
            Case "turkish"
                Return "ota"
            Case "otomian languages"
                Return "oto"
            Case "papuan (other)"
                Return "paa"
            Case "pangasinan"
                Return "pag"
            Case "pahlavi"
                Return "pal"
            Case "pampanga", "kapampangan"
                Return "pam"
            Case "panjabi", "punjabi"
                Return "pan"
            Case "papiamento"
                Return "pap"
            Case "palauan"
                Return "pau"
            Case "persian"
                Return "peo"
            Case "persian"
                Return "per"
            Case "philippine (other)"
                Return "phi"
            Case "phoenician"
                Return "phn"
            Case "pali"
                Return "pli"
            Case "polish"
                Return "pol"
            Case "pohnpeian"
                Return "pon"
            Case "portuguese"
                Return "por"
            Case "prakrit languages"
                Return "pra"
            Case "provençal"
                Return "pro"
            Case "pushto", "pashto"
                Return "pus"
            Case "reserved for local use"
                Return "qaa-qtz"
            Case "quechua"
                Return "que"
            Case "rajasthani"
                Return "raj"
            Case "rapanui"
                Return "rap"
            Case "rarotongan", "cook islands maori"
                Return "rar"
            Case "romance (other)"
                Return "roa"
            Case "romansh"
                Return "roh"
            Case "romany"
                Return "rom"
            Case "romanian", "moldavian", "moldovan"
                Return "rum"
            Case "rundi"
                Return "run"
            Case "aromanian", "arumanian", "macedo-romanian"
                Return "rup"
            Case "russian"
                Return "rus"
            Case "sandawe"
                Return "sad"
            Case "sango"
                Return "sag"
            Case "yakut"
                Return "sah"
            Case "south american indian (other)"
                Return "sai"
            Case "salishan languages"
                Return "sal"
            Case "samaritan aramaic"
                Return "sam"
            Case "sanskrit"
                Return "san"
            Case "sasak"
                Return "sas"
            Case "santali"
                Return "sat"
            Case "sicilian"
                Return "scn"
            Case "scots"
                Return "sco"
            Case "selkup"
                Return "sel"
            Case "semitic (other)"
                Return "sem"
            Case "irish"
                Return "sga"
            Case "sign languages"
                Return "sgn"
            Case "shan"
                Return "shn"
            Case "sidamo"
                Return "sid"
            Case "sinhala", "sinhalese"
                Return "sin"
            Case "siouan languages"
                Return "sio"
            Case "sino-tibetan (other)"
                Return "sit"
            Case "slavic (other)"
                Return "sla"
            Case "slovak"
                Return "slo"
            Case "slovenian"
                Return "slv"
            Case "southern sami"
                Return "sma"
            Case "northern sami"
                Return "sme"
            Case "sami languages (other)"
                Return "smi"
            Case "lule sami"
                Return "smj"
            Case "inari sami"
                Return "smn"
            Case "samoan"
                Return "smo"
            Case "skolt sami"
                Return "sms"
            Case "shona"
                Return "sna"
            Case "sindhi"
                Return "snd"
            Case "soninke"
                Return "snk"
            Case "sogdian"
                Return "sog"
            Case "somali"
                Return "som"
            Case "songhai languages"
                Return "son"
            Case "sotho"
                Return "sot"
            Case "spanish", "castilian"
                Return "spa"
            Case "sardinian"
                Return "srd"
            Case "sranan tongo"
                Return "srn"
            Case "serbian"
                Return "srp"
            Case "serer"
                Return "srr"
            Case "nilo-saharan (other)"
                Return "ssa"
            Case "swati"
                Return "ssw"
            Case "sukuma"
                Return "suk"
            Case "sundanese"
                Return "sun"
            Case "susu"
                Return "sus"
            Case "sumerian"
                Return "sux"
            Case "swahili"
                Return "swa"
            Case "swedish"
                Return "swe"
            Case "classical syriac"
                Return "syc"
            Case "syriac"
                Return "syr"
            Case "tahitian"
                Return "tah"
            Case "tai (other)"
                Return "tai"
            Case "tamil"
                Return "tam"
            Case "tatar"
                Return "tat"
            Case "telugu"
                Return "tel"
            Case "timne"
                Return "tem"
            Case "tereno"
                Return "ter"
            Case "tetum"
                Return "tet"
            Case "tajik"
                Return "tgk"
            Case "tagalog"
                Return "tgl"
            Case "thai"
                Return "tha"
            Case "tibetan"
                Return "tib"
            Case "tigre"
                Return "tig"
            Case "tigrinya"
                Return "tir"
            Case "tiv"
                Return "tiv"
            Case "tokelau"
                Return "tkl"
            Case "klingon", "tlhingan-hol"
                Return "tlh"
            Case "tlingit"
                Return "tli"
            Case "tamashek"
                Return "tmh"
            Case "tonga (nyasa)"
                Return "tog"
            Case "tonga (tonga islands)"
                Return "ton"
            Case "tok pisin"
                Return "tpi"
            Case "tsimshian"
                Return "tsi"
            Case "tswana"
                Return "tsn"
            Case "tsonga"
                Return "tso"
            Case "turkmen"
                Return "tuk"
            Case "tumbuka"
                Return "tum"
            Case "tupi languages"
                Return "tup"
            Case "turkish"
                Return "tur"
            Case "altaic (other)"
                Return "tut"
            Case "tuvalu"
                Return "tvl"
            Case "twi"
                Return "twi"
            Case "tuvinian"
                Return "tyv"
            Case "udmurt"
                Return "udm"
            Case "ugaritic"
                Return "uga"
            Case "uighur", "uyghur"
                Return "uig"
            Case "ukrainian"
                Return "ukr"
            Case "umbundu"
                Return "umb"
            Case "undetermined"
                Return "und"
            Case "urdu"
                Return "urd"
            Case "uzbek"
                Return "uzb"
            Case "vai"
                Return "vai"
            Case "venda"
                Return "ven"
            Case "vietnamese"
                Return "vie"
            Case "volapük"
                Return "vol"
            Case "votic"
                Return "vot"
            Case "wakashan languages"
                Return "wak"
            Case "walamo"
                Return "wal"
            Case "waray"
                Return "war"
            Case "washo"
                Return "was"
            Case "welsh"
                Return "wel"
            Case "sorbian languages"
                Return "wen"
            Case "walloon"
                Return "wln"
            Case "wolof"
                Return "wol"
            Case "kalmyk", "oirat"
                Return "xal"
            Case "xhosa"
                Return "xho"
            Case "yao"
                Return "yao"
            Case "yapese"
                Return "yap"
            Case "yiddish"
                Return "yid"
            Case "yoruba"
                Return "yor"
            Case "yupik languages"
                Return "ypk"
            Case "zapotec"
                Return "zap"
            Case "blissymbols", "blissymbolics", "bliss"
                Return "zbl"
            Case "zenaga"
                Return "zen"
            Case "zhuang", "chuang"
                Return "zha"
            Case "zande languages"
                Return "znd"
            Case "zulu"
                Return "zul"
            Case "zuni"
                Return "zun"
            Case "no linguistic content", "not applicable"
                Return "zxx"
            Case "zaza", "dimili", "dimli", "kirdki", "kirmanjki", "zazaki"
                Return "zza"
        End Select

    End Function
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
        currentshow.fileinfo = New xbmcMediaInfo.Fileinfo
        currentshow.fileinfo.version = 1.3
        currentshow.fileinfo.lastupdate = Now()
        'find the longest stream in the file
        'find the number of video streams in the video file
        Dim numOfVideoStreams As Integer = MI.Count_Get(StreamKind.Visual)
        Dim curVS As Integer = 0
        Dim addVS As Boolean = False
        While curVS < numOfVideoStreams
            'for each video stream
            Dim vidstream As New xbmcMediaInfo.Video
            'get video data
            vidstream.Width = MI.Get_(StreamKind.Visual, curVS, "Width")
            vidstream.Height = MI.Get_(StreamKind.Visual, curVS, "Height")
            'switch avs to h264
            Dim codecfound As String = ""
            codecfound = MI.Get_(StreamKind.Visual, curVS, "Format")
            If codecfound.ToLower = "avc" Then codecfound = "h264"
            vidstream.Codec = codecfound

            vidstream.Formatinfo = MI.Get_(StreamKind.Visual, curVS, "Format")
            'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
            vidstream.Duration = MI.Get_(StreamKind.Visual, curVS, "Duration/String1")
            vidstream.Bitrate = MI.Get_(StreamKind.Visual, curVS, "BitRate/String")
            vidstream.Bitratemode = MI.Get_(StreamKind.Visual, curVS, "BitRate_Mode/String")
            vidstream.Bitratemax = MI.Get_(StreamKind.Visual, curVS, "BitRate_Maximum/String")
            vidstream.Codecid = MI.Get_(StreamKind.Visual, curVS, "CodecID")
            vidstream.Codecidinfo = MI.Get_(StreamKind.Visual, curVS, "CodecID/Info")
            vidstream.Scantype = MI.Get_(StreamKind.Visual, curVS, "ScanType")
            vidstream.Container = Strings.Right(curtvepfilename, 4) '"This is the extension of the file"
            vidstream.Aspectdisplayratio = MI.Get_(StreamKind.Visual, curVS, "DisplayAspectRatio")
            If Not vidstream.Container Is Nothing Then
                If vidstream.Container.Length = 4 Then
                    If Not Strings.Left(vidstream.Container, 1) = "." Then
                        vidstream.Container = Strings.Right(vidstream.Container, 3)
                    End If
                End If
            End If
            curVS = False
            With vidstream
                If Not .Bitrate Is Nothing Then
                    If .Bitrate.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Bitratemax Is Nothing Then
                    If .Bitratemax.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Bitratemode Is Nothing Then
                    If .Bitratemode.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codec Is Nothing Then
                    If .Codec.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codecid Is Nothing Then
                    If .Codecid.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codecidinfo Is Nothing Then
                    If .Codecidinfo.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Container Is Nothing Then
                    If .Container.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Duration Is Nothing Then
                    If .Duration.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Formatinfo Is Nothing Then
                    If .Formatinfo.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Height Is Nothing Then
                    If .Height.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Scantype Is Nothing Then
                    If .Scantype.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Width Is Nothing Then
                    If .Width.Length > 0 Then
                        addVS = True
                    End If
                End If
            End With
            If addVS Then currentshow.fileinfo.streamdetails.Video.Add(vidstream)
            curVS += 1
        End While
       

        Dim numOfAudioStreams As Integer = MI.Count_Get(StreamKind.Audio)
        Dim curAS As Integer = 0
        Dim addAS As Boolean = False
        While curAS < numOfAudioStreams
            'get audio data
            Dim audstream As New xbmcMediaInfo.Audio
            audstream.Codec = MI.Get_(StreamKind.Audio, curAS, "Format")
            audstream.Channels = MI.Get_(StreamKind.Audio, curAS, "Channel(s)")
            audstream.Bitrate = MI.Get_(StreamKind.Audio, curAS, "BitRate/String")
            audstream.Language = getlangcode(MI.Get_(StreamKind.Audio, curAS, "Language/String"))
            addAS = False
            If Not audstream.Codec Is Nothing Then
                If audstream.Codec.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Channels Is Nothing Then
                If audstream.Channels.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Bitrate Is Nothing Then
                If audstream.Bitrate.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Language Is Nothing Then
                If audstream.Language.Length > 0 Then
                    addAS = True
                End If
            End If
            If addAS Then currentshow.fileinfo.streamdetails.Audio.Add(audstream)
            curAS += 1
        End While

        Dim numOfSubtitleStreams As Integer = MI.Count_Get(StreamKind.Text)
        Dim curSS As Integer = 0
        While curSS < numOfSubtitleStreams
            'get subtitle data
            Dim subtitleStream As New xbmcMediaInfo.Subtitle
            subtitleStream.Language = getlangcode(MI.Get_(StreamKind.Text, curSS, "Language/String"))
            If Not subtitleStream.Language Is Nothing Then
                If subtitleStream.Language.Length > 0 Then currentshow.fileinfo.streamdetails.Subtitle.Add(subtitleStream)
            End If
            'If subtitleStream.Language.Length > 0 Then currentshow.fileinfo.streamdetails.Subtitle.Add(subtitleStream)
            curSS += 1
        End While

        MI.Close()
        ''get video data
        'currentshow.fileinfo.Video.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        'currentshow.fileinfo.Video.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        ''switch avs to h264
        'Dim codecfound As String = ""
        'codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        'If codecfound.ToLower = "avc" Then codecfound = "h264"
        'currentshow.fileinfo.Video.Codec = codecfound

        'currentshow.fileinfo.Video.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        ''To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        'currentshow.fileinfo.Video.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        'currentshow.fileinfo.Video.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        'currentshow.fileinfo.Video.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        'currentshow.fileinfo.Video.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        'currentshow.fileinfo.Video.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        'currentshow.fileinfo.Video.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        'currentshow.fileinfo.Video.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        'currentshow.fileinfo.Video.Container = Strings.Right(curtvepfilename, 4) '"This is the extension of the file"
        ''get audio data
        'currentshow.fileinfo.Audio.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        'currentshow.fileinfo.Audio.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        'currentshow.fileinfo.Audio.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        'currentshow.fileinfo.Audio.Language = MI.Get_(StreamKind.Audio, 0, "Language/String")
        ''get subtitle data
        'currentshow.fileinfo.Subtitle.Language = MI.Get_(StreamKind.Text, 0, "Language/String")
        'MI.Close()
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
        currentshow.fileinfo = New xbmcMediaInfo.Fileinfo
        currentshow.fileinfo.version = 1.3
        currentshow.fileinfo.lastupdate = Now()
        'find the longest stream in the file
        'find the number of video streams in the video file
        Dim numOfVideoStreams As Integer = MI.Count_Get(StreamKind.Visual)
        Dim curVS As Integer = 0
        Dim addVS As Boolean = False
        While curVS < numOfVideoStreams
            'for each video stream
            Dim vidstream As New xbmcMediaInfo.Video
            'get video data
            vidstream.Width = MI.Get_(StreamKind.Visual, curVS, "Width")
            vidstream.Height = MI.Get_(StreamKind.Visual, curVS, "Height")
            'switch avs to h264
            Dim codecfound As String = ""
            codecfound = MI.Get_(StreamKind.Visual, curVS, "Format")
            If codecfound.ToLower = "avc" Then codecfound = "h264"
            vidstream.Codec = codecfound

            vidstream.Formatinfo = MI.Get_(StreamKind.Visual, curVS, "Format")
            'To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
            vidstream.Duration = MI.Get_(StreamKind.Visual, curVS, "Duration/String1")
            vidstream.Bitrate = MI.Get_(StreamKind.Visual, curVS, "BitRate/String")
            vidstream.Bitratemode = MI.Get_(StreamKind.Visual, curVS, "BitRate_Mode/String")
            vidstream.Bitratemax = MI.Get_(StreamKind.Visual, curVS, "BitRate_Maximum/String")
            vidstream.Codecid = MI.Get_(StreamKind.Visual, curVS, "CodecID")
            vidstream.Codecidinfo = MI.Get_(StreamKind.Visual, curVS, "CodecID/Info")
            vidstream.Scantype = MI.Get_(StreamKind.Visual, curVS, "ScanType")
            vidstream.Container = Strings.Right(curtvepfilename, 4) '"This is the extension of the file"
            vidstream.Aspectdisplayratio = MI.Get_(StreamKind.Visual, curVS, "DisplayAspectRatio")
            curVS = False
            With vidstream
                If Not .Bitrate Is Nothing Then
                    If .Bitrate.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Bitratemax Is Nothing Then
                    If .Bitratemax.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Bitratemode Is Nothing Then
                    If .Bitratemode.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codec Is Nothing Then
                    If .Codec.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codecid Is Nothing Then
                    If .Codecid.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Codecidinfo Is Nothing Then
                    If .Codecidinfo.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Container Is Nothing Then
                    If .Container.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Duration Is Nothing Then
                    If .Duration.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Formatinfo Is Nothing Then
                    If .Formatinfo.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Height Is Nothing Then
                    If .Height.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Scantype Is Nothing Then
                    If .Scantype.Length > 0 Then
                        addVS = True
                    End If
                End If
                If Not .Width Is Nothing Then
                    If .Width.Length > 0 Then
                        addVS = True
                    End If
                End If
            End With
            If addVS Then currentshow.fileinfo.streamdetails.Video.Add(vidstream)
            curVS += 1
        End While

        Dim numOfAudioStreams As Integer = MI.Count_Get(StreamKind.Audio)
        Dim curAS As Integer = 0
        Dim addAS As Boolean = False
        While curAS < numOfAudioStreams
            'get audio data
            Dim audstream As New xbmcMediaInfo.Audio
            audstream.Codec = MI.Get_(StreamKind.Audio, curAS, "Format")
            audstream.Channels = MI.Get_(StreamKind.Audio, curAS, "Channel(s)")
            audstream.Bitrate = MI.Get_(StreamKind.Audio, curAS, "BitRate/String")
            audstream.Language = getlangcode(MI.Get_(StreamKind.Audio, curAS, "Language/String"))
            addAS = False
            If Not audstream.Codec Is Nothing Then
                If audstream.Codec.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Channels Is Nothing Then
                If audstream.Channels.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Bitrate Is Nothing Then
                If audstream.Bitrate.Length > 0 Then
                    addAS = True
                End If
            End If
            If Not audstream.Language Is Nothing Then
                If audstream.Language.Length > 0 Then
                    addAS = True
                End If
            End If
            If addAS Then currentshow.fileinfo.streamdetails.Audio.Add(audstream)
            curAS += 1
        End While

        Dim numOfSubtitleStreams As Integer = MI.Count_Get(StreamKind.Text)
        Dim curSS As Integer = 0
        While curSS < numOfSubtitleStreams
            'get subtitle data
            Dim subtitleStream As New xbmcMediaInfo.Subtitle
            subtitleStream.Language = getlangcode(MI.Get_(StreamKind.Text, curSS, "Language/String"))
            If Not subtitleStream.Language Is Nothing Then
                If subtitleStream.Language.Length > 0 Then currentshow.fileinfo.streamdetails.Subtitle.Add(subtitleStream)
            End If
            curSS += 1
        End While

        MI.Close()
        ''find the longest stream in the file

        ''get video data
        'currentshow.fileinfo.Video.Width = MI.Get_(StreamKind.Visual, 0, "Width")
        'currentshow.fileinfo.Video.Height = MI.Get_(StreamKind.Visual, 0, "Height")
        ''switch avs to h264
        'Dim codecfound As String = ""
        'codecfound = MI.Get_(StreamKind.Visual, 0, "Format")
        'If codecfound.ToLower = "avc" Then codecfound = "h264"
        'currentshow.fileinfo.Video.Codec = codecfound

        'currentshow.fileinfo.Video.Formatinfo = MI.Get_(StreamKind.Visual, 0, "Format")
        ''To_Display += "internal - <durationms> Video Duration in ms: " + MI.Get_(StreamKind.Visual, 0, "Duration") + vbNewLine
        'currentshow.fileinfo.Video.Duration = MI.Get_(StreamKind.Visual, 0, "Duration/String1")
        'currentshow.fileinfo.Video.Bitrate = MI.Get_(StreamKind.Visual, 0, "BitRate/String")
        'currentshow.fileinfo.Video.Bitratemode = MI.Get_(StreamKind.Visual, 0, "BitRate_Mode/String")
        'currentshow.fileinfo.Video.Bitratemax = MI.Get_(StreamKind.Visual, 0, "BitRate_Maximum/String")
        'currentshow.fileinfo.Video.Codecid = MI.Get_(StreamKind.Visual, 0, "CodecID")
        'currentshow.fileinfo.Video.Codecidinfo = MI.Get_(StreamKind.Visual, 0, "CodecID/Info")
        'currentshow.fileinfo.Video.Scantype = MI.Get_(StreamKind.Visual, 0, "ScanType")
        'currentshow.fileinfo.Video.Container = Strings.Right(curtvepfilename, 4) '"This is the extension of the file"
        ''get audio data
        'currentshow.fileinfo.Audio.Codec = MI.Get_(StreamKind.Audio, 0, "Format")
        'currentshow.fileinfo.Audio.Channels = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
        'currentshow.fileinfo.Audio.Bitrate = MI.Get_(StreamKind.Audio, 0, "BitRate/String")
        'currentshow.fileinfo.Audio.Language = MI.Get_(StreamKind.Audio, 0, "Language/String")
        ''get subtitle data
        'currentshow.fileinfo.Subtitle.Language = MI.Get_(StreamKind.Text, 0, "Language/String")
        'MI.Close()
        'MI.Close()
    End Sub
End Class

