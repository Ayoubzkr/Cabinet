Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class dentiste
    Private Sub dentiste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES Dentiste"
        Me.BackColor = Color.White
        Me.Width = 900
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
        DataGridView1.Width = Me.Width - 60
        DataGridView1.Height = Me.Height - 120
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 8)
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Cyan
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.RowTemplate.Height = 40
        'Création des colonnes 
        Dim idd, nom, prenom, email, tel, adresse, date_embauche, notes As New DataGridViewTextBoxColumn()
        Dim photo As New DataGridViewImageColumn()
        idd.HeaderText = "Id dentiste"
        idd.Name = "idd"
        DataGridView1.Columns.Add(idd)
        idd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        nom.HeaderText = "Nom"
        nom.Name = "nom"
        DataGridView1.Columns.Add(nom)
        nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        prenom.HeaderText = "Prénom"
        prenom.Name = "prenom"
        prenom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(prenom)
        email.HeaderText = "Email"
        email.Name = "email"
        email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(email)
        tel.HeaderText = "Tél"
        tel.Name = "tel"
        tel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(tel)
        adresse.HeaderText = "Adresse"
        adresse.Name = "adresse"
        adresse.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(adresse)
        date_embauche.HeaderText = "Date_Embauche"
        date_embauche.Name = "date_embauche"
        date_embauche.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(date_embauche)
        photo.HeaderText = "Photo"
        photo.Name = "photo"
        'photo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        photo.ImageLayout = DataGridViewImageCellLayout.Stretch
        DataGridView1.Columns.Add(photo)
        notes.HeaderText = "Notes"
        notes.Name = "notes"
        notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(notes)
        requete = "select * from dentiste order by idd"
        afficher_dentiste(requete)
    End Sub

    Public Sub afficher_dentiste(ByRef requete As String)
        DataGridView1.Rows.Clear()
        connexion()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = requete
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idd, nom, prenom, email, tel, adresse, date_embauche, photo, notes As String
        Dim pic As Image
        While data.Read()
            idd = data(0).ToString
            nom = data(1)
            prenom = data(2)
            email = data(3)
            tel = data(4)
            adresse = data(5)
            date_embauche = data(6)
            photo = data(7)
            notes = data(8)
            pic = Image.FromFile("images/" + photo)
            DataGridView1.Rows.Add(idd, nom, prenom, email, tel, adresse, date_embauche, pic, notes)
        End While
        If (dentiste_add.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            'DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (dentiste_add.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(dentiste_add.ligne_modifie.Text)).Selected = True
        End If
        con.Close()
    End Sub
    Private Sub Ajouter_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        With dentiste_add
            .type_operation.Text = "Ajouter"
            .Idd.Text = Nothing
            .nomd.Text = Nothing
            .prenomd.Text = Nothing
            .teld.Text = Nothing
            .emaild.Text = Nothing
            .adresse.Text = Nothing
            .notes.Text = Nothing
            .anc_nom.Text = Nothing
            .date_embauche.Text = Nothing
        End With
        dentiste_add.ShowDialog()
    End Sub
    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        dentiste_add.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun Employé...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet employé : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "delete from dentiste where idd = " + id
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "select * from dentiste order by idd"
                afficher_dentiste(requete)
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        dentiste_add.Idd.Text = DataGridView1.Rows(i).Cells(0).Value
        dentiste_add.ancien_idd.Text = dentiste_add.Idd.Text

        dentiste_add.nomd.Text = DataGridView1.Rows(i).Cells(1).Value
        dentiste_add.prenomd.Text = DataGridView1.Rows(i).Cells(2).Value
        dentiste_add.emaild.Text = DataGridView1.Rows(i).Cells(3).Value
        dentiste_add.teld.Text = DataGridView1.Rows(i).Cells(4).Value
        dentiste_add.adresse.Text = DataGridView1.Rows(i).Cells(5).Value
        dentiste_add.date_embauche.Text = DataGridView1.Rows(i).Cells(6).Value
        dentiste_add.notes.Text = DataGridView1.Rows(i).Cells(8).Value
        dentiste_add.PictureBox1.Image = DataGridView1.Rows(i).Cells(7).Value
        dentiste_add.ligne_modifie.Text = i
        dentiste_add.type_operation.Text = "Modifier"
        dentiste_add.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font_titre As New Font("Arial", 12, FontStyle.Regular)
        Dim font_tcolonne As New Font("Arial", 10, FontStyle.Bold)
        Dim font_colonne As New Font("Arial", 10, FontStyle.Regular)
        Dim font_petitetaille As New Font("Arial", 8, FontStyle.Regular)
        Dim ln As Integer = 50
        Dim cl As Integer = 50
        Dim imageToPrint As Image = Image.FromFile("images/logo.jpg")
        e.Graphics.DrawImage(imageToPrint, 40, 40, 40, 40)
        e.Graphics.DrawString("gestion de dentiste", font_petitetaille, Brushes.Black, 85, ln)
        e.Graphics.DrawString("Liste des dentiste", font_titre, Brushes.Black, 334, 80)
        Dim ligne As New Pen(Color.Black, 0.1)
        ln = ln + 80
        With e.Graphics
            .DrawString("Id ", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 40, ln)
            .DrawString("Préom", font_tcolonne, Brushes.Black, cl + 140, ln)
            .DrawString("Tél", font_tcolonne, Brushes.Black, cl + 240, ln)
            .DrawString("Adresse", font_tcolonne, Brushes.Black, cl + 340, ln)
            .DrawString("Dare_Embauche", font_tcolonne, Brushes.Black, cl + 440, ln)
            .DrawString("Notes", font_tcolonne, Brushes.Black, cl + 640, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Dim c1, c2, c3, c4, c5, c6, c7 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            c3 = DataGridView1.Rows(i).Cells(2).Value
            c4 = DataGridView1.Rows(i).Cells(3).Value
            c5 = DataGridView1.Rows(i).Cells(4).Value
            c6 = DataGridView1.Rows(i).Cells(5).Value
            c7 = DataGridView1.Rows(i).Cells(6).Value

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 40, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 140, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 240, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 340, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 440, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 640, ln)
            End With
            ln = ln + 20
            'e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 780, 1100)
        e.Graphics.DrawString("Entreprise : Liste des dentiste ", font_petitetaille, Brushes.Black, cl, 1100)
    End Sub
    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreche.Click

        requete = "select * from dentiste order by idd"
        afficher_dentiste(requete)
    End Sub

    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le texte à chercher : ", "Recherche", "")
        If Not String.IsNullOrEmpty(nom_a_chercher) Then
            requete = "select * from dentiste where " & _
                "ucase(idd) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(nom) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(prenom) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(email) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(tel) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(adresse) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(date_embauche) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(photo) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(note) like '%" + nom_a_chercher.ToUpper + "%'"
            afficher_dentiste(requete)
        End If
    End Sub
End Class