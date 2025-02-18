<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class avoir_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(avoir_add))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.iddentiste = New System.Windows.Forms.ComboBox()
        Me.idspecialite = New System.Windows.Forms.ComboBox()
        Me.ancien_idd = New System.Windows.Forms.TextBox()
        Me.ancien_idspecialite = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.titreeeeeeeeeee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.iddentiste)
        Me.GroupBox1.Controls.Add(Me.idspecialite)
        Me.GroupBox1.Controls.Add(Me.ancien_idd)
        Me.GroupBox1.Controls.Add(Me.ancien_idspecialite)
        Me.GroupBox1.Controls.Add(Me.Save)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.titreeeeeeeeeee)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 198)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identité"
        '
        'iddentiste
        '
        Me.iddentiste.FormattingEnabled = True
        Me.iddentiste.Location = New System.Drawing.Point(11, 140)
        Me.iddentiste.Margin = New System.Windows.Forms.Padding(2)
        Me.iddentiste.Name = "iddentiste"
        Me.iddentiste.Size = New System.Drawing.Size(230, 21)
        Me.iddentiste.TabIndex = 82
        '
        'idspecialite
        '
        Me.idspecialite.FormattingEnabled = True
        Me.idspecialite.Location = New System.Drawing.Point(16, 53)
        Me.idspecialite.Margin = New System.Windows.Forms.Padding(2)
        Me.idspecialite.Name = "idspecialite"
        Me.idspecialite.Size = New System.Drawing.Size(230, 21)
        Me.idspecialite.TabIndex = 81
        '
        'ancien_idd
        '
        Me.ancien_idd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idd.Location = New System.Drawing.Point(233, 89)
        Me.ancien_idd.Name = "ancien_idd"
        Me.ancien_idd.Size = New System.Drawing.Size(75, 22)
        Me.ancien_idd.TabIndex = 80
        Me.ancien_idd.Visible = False
        '
        'ancien_idspecialite
        '
        Me.ancien_idspecialite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ancien_idspecialite.Location = New System.Drawing.Point(171, 13)
        Me.ancien_idspecialite.Name = "ancien_idspecialite"
        Me.ancien_idspecialite.Size = New System.Drawing.Size(75, 22)
        Me.ancien_idspecialite.TabIndex = 79
        Me.ancien_idspecialite.Visible = False
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
        'titreeeeeeeeeee
        '
        Me.titreeeeeeeeeee.AutoSize = True
        Me.titreeeeeeeeeee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titreeeeeeeeeee.Location = New System.Drawing.Point(12, 95)
        Me.titreeeeeeeeeee.Name = "titreeeeeeeeeee"
        Me.titreeeeeeeeeee.Size = New System.Drawing.Size(75, 16)
        Me.titreeeeeeeeeee.TabIndex = 48
        Me.titreeeeeeeeeee.Text = "Id dentiste :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Id Spécialité:"
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(105, 3)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(0, 13)
        Me.type_operation.TabIndex = 63
        '
        'avoir_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 232)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "avoir_add"
        Me.Text = "avoir_add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_idspecialite As System.Windows.Forms.TextBox
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents titreeeeeeeeeee As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ancien_idd As System.Windows.Forms.TextBox
    Friend WithEvents iddentiste As System.Windows.Forms.ComboBox
    Friend WithEvents idspecialite As System.Windows.Forms.ComboBox
End Class
