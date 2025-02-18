<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rendezvous_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rendezvous_add))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ancien_idd = New System.Windows.Forms.TextBox()
        Me.ancien_idp = New System.Windows.Forms.TextBox()
        Me.heurerdv = New System.Windows.Forms.DateTimePicker()
        Me.daterdv = New System.Windows.Forms.DateTimePicker()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.ancien_idrdv = New System.Windows.Forms.TextBox()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.notes = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.staturdv = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.definitionnnnnnn = New System.Windows.Forms.Label()
        Me.idd = New System.Windows.Forms.TextBox()
        Me.titreeeeeeeeeee = New System.Windows.Forms.Label()
        Me.idp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idrdv = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ancien_idd)
        Me.GroupBox1.Controls.Add(Me.ancien_idp)
        Me.GroupBox1.Controls.Add(Me.heurerdv)
        Me.GroupBox1.Controls.Add(Me.daterdv)
        Me.GroupBox1.Controls.Add(Me.ligne_modifie)
        Me.GroupBox1.Controls.Add(Me.ancien_idrdv)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.notes)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.staturdv)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.definitionnnnnnn)
        Me.GroupBox1.Controls.Add(Me.idd)
        Me.GroupBox1.Controls.Add(Me.titreeeeeeeeeee)
        Me.GroupBox1.Controls.Add(Me.idp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.idrdv)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 263)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité"
        '
        'ancien_idd
        '
        Me.ancien_idd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idd.Location = New System.Drawing.Point(434, 213)
        Me.ancien_idd.Name = "ancien_idd"
        Me.ancien_idd.Size = New System.Drawing.Size(87, 22)
        Me.ancien_idd.TabIndex = 83
        Me.ancien_idd.Visible = False
        '
        'ancien_idp
        '
        Me.ancien_idp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idp.Location = New System.Drawing.Point(434, 175)
        Me.ancien_idp.Name = "ancien_idp"
        Me.ancien_idp.Size = New System.Drawing.Size(87, 22)
        Me.ancien_idp.TabIndex = 82
        Me.ancien_idp.Visible = False
        '
        'heurerdv
        '
        Me.heurerdv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.heurerdv.Location = New System.Drawing.Point(254, 34)
        Me.heurerdv.Margin = New System.Windows.Forms.Padding(2)
        Me.heurerdv.Name = "heurerdv"
        Me.heurerdv.Size = New System.Drawing.Size(149, 20)
        Me.heurerdv.TabIndex = 81
        '
        'daterdv
        '
        Me.daterdv.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.daterdv.Location = New System.Drawing.Point(27, 199)
        Me.daterdv.Margin = New System.Windows.Forms.Padding(2)
        Me.daterdv.Name = "daterdv"
        Me.daterdv.Size = New System.Drawing.Size(149, 20)
        Me.daterdv.TabIndex = 80
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(91, 0)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 79
        Me.ligne_modifie.Text = "ligne_modifie"
        '
        'ancien_idrdv
        '
        Me.ancien_idrdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idrdv.Location = New System.Drawing.Point(142, 13)
        Me.ancien_idrdv.Name = "ancien_idrdv"
        Me.ancien_idrdv.Size = New System.Drawing.Size(75, 22)
        Me.ancien_idrdv.TabIndex = 78
        Me.ancien_idrdv.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type_operation.Location = New System.Drawing.Point(380, 17)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(0, 16)
        Me.type_operation.TabIndex = 77
        Me.type_operation.Tag = "type_operation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(251, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Notes :"
        '
        'notes
        '
        Me.notes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notes.Location = New System.Drawing.Point(242, 144)
        Me.notes.Name = "notes"
        Me.notes.Size = New System.Drawing.Size(221, 22)
        Me.notes.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Statut :"
        '
        'staturdv
        '
        Me.staturdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staturdv.Location = New System.Drawing.Point(242, 87)
        Me.staturdv.Name = "staturdv"
        Me.staturdv.Size = New System.Drawing.Size(221, 22)
        Me.staturdv.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Heure"
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
        'definitionnnnnnn
        '
        Me.definitionnnnnnn.AutoSize = True
        Me.definitionnnnnnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.definitionnnnnnn.Location = New System.Drawing.Point(24, 116)
        Me.definitionnnnnnn.Name = "definitionnnnnnn"
        Me.definitionnnnnnn.Size = New System.Drawing.Size(75, 16)
        Me.definitionnnnnnn.TabIndex = 50
        Me.definitionnnnnnn.Text = "Id dentiste :"
        '
        'idd
        '
        Me.idd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idd.Location = New System.Drawing.Point(15, 135)
        Me.idd.Multiline = True
        Me.idd.Name = "idd"
        Me.idd.Size = New System.Drawing.Size(221, 35)
        Me.idd.TabIndex = 49
        '
        'titreeeeeeeeeee
        '
        Me.titreeeeeeeeeee.AutoSize = True
        Me.titreeeeeeeeeee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreeeeeeeeeee.Location = New System.Drawing.Point(25, 68)
        Me.titreeeeeeeeeee.Name = "titreeeeeeeeeee"
        Me.titreeeeeeeeeee.Size = New System.Drawing.Size(65, 16)
        Me.titreeeeeeeeeee.TabIndex = 48
        Me.titreeeeeeeeeee.Text = "id patient:"
        '
        'idp
        '
        Me.idp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idp.Location = New System.Drawing.Point(15, 87)
        Me.idp.Name = "idp"
        Me.idp.Size = New System.Drawing.Size(221, 22)
        Me.idp.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Id rendez-vous"
        '
        'idrdv
        '
        Me.idrdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idrdv.Location = New System.Drawing.Point(15, 39)
        Me.idrdv.Name = "idrdv"
        Me.idrdv.Size = New System.Drawing.Size(221, 22)
        Me.idrdv.TabIndex = 45
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageIndex = 0
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(492, 23)
        Me.Save.Margin = New System.Windows.Forms.Padding(2)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(29, 31)
        Me.Save.TabIndex = 66
        Me.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Save.UseVisualStyleBackColor = False
        '
        'rendezvous_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 303)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.type_operation)
        Me.Name = "rendezvous_add"
        Me.Text = "rendezvous_add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents heurerdv As System.Windows.Forms.DateTimePicker
    Friend WithEvents daterdv As System.Windows.Forms.DateTimePicker
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents ancien_idrdv As System.Windows.Forms.TextBox
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents notes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents staturdv As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents definitionnnnnnn As System.Windows.Forms.Label
    Friend WithEvents idd As System.Windows.Forms.TextBox
    Friend WithEvents titreeeeeeeeeee As System.Windows.Forms.Label
    Friend WithEvents idp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idrdv As System.Windows.Forms.TextBox
    Friend WithEvents ancien_idd As System.Windows.Forms.TextBox
    Friend WithEvents ancien_idp As System.Windows.Forms.TextBox
End Class
