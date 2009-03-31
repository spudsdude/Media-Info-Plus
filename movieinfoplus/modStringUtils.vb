﻿Imports System.Text
Imports System.Text.RegularExpressions

Module modStringUtils
    Public Function sanitizestring(ByRef curstr As String) As String
        Dim newstr As String = curstr
        Dim buffer As New StringBuilder
        'buffer = curstr.Length
        For Each c As Char In curstr
            If islegitxmlchar(AscW(c)) Then
                buffer.Append(c)
            End If
        Next
        Return buffer.ToString()
    End Function
    Private Function islegitxmlchar(ByVal character As Integer) As Boolean
        Return (character = &H9 OrElse character = &HA OrElse character = &HD OrElse (character >= &H20 AndAlso character <= &HD7FF) OrElse (character >= &HE000 AndAlso character <= &HFFFD) OrElse (character >= &H10000 AndAlso character <= &H10FFFF))
    End Function
    Public Function cleanname(ByVal name As String) As String
        Dim cleanedname As String = name
        cleanedname = Strings.Replace(cleanedname, "�", "")
        cleanedname = Strings.Replace(cleanedname, "<", "")
        cleanedname = Strings.Replace(cleanedname, ">", "")
        cleanedname = Strings.Replace(cleanedname, ":", "")
        cleanedname = Strings.Replace(cleanedname, "\", "")
        cleanedname = Strings.Replace(cleanedname, "/", "")
        cleanedname = Strings.Replace(cleanedname, "?", "")
        cleanedname = Strings.Replace(cleanedname, "|", "")
        cleanedname = Strings.Replace(cleanedname, "*", "")
        cleanedname = Strings.Replace(cleanedname, """", "")
        Return cleanedname
    End Function

    Public Function cleanimdbdata(ByVal strData As String) As String
        ' Debug.Print(strData)

        Dim strClean As String = ""
        If strData Is Nothing Then Return ""
        If strData = "" Then Return ""
        strClean = Strings.Replace(strData, "&#183;", "-")
        strClean = Strings.Replace(strClean, "&#x22;", """")
        strClean = Strings.Replace(strClean, "&#x26;", "&")
        strClean = Strings.Replace(strClean, "&#x27;", "'")

        'remove char codes
        Try
            Dim rObj1 As New Regex("(&#\d{1,3};)")
            Dim mObj1 As Match = rObj1.Match(strClean)
            While mObj1.Success
                strClean = Strings.Replace(strClean, mObj1.Value, "")
                mObj1 = mObj1.NextMatch()
            End While
        Catch ex As ArgumentException
            Debug.Print(ex.ToString)
            'Syntax error in the regular expression
        End Try
        Try
            Dim rObj1 As New Regex("(&#x\d{1,2};)")
            Dim mObj1 As Match = rObj1.Match(strClean)
            While mObj1.Success
                strClean = Strings.Replace(strClean, mObj1.Value, "")
                mObj1 = mObj1.NextMatch()
            End While
        Catch ex As ArgumentException
            Debug.Print(ex.ToString)
            'Syntax error in the regular expression
        End Try
        Try
            Dim rObj2 As New Regex("</?a.*?>")
            Dim mObj2 As Match = rObj2.Match(strClean)
            While mObj2.Success
                strClean = Strings.Replace(strClean, mObj2.Value, "")
                mObj2 = mObj2.NextMatch()
            End While
        Catch ex As ArgumentException
            'Syntax error in the regular expression
        End Try
        strClean = Strings.Replace(strClean, "</a>", "")
        If Strings.Right(strClean, 2) = "| " Then
            strClean = Strings.Left(strClean, strClean.Length - 2)
        End If
        If Strings.Right(strClean, 1) = "|" Then
            strClean = Strings.Left(strClean, strClean.Length - 1)
        End If
        If Not strClean Is Nothing Then
            If strClean.Contains("</div>") Then strClean = Regex.Match(strClean, "(.*?)</div>").Groups(1).Value
        End If
        Return strClean
    End Function

    Public Function cleanmusicnameforsearch(ByVal texttoclean As String) As String
        Dim restr As String = texttoclean
        restr = Strings.Replace(restr, "'", "")
        restr = Strings.Replace(restr, "&", "")
        restr = Strings.Replace(restr, "@", "")
        restr = Strings.Replace(restr, """", "")
        restr = Strings.Replace(restr, ";", "")
        restr = Strings.Replace(restr, "~", "")
        restr = Strings.Replace(restr, ">", "")
        restr = Strings.Replace(restr, "<", "")
        restr = Strings.Replace(restr, "?", "")
        restr = Strings.Replace(restr, "�", "")
        restr = Strings.Replace(restr, ":", "")
        restr = Strings.Replace(restr, "\", "")
        restr = Strings.Replace(restr, "/", "")
        restr = Strings.Replace(restr, "?", "")
        restr = Strings.Replace(restr, "|", "")
        restr = Strings.Replace(restr, "*", "")
        Return restr
    End Function

    Public Function addfiletofolder(ByVal tvar_path As String, ByVal tvar_filename As String) As String
        If Not Strings.Right(tvar_path, 1) = "\" Then
            tvar_path += "\"
        End If
        Dim rFullPath As String = tvar_path + tvar_filename
        Return rFullPath
    End Function

    Public Function stripstackforfilemode(ByVal moviename As String) As String
        Dim filteredname As String = ""
        If Not maincollection.moviemode = "file" Then
            Return moviename
            Exit Function
        End If

        ''strip out anything in parans
        'Try
        '    moviename = Strings.Replace(moviename, Regex.Match(moviename, "(\(.*?\))").Groups(1).Value, "")
        'Catch ex As Exception
        '    Debug.Print(ex.ToString)
        'End Try

        'strip out cd multipart
        Dim RegexObj As New Regex("(([ _\.-]+cd)[ _\.-]*([0-9a-d]+))")
        moviename = Strings.Replace(moviename, RegexObj.Match(moviename).Groups(1).Value, "")
        'strip out dvd multipart
        Dim RegexObj2 As New Regex("(([ _\.-]+dvd)[ _\.-]*([0-9a-d]+))")
        moviename = Strings.Replace(moviename, RegexObj2.Match(moviename).Groups(1).Value, "")
        'strip out part multipart
        Dim RegexObj3 As New Regex("(([ _\.-]+part)[ _\.-]*([0-9a-d]+))")
        moviename = Strings.Replace(moviename, RegexObj3.Match(moviename).Groups(1).Value, "")
        Return moviename
        'End If

    End Function


    Public Function namefilterforfilemode(ByVal moviename As String) As String
        Dim filteredname As String = ""
        'If moviemode = "file" Then
        'strip out anything in parans
        Try
            moviename = Strings.Replace(moviename, Regex.Match(moviename, "(\(.*?\))").Groups(1).Value, "")
        Catch ex As Exception
            Debug.Print(ex.ToString)
        End Try

        'strip out cd multipart
        Dim RegexObj As New Regex("(([ _\.-]+cd)[ _\.-]*([0-9a-d]+))")
        moviename = Strings.Replace(moviename, RegexObj.Match(moviename).Groups(1).Value, "")
        'strip out dvd multipart
        Dim RegexObj2 As New Regex("(([ _\.-]+dvd)[ _\.-]*([0-9a-d]+))")
        moviename = Strings.Replace(moviename, RegexObj2.Match(moviename).Groups(1).Value, "")
        'strip out part multipart
        Dim RegexObj3 As New Regex("(([ _\.-]+part)[ _\.-]*([0-9a-d]+))")
        moviename = Strings.Replace(moviename, RegexObj3.Match(moviename).Groups(1).Value, "")
        ''strip out dvd 
        'Dim RegexObj3 As New Regex("(([ _\.-]+part)[ _\.-]*([0-9a-d]+))")
        'moviename = Strings.Replace(moviename, RegexObj3.Match(moviename).Groups(1).Value, "")
        'strip out use selected objects (like divx, xvid, ac3, etc) .. not yet configured
        'TODO: Add user selectable options here

        'strip out anything past a token that parses moviename
        'Try
        '    Dim RegexObj4 As New Regex("[_-]+.*")
        '    moviename = RegexObj4.Match(moviename).Groups(1).Value
        'Catch ex As ArgumentException
        '    'Syntax error in the regular expression
        'End Try

        If maincollection.rconf.pcbFilterNameFileModeEverythingBeforeh264 Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)h264", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If

        If maincollection.rconf.pcbFilterNameFileModeEverythingBeforex264 Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)x264", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If

        If maincollection.rconf.pcbFilterNameFileModeEverythingBefore720p Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)720p", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If

        If maincollection.rconf.pcbFilterNameFileModeEverythingBefore1080i Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)1080i", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If

        If maincollection.rconf.pcbFilterNameFileModeEverythingBefore1080p Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)1080p", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If

        If maincollection.rconf.pcbFilterNameFileModeEverythingBeforeYear Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)[\\([]{0,1}\d{4}", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If

        If maincollection.rconf.pcbFilterNameFileModeEverythingBeforeDash Then
            Dim ResultString As String = ""
            Try
                Dim RegexObjDate As New Regex("(.*)-", RegexOptions.IgnoreCase)
                ResultString = RegexObjDate.Match(moviename).Groups(1).Value
            Catch ex As ArgumentException
                'Syntax error in the regular expression
            End Try
            If Not String.IsNullOrEmpty(ResultString) Then
                moviename = ResultString
            End If
        End If
        'change periods to spaces
        moviename = Strings.Replace(moviename, ".", " ")
        'change underscores to spaces
        moviename = Strings.Replace(moviename, "_", " ")

        'make sure there's not a space at the end of the name, check 3 times
        moviename = Strings.Trim(moviename)


        'End If

        filteredname = moviename
        Return filteredname
    End Function

    Public Function namefilter(ByVal moviename As String) As String
        Dim filteredname As String = ""

        If maincollection.rconf.pcbFilterUnderscoreDot Then
            moviename = Strings.Replace(moviename, "_", " ")
            moviename = Strings.Replace(moviename, ".", " ")
        End If

        If maincollection.rconf.pcbFilter1080p Then
            moviename = Strings.Replace(moviename, " (1080p)", "")
            moviename = Strings.Replace(moviename, " (1080P)", "")
        End If
        If maincollection.rconf.pcbFilter720p Then
            moviename = Strings.Replace(moviename, " (720p)", "")
            moviename = Strings.Replace(moviename, " (720P)", "")
        End If
        If maincollection.rconf.pcbFilterAvi Then
            moviename = Strings.Replace(moviename, " (Avi)", "")
            moviename = Strings.Replace(moviename, " (avi)", "")
        End If
        If maincollection.rconf.pcbFilterBluRay Then
            moviename = Strings.Replace(moviename, " (blu-ray)", "")
            moviename = Strings.Replace(moviename, " (Blu-ray)", "")
            moviename = Strings.Replace(moviename, " (Blu-Ray)", "")
        End If
        If maincollection.rconf.pcbFilterCustom1_enabled Then
            moviename = Strings.Replace(moviename, maincollection.rconf.pcbFilterCustom1, "")
        End If
        If maincollection.rconf.pcbFilterCustom2_enabled Then
            moviename = Strings.Replace(moviename, maincollection.rconf.pcbFilterCustom2, "")
        End If
        If maincollection.rconf.pcbFilterCustom3_enabled Then
            moviename = Strings.Replace(moviename, maincollection.rconf.pcbFilterCustom3, "")
        End If
        If maincollection.rconf.pcbFilterCustom4_enabled Then
            moviename = Strings.Replace(moviename, maincollection.rconf.pcbFilterCustom4, "")
        End If
        If maincollection.rconf.pcbFilterCustom5_enabled Then
            moviename = Strings.Replace(moviename, maincollection.rconf.pcbFilterCustom5, "")
        End If
        If maincollection.rconf.pcbFilterDivx Then
            moviename = Strings.Replace(moviename, " (Divx)", "")
            moviename = Strings.Replace(moviename, " (divx)", "")
        End If
        If maincollection.rconf.pcbFilterDVD Then
            moviename = Strings.Replace(moviename, " (DVD)", "")
            moviename = Strings.Replace(moviename, " (dvd)", "")
        End If
        If maincollection.rconf.pcbFilterH264 Then
            moviename = Strings.Replace(moviename, " (H264)", "")
            moviename = Strings.Replace(moviename, " (h264)", "")
        End If
        If maincollection.rconf.pcbFilterHidef Then
            moviename = Strings.Replace(moviename, " (hidef)", "")
        End If
        If maincollection.rconf.pcbFilterLq Then
            moviename = Strings.Replace(moviename, " (lq)", "")
            moviename = Strings.Replace(moviename, " (LQ)", "")
        End If
        If maincollection.rconf.pcbFilterXvid Then
            moviename = Strings.Replace(moviename, " (xvid)", "")
            moviename = Strings.Replace(moviename, " (Xvid)", "")
        End If
        If maincollection.rconf.pcbFilter1080i Then
            moviename = Strings.Replace(moviename, " (1080i)", "")
            moviename = Strings.Replace(moviename, " (1080I)", "")
        End If
        If maincollection.rconf.pcbFilterYears Then
            Try
                moviename = Strings.Replace(moviename, Regex.Match(moviename, "( \(\d{4}\))").Groups(1).Value, "")
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
        If maincollection.rconf.pcbIgnoreparans Then
            Try
                moviename = Strings.Replace(moviename, Regex.Match(moviename, "(\(.*?\))").Groups(1).Value, "")
            Catch ex As Exception
                Debug.Print(ex.ToString)
            End Try
        End If
        moviename = Strings.Trim(moviename)
        'strip out the ( and ) from moviename
        'moviename = Strings.Replace(moviename, "(", "")
        'moviename = Strings.Replace(moviename, ")", "")
        filteredname = moviename
        Return filteredname

    End Function
End Module