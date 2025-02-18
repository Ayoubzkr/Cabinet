Public Class employe_add
    Private Sub employe_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES employes"
        Me.BackColor = Color.White
        Me.Width = 800
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
    End Sub
    Private Sub idemploye_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nom.GotFocus, prenom.GotFocus, ncin.GotFocus, adresse.GotFocus, tel.GotFocus, poste.GotFocus, mdp.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.Cyan
        textBox.Font = New Font(textBox.Font.FontFamily, 12, FontStyle.Bold)
    End Sub

    Private Sub idemploye_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nom.LostFocus, prenom.LostFocus, ncin.LostFocus, adresse.LostFocus, tel.LostFocus, poste.LostFocus, mdp.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.White
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Regular)
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Bold)
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            ' Si l'idemploye n'existe pas, insertion
            requete = "insert into employe(nom,prenom,ncin,datedenaissance,adresse,tel,poste,motdepasse) values (@nom, @prenom, @ncin, @datenais, @adresse, @tel, @poste, @mdp)"
        Else
            requete = "UPDATE employe SET nom = @nom, prenom = @prenom, ncin = @ncin, datedenaissance = @datenais, tel = @tel, adresse = @adresse, poste = @poste, motdepasse = @mdp WHERE idemploye = @ancien_ide"
            cmd.Parameters.AddWithValue("@ancien_ide", ancien_ide.Text)
        End If

        cmd.CommandText = requete
        cmd.Parameters.AddWithValue("@nom", nom.Text)
        cmd.Parameters.AddWithValue("@prenom", prenom.Text)
        cmd.Parameters.AddWithValue("@ncin", ncin.Text)
        cmd.Parameters.AddWithValue("@datenais", datenais.Text)
        cmd.Parameters.AddWithValue("@adresse", adresse.Text)
        cmd.Parameters.AddWithValue("@tel", tel.Text)
        cmd.Parameters.AddWithValue("@poste", poste.Text)
        cmd.Parameters.AddWithValue("@mdp", mdp.Text)

        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from employe order by idemploye"
            rendezvous.afficher_rendezvous(requete)
            Me.Close()
        Catch ex As Exception
            MsgBox("Une erreur est survenue lors de l'opération. Détails: " & ex.Message, vbExclamation, "Erreur")
            con.Close()
        End Try

    End Sub
End Class