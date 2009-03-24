Module Module1

    Sub Main()
        Dim curtv As New movieinfoplus.tvshowcollection
        curtv.precacheTVShowsCmdLine(False)
        curtv.kbLoadTvShowsCmdLine()
        'MsgBox("show processing completed")
        'curtv.updatetvshowsCmdLine()
        MsgBox("done all processing")
    End Sub

End Module
