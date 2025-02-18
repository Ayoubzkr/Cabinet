Public Class rendezvous_add
    Private Sub rendezvous_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES rendez-vous"
        Me.BackColor = Color.White
        Me.Width = 800
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
    End Sub
    Private Sub idrdv_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles idrdv.GotFocus, idp.GotFocus, idd.GotFocus, staturdv.GotFocus, notes.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.Cyan
        textBox.Font = New Font(textBox.Font.FontFamily, 12, FontStyle.Bold)
    End Sub
    Private Sub idrdv_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles idrdv.LostFocus, idp.LostFocus, idd.LostFocus, staturdv.LostFocus, notes.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.White
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Regular)
        If (textBox.Name = "idp") Then
            If Not String.IsNullOrEmpty(idp.Text) Then
                idp.Text = UCase(idp.Text)
                idp.Font = New Font(idp.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            requete = "insert into rendezvous values ('" + idrdv.Text + "','" + idp.Text + "','" + idd.Text + "','" + daterdv.Text + "','" + heurerdv.Text + "','" + staturdv.Text + "','" + notes.Text + "')"
        Else
            requete = "UPDATE rendezvous SET " & _
          "idrdv = '" & idrdv.Text & "', " & _
          "idp = '" & idp.Text & "', " & _
          "idd = '" & idd.Text & "', " & _
          "daterdv = '" & daterdv.Text & "', " & _
          "heurerdv = '" & heurerdv.Text & "', " & _
          "staturdv = '" & staturdv.Text & "', " & _
          "notes = '" & notes.Text & "' " & _
          "WHERE idp = '" & ancien_idp.Text & "' AND idd = '" & ancien_idd.Text & "'"
        End If
        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from rendezvous order by idrdv"
            rendezvous.afficher_rendezvous(requete)
            Me.Close()
        Catch ex As Exception
            MsgBox("Le id rendez-vous existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class