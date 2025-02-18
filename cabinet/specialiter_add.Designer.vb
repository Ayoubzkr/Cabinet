<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class specialiter_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(specialiter_add))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_ids = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.definitionnnnnnn = New System.Windows.Forms.Label()
        Me.defi = New System.Windows.Forms.TextBox()
        Me.titreeeeeeeeeee = New System.Windows.Forms.Label()
        Me.titres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ids = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.type_operation)
        Me.GroupBox1.Controls.Add(Me.ancien_ids)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.definitionnnnnnn)
        Me.GroupBox1.Controls.Add(Me.defi)
        Me.GroupBox1.Controls.Add(Me.titreeeeeeeeeee)
        Me.GroupBox1.Controls.Add(Me.titres)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ids)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 263)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité"
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(93, -5)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(0, 13)
        Me.type_operation.TabIndex = 63
        '
        'ancien_ids
        '
        Me.ancien_ids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_ids.Location = New System.Drawing.Point(171, 13)
        Me.ancien_ids.Name = "ancien_ids"
        Me.ancien_ids.Size = New System.Drawing.Size(75, 22)
        Me.ancien_ids.TabIndex = 79
        Me.ancien_ids.Visible = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.White
        Me.Save.FlatAppearance.BorderSize = 0
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.ImageKey = "save.png"
        Me.Save.ImageList = Me.ImageList1
        Me.Save.Location = New System.Drawing.Point(264, 23)
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
        'definitionnnnnnn
        '
        Me.definitionnnnnnn.AutoSize = True
        Me.definitionnnnnnn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.definitionnnnnnn.Location = New System.Drawing.Point(24, 116)
        Me.definitionnnnnnn.Name = "definitionnnnnnn"
        Me.definitionnnnnnn.Size = New System.Drawing.Size(69, 16)
        Me.definitionnnnnnn.TabIndex = 50
        Me.definitionnnnnnn.Text = "Définition :"
        '
        'defi
        '
        Me.defi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defi.Location = New System.Drawing.Point(15, 135)
        Me.defi.Multiline = True
        Me.defi.Name = "defi"
        Me.defi.Size = New System.Drawing.Size(221, 84)
        Me.defi.TabIndex = 49
        '
        'titreeeeeeeeeee
        '
        Me.titreeeeeeeeeee.AutoSize = True
        Me.titreeeeeeeeeee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreeeeeeeeeee.Location = New System.Drawing.Point(25, 68)
        Me.titreeeeeeeeeee.Name = "titreeeeeeeeeee"
        Me.titreeeeeeeeeee.Size = New System.Drawing.Size(107, 16)
        Me.titreeeeeeeeeee.TabIndex = 48
        Me.titreeeeeeeeeee.Text = "Titre Spécialité  :"
        '
        'titres
        '
        Me.titres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titres.Location = New System.Drawing.Point(15, 87)
        Me.titres.Name = "titres"
        Me.titres.Size = New System.Drawing.Size(221, 22)
        Me.titres.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Id Spécialité:"
        '
        'ids
        '
        Me.ids.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ids.Location = New System.Drawing.Point(15, 39)
        Me.ids.Name = "ids"
        Me.ids.Size = New System.Drawing.Size(221, 22)
        Me.ids.TabIndex = 45
        '
        'specialiter_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 297)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "specialiter_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "specialiter_add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents definitionnnnnnn As System.Windows.Forms.Label
    Friend WithEvents defi As System.Windows.Forms.TextBox
    Friend WithEvents titreeeeeeeeeee As System.Windows.Forms.Label
    Friend WithEvents titres As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ids As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_ids As System.Windows.Forms.TextBox
End Class
