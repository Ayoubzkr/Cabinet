Imports System.Data.OleDb
Public Class traitement_add

    Private Sub traitement_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico") 'il faut placer emp.ico dans le dossier debug
        Me.Icon = icone
        Me.Text = "Formulaire du traitement "
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from patient"
        cmdsql()
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idp, noms As String
        idpatient.Items.Clear()
        While data.Read()
            idp = data(0).ToString
            noms = data(1)
            idpatient.Items.Add(idp + " | " + noms)
        End While
        con.Close()
        If type_operation.Text = "Ajouter" Then
            idpatient.Text = Nothing
            idtraitement.Text = Nothing
            datetraitement.Text = Date.Now
            montant.Text = Nothing
            description.Text = Nothing
        End If
    End Sub
    Private Sub Save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
            Dim p As Integer
        Dim idp As String = Nothing
        If (idpatient.SelectedIndex <> -1) Then
            p = InStr(idpatient.Text, "|")
            idp = Mid(idpatient.Text, 1, p - 1)
        End If
            If type_operation.Text = "Ajouter" Then
            requete = "insert into traitement values (" + idtraitement.Text + ", " + idp + ", '" + typet.Text + "', '" + datetraitement.Text + "', '" + description.Text + "', '" + montant.Text + "')"
            InputBox("", "", requete)
        Else
            requete = "update traitement set "
            If idp = Nothing Then idp = ancien_idtraitement.Text
            Dim un As Integer = 0
            If ancien_idtraitement.Text <> idp Then
                requete += "idtraitement = '" + idp + "'"
                un = 1
            End If
            requete += "idp = '" + idpatient.Text + "', " & _
                            "typedetraitement = '" + typet.Text + "', " & _
                            "datetraitement = '" + datetraitement.Text + "', " & _
                            "description = '" + description.Text + "', " & _
                            "montantdutraitement = " + montant.Text
            requete += " where idtraitement = '" + ancien_idtraitement.Text + "'"
            InputBox("", "", requete)
        End If
        connexion()
        cmdsql()
        cmd.ExecuteNonQuery()
        con.Close()
        con.Close()
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class