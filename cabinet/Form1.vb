Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class patients
    Private Sub patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES PATIENTS"
        Me.BackColor = Color.White
        Me.Width = 853
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
        Dim idp, nom, prenom, type, datenais, tel, ville, cin, dateins As New DataGridViewTextBoxColumn()
        idp.HeaderText = "IdP"
        idp.Name = "idpatient"
        DataGridView1.Columns.Add(idp)
        idp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        nom.HeaderText = "Nom"
        nom.Name = "nom"
        DataGridView1.Columns.Add(nom)
        nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        prenom.HeaderText = "Prénom"
        prenom.Name = "prenom"
        prenom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(prenom)
        type.HeaderText = "Type"
        type.Name = "type"
        DataGridView1.Columns.Add(type)
        datenais.HeaderText = "Date de naissance"
        datenais.Name = "datenais"
        DataGridView1.Columns.Add(datenais)
        tel.HeaderText = "Tél"
        tel.Name = "tel"
        DataGridView1.Columns.Add(tel)
        tel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dateins.HeaderText = "ville"
        dateins.Name = "ville"
        DataGridView1.Columns.Add(ville)
        cin.HeaderText = "ncin"
        cin.Name = "ncin"
        DataGridView1.Columns.Add(cin)
        dateins.HeaderText = "Date de dinscription"
        dateins.Name = "dateins"
        DataGridView1.Columns.Add(dateins)
        dateins.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        requete = "select * from patient order by idp"
        afficher_patient(requete)
    End Sub
    Public Sub afficher_patient(ByRef requete As String)
        DataGridView1.Rows.Clear()
        connexion()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = requete
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idp, nom, prenom, type, datenais, tel, ville, cin, dateins As String
        While data.Read()
            idp = data(0).ToString
            nom = data(1)
            prenom = data(2)
            type = data(3)
            datenais = data(4)
            tel = data(5)
            cin = data(8)
            dateins = data(7)
            ville = data(6)
            DataGridView1.Rows.Add(idp, nom, prenom, type, datenais, tel, ville, dateins, cin)
        End While
        con.Close()
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        With Form2
            .idp.Text = Nothing
            .cinp.Text = Nothing
            .nomp.Text = Nothing
            .prenomp.Text = Nothing
            .telp.Text = Nothing
            .villep.Text = Nothing
            .typep.Text = Nothing
            .datenais.Text = Nothing
            .dateins.Text = Nothing
        End With
        Form2.ShowDialog()
    End Sub

    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreche.Click
        requete = "select * from patient order by idp"
        afficher_patient(requete)
    End Sub
    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le texte à chercher : ", "Recherche", "")
        If Not String.IsNullOrEmpty(nom_a_chercher) Then
            requete = "select * from patient where " & _
                "ucase(nom) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(prenom) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(ville) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(tel) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(datenais) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(dateins) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(type) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(idp) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(cin) like '%" + nom_a_chercher.ToUpper + "%'"
            afficher_patient(requete)
        End If
    End Sub

    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun patient...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet patient : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "delete from patient where idp = " + id
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "select * from patient order by idp"
                afficher_patient(requete)
            End If
        End If
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
        e.Graphics.DrawString("gestion de patient", font_petitetaille, Brushes.Black, 85, ln)
        e.Graphics.DrawString("Liste des patients", font_titre, Brushes.Black, 334, 80)
        Dim ligne As New Pen(Color.Black, 0.1)
        ln = ln + 80
        With e.Graphics
            .DrawString("Id ", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 40, ln)
            .DrawString("Préom", font_tcolonne, Brushes.Black, cl + 140, ln)
            .DrawString("CIN", font_tcolonne, Brushes.Black, cl + 240, ln)
            .DrawString("Tél", font_tcolonne, Brushes.Black, cl + 340, ln)
            .DrawString("Dateins", font_tcolonne, Brushes.Black, cl + 440, ln)
            .DrawString("ville", font_tcolonne, Brushes.Black, cl + 640, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Dim c1, c2, c3, c4, c5, c6, c7 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            c3 = DataGridView1.Rows(i).Cells(2).Value
            c4 = DataGridView1.Rows(i).Cells(7).Value
            c5 = DataGridView1.Rows(i).Cells(5).Value
            c6 = DataGridView1.Rows(i).Cells(8).Value
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
        e.Graphics.DrawString("Entreprise : Liste des patients ", font_petitetaille, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        Form3.idp.Text = DataGridView1.Rows(i).Cells(0).Value
        Form3.ancien_idp.Text = Form3.idp.Text
        Form3.nomp.Text = DataGridView1.Rows(i).Cells(1).Value
        Form3.prenomp.Text = DataGridView1.Rows(i).Cells(2).Value
        Form3.typep.Text = DataGridView1.Rows(i).Cells(3).Value
        Form3.datenais.Text = DataGridView1.Rows(i).Cells(4).Value
        Form3.telp.Text = DataGridView1.Rows(i).Cells(5).Value
        Form3.villep.Text = DataGridView1.Rows(i).Cells(6).Value
        Form3.cinp.Text = DataGridView1.Rows(i).Cells(7).Value
        Form3.dateins.Text = DataGridView1.Rows(i).Cells(8).Value
        Form3.ShowDialog()
    End Sub
End Class
