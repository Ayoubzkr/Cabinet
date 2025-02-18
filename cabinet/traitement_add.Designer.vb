<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class traitement_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(traitement_add))
        Me.type_operation = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.idtraitement = New System.Windows.Forms.TextBox()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datetraitement = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.montant = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.typet = New System.Windows.Forms.TextBox()
        Me.idpatient = New System.Windows.Forms.ComboBox()
        Me.ancien_idd = New System.Windows.Forms.TextBox()
        Me.ancien_idtraitement = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titreeeeeeeeeee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(118, 12)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(0, 13)
        Me.type_operation.TabIndex = 65
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.idtraitement)
        Me.GroupBox1.Controls.Add(Me.ligne_modifie)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.datetraitement)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.montant)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.description)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.typet)
        Me.GroupBox1.Controls.Add(Me.idpatient)
        Me.GroupBox1.Controls.Add(Me.ancien_idd)
        Me.GroupBox1.Controls.Add(Me.ancien_idtraitement)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.titreeeeeeeeeee)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 237)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité"
        '
        'idtraitement
        '
        Me.idtraitement.Location = New System.Drawing.Point(11, 53)
        Me.idtraitement.Name = "idtraitement"
        Me.idtraitement.Size = New System.Drawing.Size(211, 20)
        Me.idtraitement.TabIndex = 131
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(93, 0)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 130
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(273, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "date"
        '
        'datetraitement
        '
        Me.datetraitement.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetraitement.Location = New System.Drawing.Point(275, 189)
        Me.datetraitement.Margin = New System.Windows.Forms.Padding(2)
        Me.datetraitement.Name = "datetraitement"
        Me.datetraitement.Size = New System.Drawing.Size(149, 20)
        Me.datetraitement.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "montant"
        '
        'montant
        '
        Me.montant.Location = New System.Drawing.Point(261, 132)
        Me.montant.Name = "montant"
        Me.montant.Size = New System.Drawing.Size(211, 20)
        Me.montant.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(272, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "description"
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(261, 74)
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(211, 20)
        Me.description.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "type traitement"
        '
        'typet
        '
        Me.typet.Location = New System.Drawing.Point(11, 177)
        Me.typet.Name = "typet"
        Me.typet.Size = New System.Drawing.Size(211, 20)
        Me.typet.TabIndex = 83
        '
        'idpatient
        '
        Me.idpatient.FormattingEnabled = True
        Me.idpatient.Location = New System.Drawing.Point(11, 113)
        Me.idpatient.Margin = New System.Windows.Forms.Padding(2)
        Me.idpatient.Name = "idpatient"
        Me.idpatient.Size = New System.Drawing.Size(230, 21)
        Me.idpatient.TabIndex = 82
        '
        'ancien_idd
        '
        Me.ancien_idd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idd.Location = New System.Drawing.Point(252, 13)
        Me.ancien_idd.Name = "ancien_idd"
        Me.ancien_idd.Size = New System.Drawing.Size(75, 22)
        Me.ancien_idd.TabIndex = 80
        Me.ancien_idd.Visible = False
        '
        'ancien_idtraitement
        '
        Me.ancien_idtraitement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idtraitement.Location = New System.Drawing.Point(171, 13)
        Me.ancien_idtraitement.Name = "ancien_idtraitement"
        Me.ancien_idtraitement.Size = New System.Drawing.Size(75, 22)
        Me.ancien_idtraitement.TabIndex = 79
        Me.ancien_idtraitement.Visible = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageKey = "save.png"
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(464, 13)
        Me.Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(42, 38)
        Me.Save.TabIndex = 66
        Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "save.png")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 59
        '
        'titreeeeeeeeeee
        '
        Me.titreeeeeeeeeee.AutoSize = True
        Me.titreeeeeeeeeee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreeeeeeeeeee.Location = New System.Drawing.Point(12, 95)
        Me.titreeeeeeeeeee.Name = "titreeeeeeeeeee"
        Me.titreeeeeeeeeee.Size = New System.Drawing.Size(35, 16)
        Me.titreeeeeeeeeee.TabIndex = 48
        Me.titreeeeeeeeeee.Text = "ID p:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Id raitement:"
        '
        'traitement_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 261)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "traitement_add"
        Me.Text = "traitement_add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents montant As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents description As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents typet As System.Windows.Forms.TextBox
    Friend WithEvents idpatient As System.Windows.Forms.ComboBox
    Friend WithEvents ancien_idd As System.Windows.Forms.TextBox
    Friend WithEvents ancien_idtraitement As System.Windows.Forms.TextBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents titreeeeeeeeeee As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents datetraitement As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents idtraitement As System.Windows.Forms.TextBox
End Class
