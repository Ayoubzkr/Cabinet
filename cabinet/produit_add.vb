Public Class produit_add
    Private Sub produit_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES Produit"""
        Me.BackColor = Color.White
        Me.Width = 800
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
    End Sub
    Private Sub ids_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles idt.GotFocus, nom.GotFocus, description.GotFocus, qte.GotFocus, seuildalerte.GotFocus, fournisseur.GotFocus, prixdachat.GotFocus, prixdevente.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.Cyan
        textBox.Font = New Font(textBox.Font.FontFamily, 12, FontStyle.Bold)
    End Sub
    Private Sub ids_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles idt.LostFocus, nom.LostFocus, description.LostFocus, qte.LostFocus, seuildalerte.LostFocus, fournisseur.LostFocus, prixdachat.LostFocus, prixdevente.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.White
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Regular)
        If (textBox.Name = "nom") Then
            If Not String.IsNullOrEmpty(titreeeeeeeeeee.Text) Then
                titreeeeeeeeeee.Text = UCase(titreeeeeeeeeee.Text)
                titreeeeeeeeeee.Font = New Font(titreeeeeeeeeee.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            requete = "insert into produit values (" + idt.Text + ",'" + nom.Text + "','" + description.Text + "','" + qte.Text + "','" + seuildalerte.Text + "','" + fournisseur.Text + "','" + prixdachat.Text + "','" + prixdevente.Text + "')"
        Else
            requete = "update produit set idt = " & idt.Text & ", " & _
                        "nom = '" & nom.Text & "', " & _
                        "description = '" & description.Text & "', " & _
                        "qte = '" & qte.Text & "', " & _
                        "seuildalerte = '" & seuildalerte.Text & "', " & _
                        "fournisseur = '" & fournisseur.Text & "', " & _
                        "prixdachat = '" & prixdachat.Text & "', " & _
                        "prixdevente = '" & prixdevente.Text & "' " & _
                "where idt = " & Convert.ToInt32(ancien_idt.Text)
        End If
        cmdsql()
        Try
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from produit order by idt"
            produit.afficher_produit(requete)
            Me.Close()
        Catch ex As Exception
            MsgBox("Le id produit existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class