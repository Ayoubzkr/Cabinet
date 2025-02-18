Public Class specialiter_add
    Private Sub specialiter_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES Spécialité"
        Me.BackColor = Color.White
        Me.Width = 800
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
    End Sub
    Private Sub ids_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ids.GotFocus, defi.GotFocus, titres.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.Cyan
        textBox.Font = New Font(textBox.Font.FontFamily, 12, FontStyle.Bold)
    End Sub
    Private Sub ids_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ids.LostFocus, titres.LostFocus, defi.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.White
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Regular)
        If (textBox.Name = "titre") Then
            If Not String.IsNullOrEmpty(titres.Text) Then
                titres.Text = UCase(titres.Text)
                titres.Font = New Font(titres.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            requete = "insert into specialite values ('" + ids.Text + "','" + titres.Text + "','" + defi.Text + "')"
        Else
            requete = "update specialite set ids = " & ids.Text & ", " & _
                        "titre = '" & titres.Text & "', " & _
                        "definition = '" & defi.Text & "' " & _
                "where ids = " & ancien_ids.Text

        End If
        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from specialite order by ids"
            specialites.afficher_specialite(requete)
            Me.Close()
        Catch ex As Exception
            MsgBox("Le id specialite existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub

End Class