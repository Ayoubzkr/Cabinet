Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class avoir
    Private Sub avoir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.BackColor = Color.White
        Me.Width = 1200
        Me.Height = 400
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.CenterToScreen()
        DataGridView1.Width = Me.Width - 190
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
        Dim ids, idd, titre, nom, prenom As New DataGridViewTextBoxColumn()
        ids.HeaderText = "Id spesialite"
        ids.Name = "ids"
        DataGridView1.Columns.Add(ids)
        ids.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        idd.HeaderText = "Id dentiste"
        idd.Name = "idd"
        DataGridView1.Columns.Add(idd)
        idd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        titre.HeaderText = "Titre"
        titre.Name = "titre"
        DataGridView1.Columns.Add(titre)
        titre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        nom.HeaderText = "nom"
        nom.Name = "nom"
        DataGridView1.Columns.Add(nom)
        nom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        prenom.HeaderText = "prenom"
        prenom.Name = "prenom"
        DataGridView1.Columns.Add(prenom)
        prenom.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        requete = "select specialite.ids,titre, dentiste.idd, Nom, Prenom " & _
             "from specialite, dentiste, avoir " & _
             "where specialite.ids= avoir.ids " & _
             "and dentiste.idd  = avoir.idd"
        afficher_avoir(requete)
    End Sub
    Public Sub afficher_avoir(ByRef requete As String)
        DataGridView1.Rows.Clear()
        connexion()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = requete
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim ids, idd, titre, nom, prenom As String
        While data.Read()
            ids = data(0).ToString
            idd = data(1)
            titre = data(2)
            nom = data(3)
            prenom = data(4)
            DataGridView1.Rows.Add(ids, idd, titre, nom, prenom)
        End While
        con.Close()
    End Sub
    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreche.Click
        requete = "select * from avoir order by ids"
        afficher_avoir(requete)
    End Sub
    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le texte à chercher : ", "Recherche", "")
        If Not String.IsNullOrEmpty(nom_a_chercher) Then
            requete = "SELECT * FROM avoir " & _
                      "WHERE ids LIKE '%" + nom_a_chercher + "%' " & _
                      "OR idd LIKE '%" + nom_a_chercher + "%'"
            afficher_avoir(requete)
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
        e.Graphics.DrawString("Liste des avoirs", font_titre, Brushes.Black, 334, 80)
        Dim ligne As New Pen(Color.Black, 0.1)
        ln = ln + 80
        With e.Graphics
            .DrawString("Id Spécialite ", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Id dentiste", font_tcolonne, Brushes.Black, cl + 90, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Dim c1, c2 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 90, ln)
            End With
            ln = ln + 20
            'e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 780, 1100)
        e.Graphics.DrawString("Entreprise : Liste des avoirs ", font_petitetaille, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun ligne...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(1).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet ligne : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "DELETE FROM avoir WHERE ids = '" & id & "'"
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "SELECT * FROM avoir ORDER BY ids"
                afficher_avoir(requete)
            End If
        End If
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        With avoir_add
            .type_operation.Text = "Ajouter"
        End With
        avoir_add.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        avoir_add.ancien_idspecialite.Text = DataGridView1.Rows(i).Cells(0).Value
        avoir_add.ancien_idd.Text = DataGridView1.Rows(i).Cells(1).Value
        avoir_add.type_operation.Text = "Modifier"
        avoir_add.ShowDialog()
    End Sub
End Class