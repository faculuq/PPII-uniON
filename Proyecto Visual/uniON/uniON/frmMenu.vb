Public Class frmMenu

    Private Sub PaisesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem1.Click
        frmPaises.Show()
    End Sub

    Private Sub ProvinciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvinciasToolStripMenuItem.Click
        frmProvincias.Show()
    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        frmCiudades.Show()
    End Sub

    Private Sub EstadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstadosToolStripMenuItem1.Click
        frmEstados.Show()
    End Sub
End Class
