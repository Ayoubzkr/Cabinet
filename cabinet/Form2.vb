Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES PATIENTS"
        Me.BackColor = Color.White
        Me.Width = 800
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
    End Sub
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

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        connexion()
        requete = "insert into patient values ('" + idp.Text + "','" + nomp.Text + "','" + prenomp.Text + "','" + typep.Text + "','" + datenais.Text + "','" + telp.Text + "','" + villep.Text + "','" + cinp.Text + "','" + dateins.Text + "')"
        cmd.Connection = con
        cmd.CommandText = requete
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Le id patient existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
        End Try
        con.Close()
        Me.Close()
    End Sub
End Class