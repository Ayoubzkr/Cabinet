Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class employe
    Private Sub employe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES Employe"
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
        requete = "select * from employe order by idemploye"
        afficher_employe(requete)
    End Sub
    Public Sub afficher_employe(ByRef requete As String)
        connexion()
        requete = "select * from employe"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView1.Rows.Count
        If (employe_add.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (employe_add.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(employe_add.ligne_modifie.Text)).Selected = True
        End If
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        With employe_add
            .type_operation.Text = "Ajouter"
            .ncin.Text = Nothing
            .nom.Text = Nothing
            .prenom.Text = Nothing
            .tel.Text = Nothing
            .adresse.Text = Nothing
            .poste.Text = Nothing
            .datenais.Text = Nothing
            .mdp.Text = Nothing
        End With
        employe_add.ShowDialog()
    End Sub

    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreche.Click
        requete = "select * from employe order by idemploye"
        afficher_employe(requete)
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
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
        e.Graphics.DrawString("gestion de employe", font_petitetaille, Brushes.Black, 85, ln)
        e.Graphics.DrawString("Liste des employe", font_titre, Brushes.Black, 334, 80)
        Dim ligne As New Pen(Color.Black, 0.1)
        ln = ln + 80
        With e.Graphics
            .DrawString("Id ", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 40, ln)
            .DrawString("prenom", font_tcolonne, Brushes.Black, cl + 140, ln)
            .DrawString("cin", font_tcolonne, Brushes.Black, cl + 240, ln)
            .DrawString("datenaissance", font_tcolonne, Brushes.Black, cl + 340, ln)
            .DrawString("adresse", font_tcolonne, Brushes.Black, cl + 400, ln)
            .DrawString("tel", font_tcolonne, Brushes.Black, cl + 550, ln)
            .DrawString("poste", font_tcolonne, Brushes.Black, cl + 650, ln)
            .DrawString("motdepasse", font_tcolonne, Brushes.Black, cl + 700, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Dim c1, c2, c3, c4, c5, c6, c7, c8, c9 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            c3 = DataGridView1.Rows(i).Cells(2).Value
            c4 = DataGridView1.Rows(i).Cells(3).Value
            c5 = DataGridView1.Rows(i).Cells(4).Value
            c6 = DataGridView1.Rows(i).Cells(5).Value
            c7 = DataGridView1.Rows(i).Cells(6).Value
            c8 = DataGridView1.Rows(i).Cells(7).Value
            c9 = DataGridView1.Rows(i).Cells(7).Value

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 40, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 140, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 240, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 340, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 400, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 550, ln)
                .DrawString(c8, font_colonne, Brushes.Black, cl + 650, ln)
                .DrawString(c9, font_colonne, Brushes.Black, cl + 700, ln)
            End With
            ln = ln + 20
            'e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 780, 1100)
        e.Graphics.DrawString("Entreprise : Liste des employe ", font_petitetaille, Brushes.Black, cl, 1100)
    End Sub

    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun employe...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet employe : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "delete from employe where idemploye = " + id
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "select * from employe order by idemploye"
                afficher_employe(requete)
            End If
        End If
    End Sub

    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le texte à chercher : ", "Recherche", "")
        If Not String.IsNullOrEmpty(nom_a_chercher) Then
            requete = "select * from employe where " & _
                "ucase(nom) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(prenom) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(adresse) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(tel) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(datedenaissance) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(poste) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(motdepasse) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(ide) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(ncin) like '%" + nom_a_chercher.ToUpper + "%'"
            afficher_employe(requete)
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        employe_add.ancien_ide.Text = DataGridView1.Rows(i).Cells(0).Value
        employe_add.nom.Text = DataGridView1.Rows(i).Cells(1).Value
        employe_add.prenom.Text = DataGridView1.Rows(i).Cells(2).Value
        employe_add.poste.Text = DataGridView1.Rows(i).Cells(7).Value
        employe_add.datenais.Text = DataGridView1.Rows(i).Cells(4).Value
        employe_add.tel.Text = DataGridView1.Rows(i).Cells(6).Value
        employe_add.mdp.Text = DataGridView1.Rows(i).Cells(8).Value
        employe_add.ncin.Text = DataGridView1.Rows(i).Cells(3).Value
        employe_add.adresse.Text = DataGridView1.Rows(i).Cells(5).Value
        employe_add.ShowDialog()
    End Sub
End Class