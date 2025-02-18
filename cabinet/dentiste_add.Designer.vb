<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dentiste_add
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dentiste_add))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.anc_nom = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Ouvrir = New System.Windows.Forms.Button()
        Me.nom_photo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.date_embauche = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.emaild = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.teld = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.adresse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.notes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prenomd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ancien_idd = New System.Windows.Forms.TextBox()
        Me.nomd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Idd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.type_operation)
        Me.GroupBox1.Controls.Add(Me.ligne_modifie)
        Me.GroupBox1.Controls.Add(Me.anc_nom)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.Ouvrir)
        Me.GroupBox1.Controls.Add(Me.nom_photo)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.date_embauche)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.emaild)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.teld)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.adresse)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.notes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.prenomd)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ancien_idd)
        Me.GroupBox1.Controls.Add(Me.nomd)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Idd)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(857, 316)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité "
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(151, -2)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 71
        Me.type_operation.Text = "type_operation"
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(69, -2)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 70
        Me.ligne_modifie.Text = "ligne_modifie"
        '
        'anc_nom
        '
        Me.anc_nom.AutoSize = True
        Me.anc_nom.Location = New System.Drawing.Point(105, 25)
        Me.anc_nom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.anc_nom.Name = "anc_nom"
        Me.anc_nom.Size = New System.Drawing.Size(0, 13)
        Me.anc_nom.TabIndex = 68
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 1
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(753, 204)
        Me.Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(37, 30)
        Me.Save.TabIndex = 67
        Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ouvrir.png")
        Me.ImageList1.Images.SetKeyName(1, "save.png")
        '
        'Ouvrir
        '
        Me.Ouvrir.BackColor = System.Drawing.Color.White
        Me.Ouvrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ouvrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ouvrir.ImageIndex = 0
        Me.Ouvrir.ImageList = Me.ImageList1
        Me.Ouvrir.Location = New System.Drawing.Point(681, 204)
        Me.Ouvrir.Margin = New System.Windows.Forms.Padding(2)
        Me.Ouvrir.Name = "Ouvrir"
        Me.Ouvrir.Size = New System.Drawing.Size(38, 30)
        Me.Ouvrir.TabIndex = 66
        Me.Ouvrir.UseVisualStyleBackColor = False
        '
        'nom_photo
        '
        Me.nom_photo.AutoSize = True
        Me.nom_photo.Location = New System.Drawing.Point(699, 25)
        Me.nom_photo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.nom_photo.Name = "nom_photo"
        Me.nom_photo.Size = New System.Drawing.Size(65, 13)
        Me.nom_photo.TabIndex = 65
        Me.nom_photo.Text = "dentiste.png"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(652, 45)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'date_embauche
        '
        Me.date_embauche.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_embauche.Location = New System.Drawing.Point(465, 45)
        Me.date_embauche.Margin = New System.Windows.Forms.Padding(2)
        Me.date_embauche.Name = "date_embauche"
        Me.date_embauche.Size = New System.Drawing.Size(149, 20)
        Me.date_embauche.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(471, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Date Embauche"
        '
        'emaild
        '
        Me.emaild.Location = New System.Drawing.Point(305, 176)
        Me.emaild.Margin = New System.Windows.Forms.Padding(2)
        Me.emaild.Name = "emaild"
        Me.emaild.Size = New System.Drawing.Size(250, 20)
        Me.emaild.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(302, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "E-mail"
        '
        'teld
        '
        Me.teld.Location = New System.Drawing.Point(305, 127)
        Me.teld.Margin = New System.Windows.Forms.Padding(2)
        Me.teld.Name = "teld"
        Me.teld.Size = New System.Drawing.Size(250, 20)
        Me.teld.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(22, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Tél"
        '
        'adresse
        '
        Me.adresse.Location = New System.Drawing.Point(31, 127)
        Me.adresse.Margin = New System.Windows.Forms.Padding(2)
        Me.adresse.Multiline = True
        Me.adresse.Name = "adresse"
        Me.adresse.Size = New System.Drawing.Size(250, 67)
        Me.adresse.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 112)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Adresse"
        '
        'notes
        '
        Me.notes.Location = New System.Drawing.Point(305, 43)
        Me.notes.Margin = New System.Windows.Forms.Padding(2)
        Me.notes.Name = "notes"
        Me.notes.Size = New System.Drawing.Size(146, 20)
        Me.notes.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Notes"
        '
        'prenomd
        '
        Me.prenomd.Location = New System.Drawing.Point(305, 84)
        Me.prenomd.Margin = New System.Windows.Forms.Padding(2)
        Me.prenomd.Name = "prenomd"
        Me.prenomd.Size = New System.Drawing.Size(250, 20)
        Me.prenomd.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Prénom"
        '
        'ancien_idd
        '
        Me.ancien_idd.Location = New System.Drawing.Point(179, 34)
        Me.ancien_idd.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idd.Name = "ancien_idd"
        Me.ancien_idd.Size = New System.Drawing.Size(35, 20)
        Me.ancien_idd.TabIndex = 34
        Me.ancien_idd.Visible = False
        '
        'nomd
        '
        Me.nomd.Location = New System.Drawing.Point(31, 84)
        Me.nomd.Margin = New System.Windows.Forms.Padding(2)
        Me.nomd.Name = "nomd"
        Me.nomd.Size = New System.Drawing.Size(250, 20)
        Me.nomd.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nom"
        '
        'Idd
        '
        Me.Idd.Location = New System.Drawing.Point(31, 43)
        Me.Idd.Margin = New System.Windows.Forms.Padding(2)
        Me.Idd.Name = "Idd"
        Me.Idd.Size = New System.Drawing.Size(146, 20)
        Me.Idd.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ID Dentiste"
        '
        'dentiste_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 338)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "dentiste_add"
        Me.Text = "dentiste_add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents date_embauche As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents emaild As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents teld As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents adresse As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents notes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents prenomd As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ancien_idd As System.Windows.Forms.TextBox
    Friend WithEvents nomd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Idd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents nom_photo As System.Windows.Forms.Label
    Friend WithEvents Ouvrir As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents anc_nom As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
End Class
