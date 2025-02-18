Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class Form3
    Private Sub idp_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles idp.GotFocus, nomp.GotFocus, cinp.GotFocus, telp.GotFocus, prenomp.GotFocus, villep.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.Cyan
        textBox.Font = New Font(textBox.Font.FontFamily, 12, FontStyle.Bold)
    End Sub

    Private Sub idp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles idp.LostFocus, nomp.LostFocus, cinp.LostFocus, telp.LostFocus, prenomp.LostFocus, villep.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.White
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Regular)
        If (textBox.Name = "nomp") Then
            If Not String.IsNullOrEmpty(nomp.Text) Then
                nomp.Text = UCase(nomp.Text)
                nomp.Font = New Font(nomp.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
        If (textBox.Name = "prenomp") Then
            If Not String.IsNullOrEmpty(prenomp.Text) Then
                prenomp.Text = prenomp.Text.Substring(0, 1).ToUpper() + prenomp.Text.Substring(1).ToLower()
                prenomp.Font = New Font(prenomp.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
    End Sub
    Private Sub Modifer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modifer.Click
        If (idp.Text = Nothing Or nomp.Text = Nothing Or prenomp.Text = Nothing) Then
            MsgBox("Veuillez saisir les données suivantes : ID, nom et prénom ! ", MsgBoxStyle.Information, "Message")
        Else
            requete = "UPDATE patient SET nom = @nom, prenom = @prenom, type = @type, datenais = @datenais, tel = @tel, cin = @cin, dateins = @dateins, ville = @ville WHERE idp = @idp"

            cmdsql()
            connexion()

            cmd.CommandText = requete
            cmd.Parameters.AddWithValue("@nom", nomp.Text)
            cmd.Parameters.AddWithValue("@prenom", prenomp.Text)
            cmd.Parameters.AddWithValue("@type", typep.Text)
            cmd.Parameters.AddWithValue("@datenais", datenais.Text)
            cmd.Parameters.AddWithValue("@tel", telp.Text)
            cmd.Parameters.AddWithValue("@cin", cinp.Text)
            cmd.Parameters.AddWithValue("@dateins", dateins.Text)
            cmd.Parameters.AddWithValue("@ville", villep.Text)
            cmd.Parameters.AddWithValue("@idp", idp.Text)

            Try
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "SELECT * FROM patient ORDER BY idp"
                patients.afficher_patient(requete)
                Me.Close()
            Catch ex As Exception
                MsgBox("Erreur lors de la mise à jour du patient : " & ex.Message, MsgBoxStyle.Exclamation, "Erreur")
                con.Close()
            End Try

        End If
    End Sub
End Class