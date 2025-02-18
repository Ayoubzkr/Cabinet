Public Class cabinet
    Private Sub valider_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valider.Click
        If patient.Checked Then
            patients.ShowDialog()
        ElseIf specialite.Checked Then
            specialites.ShowDialog()
        ElseIf dentistes.Checked Then
            dentiste.ShowDialog()
        ElseIf Stocks.Checked Then
            produit.ShowDialog()
        ElseIf av.Checked Then
            avoir.ShowDialog()
        ElseIf rend.Checked Then
            rendezvous.ShowDialog()
        ElseIf employee.Checked Then
            employe.ShowDialog()
        ElseIf traitementt.Checked Then
            traitement.ShowDialog()
        Else
            ' Aucun choix n'est sélectionné
            MessageBox.Show("Veuillez sélectionner une option.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cabinet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class