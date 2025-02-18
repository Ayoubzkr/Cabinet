Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class specialites
    Private Sub specialites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.Text = "GESTION DES Specialite"
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
        Dim ids, titres, definition As New DataGridViewTextBoxColumn()
        ids.HeaderText = "Id spesialite"
        ids.Name = "ids"
        DataGridView1.Columns.Add(ids)
        ids.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        titres.HeaderText = "Titre"
        titres.Name = "titres"
        DataGridView1.Columns.Add(titres)
        titres.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        definition.HeaderText = "Définition"
        definition.Name = "definition"
        definition.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridView1.Columns.Add(definition)
        requete = "select * from specialite order by ids"
        afficher_specialite(requete)
    End Sub
    Public Sub afficher_specialite(ByRef requete As String)
        DataGridView1.Rows.Clear()
        connexion()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = requete
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim ids, titres, definition As String
        While data.Read()
            ids = data(0).ToString
            titres = data(1)
            definition = data(2)
            DataGridView1.Rows.Add(ids, titres, definition)
        End While
        con.Close()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        specialiter_add.ids.Text = DataGridView1.Rows(i).Cells(0).Value
        specialiter_add.ancien_ids.Text = specialiter_add.ids.Text
        specialiter_add.titres.Text = DataGridView1.Rows(i).Cells(1).Value
        specialiter_add.defi.Text = DataGridView1.Rows(i).Cells(1).Value
        produit_add.type_operation.Text = "Modifier"
        specialiter_add.ShowDialog()
    End Sub
    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        With specialiter_add
            .ids.Text = Nothing
            .titres.Text = Nothing
            .defi.Text = Nothing
            .type_operation.Text = "Ajouter"
        End With
        specialiter_add.ShowDialog()
    End Sub
    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreche.Click
        requete = "select * from specialite order by ids"
        afficher_specialite(requete)
    End Sub
    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le texte à chercher : ", "Recherche", "")
        If Not String.IsNullOrEmpty(nom_a_chercher) Then
            requete = "select * from specialite where " & _
                "ucase(ids) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(titre) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(definition) like '%" + nom_a_chercher.ToUpper + "%'"
            afficher_specialite(requete)
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
        e.Graphics.DrawString("gestion de spécialite", font_petitetaille, Brushes.Black, 85, ln)
        e.Graphics.DrawString("Liste des spécialite", font_titre, Brushes.Black, 334, 80)
        Dim ligne As New Pen(Color.Black, 0.1)
        ln = ln + 80
        With e.Graphics
            .DrawString("Id Spécialite ", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Titre", font_tcolonne, Brushes.Black, cl + 90, ln)
            .DrawString("Définition", font_tcolonne, Brushes.Black, cl + 250, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Dim c1, c2, c3 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            c3 = DataGridView1.Rows(i).Cells(2).Value
           
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 90, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 250, ln)
            End With
            ln = ln + 20
            'e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 780, 1100)
        e.Graphics.DrawString("Entreprise : Liste des spécialite ", font_petitetaille, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub
    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
          If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun specialite...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(1).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet spécialité : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "DELETE FROM specialite WHERE titre = '" & id & "'"
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "SELECT * FROM specialite ORDER BY ids"
                afficher_specialite(requete)
            End If
        End If
    End Sub

End Class