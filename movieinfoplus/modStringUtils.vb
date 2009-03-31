Imports System.Text
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
        Dim strClean As String = ""
        If strData Is Nothing Then Return ""
        If strData = "" Then Return ""
        strClean = Strings.Replace(strData, "&#183;", "-")
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
End Module
