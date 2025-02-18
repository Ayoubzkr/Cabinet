Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class rendezvous

    Private Sub rendezvous_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.BackColor = Color.White
        Me.Width = 850
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
        Dim idrdv, idp, idd, heurerdv, staturdv, notes, daterdv As New DataGridViewTextBoxColumn()
        idrdv.HeaderText = "Id rendez-vous"
        idrdv.Name = "idrdv"
        DataGridView1.Columns.Add(idrdv)
        idrdv.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        idp.HeaderText = "Id patient"
        idp.Name = "idp"
        DataGridView1.Columns.Add(idp)
        idp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        idd.HeaderText = "Id dentiste"
        idd.Name = "idp"
        DataGridView1.Columns.Add(idd)
        idd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        heurerdv.HeaderText = "Heure rendez-vous"
        heurerdv.Name = "heurerdv"
        DataGridView1.Columns.Add(heurerdv)
        heurerdv.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        daterdv.HeaderText = "Date rendez-vous"
        daterdv.Name = "daterdv"
        DataGridView1.Columns.Add(daterdv)
        daterdv.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        staturdv.HeaderText = "Statut rendez-vous"
        staturdv.Name = "staturdv"
        DataGridView1.Columns.Add(staturdv)
        staturdv.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        notes.HeaderText = "Notrs"
        notes.Name = "notes"
        DataGridView1.Columns.Add(notes)
        notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        requete = "select * from rendezvous order by idrdv"
        afficher_rendezvous(requete)
    End Sub
    Public Sub afficher_rendezvous(ByRef requete As String)
        DataGridView1.Rows.Clear()
        connexion()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = requete
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idrdv, idp, idd, heurerdv, daterdv, staturdv, notes As String
        While data.Read()
            idrdv = data(0).ToString
            idp = data(1)
            idd = data(2)
            heurerdv = data(3)
            daterdv = data(4)
            staturdv = data(5)
            If Not IsDBNull(data(6)) Then
                notes = data(6)
            Else
                notes = "" ' ou notes = "Non spécifié"
            End If
            DataGridView1.Rows.Add(idrdv, idp, idd, heurerdv, daterdv, staturdv, notes)
        End While
        con.Close()
    End Sub
    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        requete = "select * from rendezvous order by idrdv"
        afficher_rendezvous(requete)
    End Sub
    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        With rendezvous_add
            .idrdv.Text = Nothing
            .idp.Text = Nothing
            .idd.Text = Nothing
            .staturdv.Text = Nothing
            .daterdv.Text = Nothing
            .heurerdv.Text = Nothing
            .notes.Text = Nothing
            .type_operation.Text = "Ajouter"
        End With
        rendezvous_add.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        rendezvous_add.idrdv.Text = DataGridView1.Rows(i).Cells(0).Value
        rendezvous_add.idp.Text = DataGridView1.Rows(i).Cells(1).Value
        rendezvous_add.idd.Text = DataGridView1.Rows(i).Cells(2).Value
        rendezvous_add.ancien_idp.Text = DataGridView1.Rows(i).Cells(1).Value
        rendezvous_add.ancien_idd.Text = DataGridView1.Rows(i).Cells(2).Value
        rendezvous_add.daterdv.Text = DataGridView1.Rows(i).Cells(3).Value
        rendezvous_add.heurerdv.Text = DataGridView1.Rows(i).Cells(4).Value
        rendezvous_add.staturdv.Text = DataGridView1.Rows(i).Cells(5).Value
        rendezvous_add.notes.Text = DataGridView1.Rows(i).Cells(6).Value
        rendezvous_add.type_operation.Text = "Modifier"
        rendezvous_add.ShowDialog()
    End Sub
    Private Sub rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le texte à chercher : ", "Recherche", "")
        If Not String.IsNullOrEmpty(nom_a_chercher) Then
            requete = "select * from rendezvous where " & _
                "ucase(idtdv) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(titre) like '%" + nom_a_chercher.ToUpper + "%'" & _
                "or ucase(definition) like '%" + nom_a_chercher.ToUpper + "%'"
            afficher_rendezvous(requete)
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
        e.Graphics.DrawString("gestion de rendez vous", font_petitetaille, Brushes.Black, 85, ln)
        e.Graphics.DrawString("Liste des rendez-vous", font_titre, Brushes.Black, 334, 80)
        Dim ligne As New Pen(Color.Black, 0.1)
        ln = ln + 80
        With e.Graphics
            .DrawString("Id rendez-vous ", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("idp", font_tcolonne, Brushes.Black, cl + 150, ln)
            .DrawString("idd", font_tcolonne, Brushes.Black, cl + 200, ln)
            .DrawString("Heure", font_tcolonne, Brushes.Black, cl + 300, ln)
            .DrawString("Date", font_tcolonne, Brushes.Black, cl + 450, ln)
            .DrawString("Statut", font_tcolonne, Brushes.Black, cl + 550, ln)
            .DrawString("Notes", font_tcolonne, Brushes.Black, cl + 620, ln)
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
                .DrawString(c2, font_colonne, Brushes.Black, cl + 150, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 200, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 300, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 450, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 550, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 620, ln)
            End With
            ln = ln + 20
            'e.Graphics.DrawLine(ligne, cl, ln, 780, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 780, 1100)
        e.Graphics.DrawString("Entreprise : Liste des rendez-vous ", font_petitetaille, Brushes.Black, cl, 1100)
    End Sub
    Private Sub supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun specialite...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(1).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cet rendez-vous : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "DELETE FROM rendezvous WHERE idrdv = '" & id & "'"
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "SELECT * FROM specialite ORDER BY ids"
                afficher_rendezvous(requete)
            End If
        End If
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class