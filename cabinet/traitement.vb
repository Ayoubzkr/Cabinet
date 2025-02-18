Imports System.Data.OleDb
Imports System.Security.Cryptography
Imports System.Text
Imports System.Drawing.Printing
Public Class traitement
    Public etat As Integer
    Private Sub traitement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico")
        Me.Icon = icone
        Me.BackColor = Color.White
        Me.Width = 930
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
        Dim idtr, idp, type, datetraitement, nom, prenom, description, montant As New DataGridViewTextBoxColumn()
        idtr.HeaderText = "Id traitement"
        idtr.Name = "idtraitement"
        DataGridView1.Columns.Add(idtr)
        idtr.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        idp.HeaderText = "Id patient"
        idp.Name = "idp"
        DataGridView1.Columns.Add(idp)
        idp.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        type.HeaderText = "Nom "
        type.Name = "nom"
        DataGridView1.Columns.Add(nom)
        type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        type.HeaderText = "Prenom "
        type.Name = "prenom"
        DataGridView1.Columns.Add(prenom)
        type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells


        type.HeaderText = "Type "
        type.Name = "typedetraitement"
        DataGridView1.Columns.Add(type)
        type.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        datetraitement.HeaderText = "datetraitement"
        datetraitement.Name = "datetraitement"
        DataGridView1.Columns.Add(datetraitement)
        datetraitement.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        description.HeaderText = "description"
        description.Name = "description"
        DataGridView1.Columns.Add(description)
        description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

        montant.HeaderText = "montant"
        montant.Name = "montant"
        DataGridView1.Columns.Add(montant)
        montant.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        requete = "select idtraitement, patient.idp,nom,prenom, typedetraitement, datetraitement, description, montantdutraitement " & _
            "from traitement, patient " & _
            "where traitement.idp = patient.idp"
        afficher_traitement(requete)
    End Sub
    Public Sub afficher_traitement(ByRef requete As String)
        DataGridView1.Rows.Clear()
        connexion()
        Dim cmd As New OleDbCommand
        cmd.Connection = con
        cmd.CommandText = requete
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idtr, idp, nom, prenom, type, datetr, description, montant As String
        While data.Read()
            idtr = data(0).ToString
            idp = data(1)
            nom = data(2)
            prenom = data(3)
            type = data(4)
            datetr = data(5)
            description = data(6)
            montant = data(7)
            DataGridView1.Rows.Add(idtr, idp, nom, prenom, type, datetr, description, montant)
        End While
        con.Close()
    End Sub
    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        traitement_add.type_operation.Text = "Ajouter"
        traitement_add.ShowDialog()

    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer.Click
        traitement_add.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucune affectation...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim ids As String = DataGridView1.Rows(i).Cells(0).Value
            Dim ide As String = DataGridView1.Rows(i).Cells(2).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cette affectation ? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "delete from traitement where idservice = '" + ids + "' and idemploye = " & ide
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "select * from traitement"
                afficher_traitement(requete)
                con.Close()
            End If
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom ou le prénom ou le nom du service à chercher : ", "Recherche", "")
        connexion()
        requete = "select * from traitement where " & _
            "idp like '%" + nom_a_chercher + "%'"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        If (DataGridView1.Rows.Count = 0) Then MsgBox("Introuvable...", vbExclamation, "Message")
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        traitement_add.idpatient.Text = DataGridView1.Rows(i).Cells(1).Value
        traitement_add.idtraitement.Text = DataGridView1.Rows(i).Cells(0).Value
        traitement_add.ancien_idtraitement.Text = traitement_add.idtraitement.Text
        traitement_add.datetraitement.Text = DataGridView1.Rows(i).Cells(5).Value
        traitement_add.description.Text = DataGridView1.Rows(i).Cells(6).Value
        traitement_add.montant.Text = DataGridView1.Rows(i).Cells(7).Value
        traitement_add.typet.Text = DataGridView1.Rows(i).Cells(4).Value
        traitement_add.ligne_modifie.Text = i
        traitement_add.type_operation.Text = "Modifier"
        traitement_add.ShowDialog()
    End Sub
    Private Sub refreche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreche.Click
        requete = "select * from traitement order by idtraitement"
        afficher_traitement(requete)
    End Sub
    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        etat = 1
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ImprimerListeDesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerListeDesToolStripMenuItem.Click
        etat = 2
        Dim id_p As String
        id_p = InputBox("Entrez le id du patient à chercher", "Imprimer liste des traitement d'un patient", "Patient ")
        'liste des employés d'un service
        connexion()
        requete = "select traitement.idtraitement,idp, typetraitement, description, datetraitement " & _
            "from traitement, patient" & _
            "where traitement.idp = patient.idp " & _
            "and idp like '" + id_p + "'"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Columns(0).Width = 100
        con.Close()
        Dim cpt As Integer = DataGridView2.Rows.Count()
        If cpt = 0 Then
            MsgBox("patient entré introuvable...", MsgBoxStyle.Information, "Message")
        Else
            'Imprimer
            DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font_titre As New Font("Arial", 12, FontStyle.Regular)
        Dim font_tcolonne As New Font("Arial", 10, FontStyle.Bold)
        Dim font_colonne As New Font("Arial", 10, FontStyle.Regular)
        Dim ln As Integer = 50
        Dim cl As Integer = 50
        e.Graphics.DrawString("Liste des affectations ", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Gray)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("Id traitement", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Id patient", font_tcolonne, Brushes.Black, cl + 80, ln)
            .DrawString("nom", font_tcolonne, Brushes.Black, cl + 100, ln)
            .DrawString("prenom", font_tcolonne, Brushes.Black, cl + 300, ln)
            .DrawString("Date traitement", font_tcolonne, Brushes.Black, cl + 400, ln)
            .DrawString("Description", font_tcolonne, Brushes.Black, cl + 520, ln)
            .DrawString("Montant", font_tcolonne, Brushes.Black, cl + 620, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6, c7 As String
        Dim nld As Integer 'nld : nombre_de_ligne_du_datagrid
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        If etat = 3 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value
                c2 = DataGridView1.Rows(i).Cells(1).Value
                c3 = DataGridView1.Rows(i).Cells(2).Value
                c4 = DataGridView1.Rows(i).Cells(3).Value
                c5 = DataGridView1.Rows(i).Cells(4).Value
                c6 = DataGridView1.Rows(i).Cells(5).Value
                c7 = DataGridView1.Rows(i).Cells(6).Value
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value
                c2 = DataGridView2.Rows(i).Cells(1).Value
                c3 = DataGridView2.Rows(i).Cells(2).Value
                c4 = DataGridView2.Rows(i).Cells(3).Value
                c5 = DataGridView2.Rows(i).Cells(4).Value
                c6 = DataGridView2.Rows(i).Cells(5).Value
                c7 = DataGridView2.Rows(i).Cells(6).Value
            End If

            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 80, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 100, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 300, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 400, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 520, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 620, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Entreprise : Liste des affectations ", font_titre, Brushes.Black, cl, 1100)
    End Sub
End Class