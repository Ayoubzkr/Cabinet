Imports System.Data.OleDb
Public Class avoir_add
    Private Sub avoir_add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim icone As New Icon("images/emp.ico") 'il faut placer emp.ico dans le dossier debug
        Me.Icon = icone
        Me.Text = "Formulaire d'avoir "
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from specialite"
        cmdsql()
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim ids, titres As String
        idspecialite.Items.Clear()
        While data.Read()
            ids = data(0).ToString
            titres = data(1)
            idspecialite.Items.Add(ids + " | " + titres)
        End While
        con.Close()

        connexion()
        requete = "select * from dentiste"
        cmdsql()
        data = cmd.ExecuteReader()
        Dim idd, noms As String
        iddentiste.Items.Clear()
        While data.Read()
            idd = data(0).ToString
            noms = data(1)
            iddentiste.Items.Add(idd + " | " + noms)
        End While
        con.Close()

        If type_operation.Text = "Ajouter" Then
            idspecialite.Text = Nothing
            iddentiste.Text = Nothing
        End If
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Dim p As Integer
        Dim ids As String = Nothing
        If (idspecialite.SelectedIndex <> -1) Then
            p = InStr(idspecialite.Text, "|")
            ids = Mid(idspecialite.Text, 1, p - 1)
        End If

        Dim idd As String = 0
        If (idspecialite.SelectedIndex <> -1) Then
            p = InStr(iddentiste.Text, "|")
            idd = Mid(iddentiste.Text, 1, p - 1)
        End If

        If type_operation.Text = "Ajouter" Then
            requete = "insert into avoir(ids, idd) values ('" + ids + "', " + idd + ")"
        Else
            requete = "update avoir set "
            If ids = Nothing Then ids = ancien_idspecialite.Text
            Dim un As Integer = 0
            If ancien_idspecialite.Text <> ids Then
                requete += "idservice = '" + ids + "'"
                un = 1
            End If
        End If
        connexion()
        cmdsql()
        cmd.ExecuteNonQuery()
        con.Close()
        requete = "select specialite.ids,titre, dentiste.idd, Nom, Prenom " & _
             "from specialite, dentiste, avoir " & _
             "where specialite.ids= avoir.ids " & _
             "and dentiste.idd  = avoir.idd"
        avoir.afficher_avoir(requete)
        con.Close()
        Me.Close()

    End Sub
End Class