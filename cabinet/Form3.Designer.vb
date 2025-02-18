<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.typep = New System.Windows.Forms.TextBox()
        Me.dateins = New System.Windows.Forms.DateTimePicker()
        Me.datenais = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cinp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.villep = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.telp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label005 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.prenomp = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.nomp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idp = New System.Windows.Forms.TextBox()
        Me.Modifer = New System.Windows.Forms.Button()
        Me.ancien_idp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'typep
        '
        Me.typep.Location = New System.Drawing.Point(17, 206)
        Me.typep.Name = "typep"
        Me.typep.Size = New System.Drawing.Size(221, 20)
        Me.typep.TabIndex = 86
        '
        'dateins
        '
        Me.dateins.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateins.Location = New System.Drawing.Point(362, 97)
        Me.dateins.Margin = New System.Windows.Forms.Padding(2)
        Me.dateins.Name = "dateins"
        Me.dateins.Size = New System.Drawing.Size(243, 20)
        Me.dateins.TabIndex = 85
        '
        'datenais
        '
        Me.datenais.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datenais.Location = New System.Drawing.Point(362, 41)
        Me.datenais.Margin = New System.Windows.Forms.Padding(2)
        Me.datenais.Name = "datenais"
        Me.datenais.Size = New System.Drawing.Size(243, 20)
        Me.datenais.TabIndex = 84
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Type :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(155, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "CIN :"
        '
        'cinp
        '
        Me.cinp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinp.Location = New System.Drawing.Point(148, 49)
        Me.cinp.Name = "cinp"
        Me.cinp.Size = New System.Drawing.Size(101, 22)
        Me.cinp.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(358, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Ville :"
        '
        'villep
        '
        Me.villep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.villep.Location = New System.Drawing.Point(362, 195)
        Me.villep.Name = "villep"
        Me.villep.Size = New System.Drawing.Size(243, 22)
        Me.villep.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(358, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Tel :"
        '
        'telp
        '
        Me.telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.telp.Location = New System.Drawing.Point(362, 142)
        Me.telp.Name = "telp"
        Me.telp.Size = New System.Drawing.Size(243, 22)
        Me.telp.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(358, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Date d'insription:"
        '
        'label005
        '
        Me.label005.AutoSize = True
        Me.label005.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label005.Location = New System.Drawing.Point(361, 16)
        Me.label005.Name = "label005"
        Me.label005.Size = New System.Drawing.Size(127, 16)
        Me.label005.TabIndex = 74
        Me.label005.Text = "Date de naissance :"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(26, 126)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(61, 16)
        Me.label4.TabIndex = 73
        Me.label4.Text = "Prenom :"
        '
        'prenomp
        '
        Me.prenomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenomp.ForeColor = System.Drawing.Color.Black
        Me.prenomp.Location = New System.Drawing.Point(17, 142)
        Me.prenomp.Name = "prenomp"
        Me.prenomp.Size = New System.Drawing.Size(221, 22)
        Me.prenomp.TabIndex = 72
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(27, 78)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 16)
        Me.label2.TabIndex = 71
        Me.label2.Text = "Nom :"
        '
        'nomp
        '
        Me.nomp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomp.ForeColor = System.Drawing.Color.Black
        Me.nomp.Location = New System.Drawing.Point(17, 97)
        Me.nomp.Name = "nomp"
        Me.nomp.Size = New System.Drawing.Size(221, 22)
        Me.nomp.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Id Patient:"
        '
        'idp
        '
        Me.idp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idp.ForeColor = System.Drawing.Color.Black
        Me.idp.Location = New System.Drawing.Point(17, 49)
        Me.idp.Name = "idp"
        Me.idp.Size = New System.Drawing.Size(101, 22)
        Me.idp.TabIndex = 68
        '
        'Modifer
        '
        Me.Modifer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Modifer.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Modifer.Location = New System.Drawing.Point(199, 251)
        Me.Modifer.Name = "Modifer"
        Me.Modifer.Size = New System.Drawing.Size(253, 29)
        Me.Modifer.TabIndex = 87
        Me.Modifer.Text = "Modifier"
        Me.Modifer.UseVisualStyleBackColor = False
        '
        'ancien_idp
        '
        Me.ancien_idp.Location = New System.Drawing.Point(98, 16)
        Me.ancien_idp.Name = "ancien_idp"
        Me.ancien_idp.Size = New System.Drawing.Size(37, 20)
        Me.ancien_idp.TabIndex = 88
        Me.ancien_idp.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 319)
        Me.Controls.Add(Me.ancien_idp)
        Me.Controls.Add(Me.Modifer)
        Me.Controls.Add(Me.typep)
        Me.Controls.Add(Me.dateins)
        Me.Controls.Add(Me.datenais)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cinp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.villep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.telp)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.label005)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.prenomp)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.nomp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idp)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents typep As System.Windows.Forms.TextBox
    Friend WithEvents dateins As System.Windows.Forms.DateTimePicker
    Friend WithEvents datenais As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cinp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents villep As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents telp As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents label005 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents prenomp As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents nomp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idp As System.Windows.Forms.TextBox
    Friend WithEvents Modifer As System.Windows.Forms.Button
    Friend WithEvents ancien_idp As System.Windows.Forms.TextBox
End Class
