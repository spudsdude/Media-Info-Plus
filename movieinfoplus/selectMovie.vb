Public Class selectMovie

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgMoviePicker_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMoviePicker.CellContentClick
        parseimdb.findyearstrict(dgMoviePicker.CurrentCell.Value.ToString)
        Me.Dispose()
    End Sub

    Private Sub dgMoviePicker_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMoviePicker.CellContentDoubleClick
        parseimdb.findyearstrict(dgMoviePicker.CurrentCell.Value.ToString)
        Me.Dispose()

    End Sub
End Class