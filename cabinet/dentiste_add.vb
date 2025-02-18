Imports System.Data.OleDb
Imports System.Text
Imports System.IO
Public Class dentiste_add

    Private Sub dentiste_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "Formulaire dentiste "
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.Width = 930
        Me.CenterToScreen()
        Idd.Focus()
    End Sub
    Private Sub idd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Idd.GotFocus, nomd.GotFocus, adresse.GotFocus, notes.GotFocus, teld.GotFocus, prenomd.GotFocus, emaild.GotFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.Cyan
        textBox.Font = New Font(textBox.Font.FontFamily, 12, FontStyle.Bold)
    End Sub
    Private Sub idd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Idd.LostFocus, nomd.LostFocus, adresse.LostFocus, prenomd.LostFocus, teld.LostFocus, emaild.LostFocus
        Dim textBox As TextBox = CType(sender, TextBox)
        textBox.BackColor = Color.White
        textBox.Font = New Font(textBox.Font.FontFamily, 10, FontStyle.Regular)
        If (textBox.Name = "nomd") Then
            If Not String.IsNullOrEmpty(nomd.Text) Then
                nomd.Text = UCase(nomd.Text)
                nomd.Font = New Font(nomd.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
        If (textBox.Name = "prenom") Then
            If Not String.IsNullOrEmpty(prenomd.Text) Then
                prenomd.Text = prenomd.Text.Substring(0, 1).ToUpper() + prenomd.Text.Substring(1).ToLower()
                prenomd.Font = New Font(prenomd.Font.FontFamily, 10, FontStyle.Bold)
            End If
        End If
    End Sub
    Private Sub ouvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ouvrir.Click
        If (Idd.Text = Nothing Or nomd.Text = Nothing Or prenomd.Text = Nothing) Then
            MsgBox("Veuillez saisir les données suivantes : ID, nom et prénom ! ", MsgBoxStyle.Information, "Message")
            Idd.Focus()
        Else
            'Je déclare une ofd pour ouvrir l'explorateur windows
            Dim ofd As New OpenFileDialog
            'Je fais un filtre pour ne chercher que les images 
            ofd.Filter = "Sélectionnez une image (*.jpg; *.png)|*.jpg; *.png"
            'Si l'user choisis une image
            If ofd.ShowDialog = DialogResult.OK Then
                'je met l'image dans le pricturebox
                PictureBox1.Image = Image.FromFile(ofd.FileName)
                'je copie le nom de l'image dans un label
                nom_photo.Text = ofd.FileName
                'je met dans une variable type_photo le type de la photo
                Dim type_photo As String = Mid(nom_photo.Text, Len(nom_photo.Text) - 3, 4)
                Dim nouveau_nom As String
                nouveau_nom = Idd.Text + nomd.Text + prenomd.Text + type_photo
                anc_nom.Text = nom_photo.Text
                nom_photo.Text = "1_" + nouveau_nom
            End If
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If (Idd.Text = Nothing Or nomd.Text = Nothing Or prenomd.Text = Nothing) Then
            MsgBox("Veuillez saisir les données suivantes : ID, nom et prénom ! ", MsgBoxStyle.Information, "Message")
            Idd.Focus()
        Else
            If type_operation.Text = "Ajouter" Then
                If (nom_photo.Text <> "dentiste.png") Then
                    File.Copy(anc_nom.Text, "images/" + nom_photo.Text)
                End If
                requete = "insert into dentiste values (" & Idd.Text & ", '" & nomd.Text & "', '" & prenomd.Text & "','" & emaild.Text & "', '" & teld.Text & "','" & adresse.Text & "','" & date_embauche.Text & "', '" & nom_photo.Text & "','" & notes.Text & "')"
            Else
                requete = "update dentiste set idd = " + Idd.Text + ", " & _
                                "nom = '" + nomd.Text + "', " & _
                                "prenom = '" + prenomd.Text + "', " & _
                                "email = '" + emaild.Text + "', " & _
                                "tel = '" + teld.Text + "', " & _
                                "adresse = '" + adresse.Text + "', " & _
                                "date_embauche = '" + date_embauche.Text + "'," & _
                                "notes = '" + notes.Text + "'"
                If (nom_photo.Text <> "dentiste.png") Then
                    Try
                        File.Copy(anc_nom.Text, "images/" + nom_photo.Text)
                    Catch ex As Exception
                        Dim partie() As String = nom_photo.Text.Split("_")
                        Dim chiffre As Integer = Val(partie(0)) + 1
                        nom_photo.Text = chiffre.ToString + "_" + partie(1)
                        File.Copy(anc_nom.Text, "images/" + nom_photo.Text)
                    End Try
                    requete += ", photo = '" + nom_photo.Text + "'"
                End If
                requete += " where idd = " + ancien_idd.Text + ";"
            End If
            cmdsql()
            Try
                connexion()
                cmd.ExecuteNonQuery() 'On exécute la requête
                con.Close()
                requete = "select * from dentiste order by idd"
                dentiste.afficher_dentiste(requete)
                Me.Close()
            Catch ex As Exception
                MsgBox("Le ID dentiste existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
                con.Close()
            End Try
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class