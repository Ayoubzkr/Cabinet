<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cabinet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cabinet))
        Me.patient = New System.Windows.Forms.RadioButton()
        Me.specialite = New System.Windows.Forms.RadioButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dentistes = New System.Windows.Forms.RadioButton()
        Me.valider = New System.Windows.Forms.Button()
        Me.Stocks = New System.Windows.Forms.RadioButton()
        Me.av = New System.Windows.Forms.RadioButton()
        Me.rend = New System.Windows.Forms.RadioButton()
        Me.employee = New System.Windows.Forms.RadioButton()
        Me.traitementt = New System.Windows.Forms.RadioButton()
        Me.panelutilisateur = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cptutilisateur = New System.Windows.Forms.Label()
        Me.panelpointage = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cptpointage = New System.Windows.Forms.Label()
        Me.panelaffectation = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cptaffectation = New System.Windows.Forms.Label()
        Me.panelemploye = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cptemploye = New System.Windows.Forms.Label()
        Me.panelservice = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cptservice = New System.Windows.Forms.Label()
        Me.panelutilisateur.SuspendLayout()
        Me.panelpointage.SuspendLayout()
        Me.panelaffectation.SuspendLayout()
        Me.panelemploye.SuspendLayout()
        Me.panelservice.SuspendLayout()
        Me.SuspendLayout()
        '
        'patient
        '
        Me.patient.AutoSize = True
        Me.patient.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.patient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.patient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.patient.Location = New System.Drawing.Point(12, 12)
        Me.patient.Name = "patient"
        Me.patient.Size = New System.Drawing.Size(74, 20)
        Me.patient.TabIndex = 0
        Me.patient.TabStop = True
        Me.patient.Text = "Patient"
        Me.patient.UseVisualStyleBackColor = False
        '
        'specialite
        '
        Me.specialite.AutoSize = True
        Me.specialite.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.specialite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.specialite.Location = New System.Drawing.Point(363, 12)
        Me.specialite.Name = "specialite"
        Me.specialite.Size = New System.Drawing.Size(100, 20)
        Me.specialite.TabIndex = 1
        Me.specialite.TabStop = True
        Me.specialite.Text = "Spécialité "
        Me.specialite.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'dentistes
        '
        Me.dentistes.AutoSize = True
        Me.dentistes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.dentistes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dentistes.Location = New System.Drawing.Point(162, 12)
        Me.dentistes.Name = "dentistes"
        Me.dentistes.Size = New System.Drawing.Size(83, 20)
        Me.dentistes.TabIndex = 2
        Me.dentistes.TabStop = True
        Me.dentistes.Text = "Dentiste"
        Me.dentistes.UseVisualStyleBackColor = False
        '
        'valider
        '
        Me.valider.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valider.Location = New System.Drawing.Point(12, 330)
        Me.valider.Name = "valider"
        Me.valider.Size = New System.Drawing.Size(147, 44)
        Me.valider.TabIndex = 3
        Me.valider.Text = "Valider"
        Me.valider.UseVisualStyleBackColor = False
        '
        'Stocks
        '
        Me.Stocks.AutoSize = True
        Me.Stocks.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Stocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stocks.Location = New System.Drawing.Point(273, 12)
        Me.Stocks.Name = "Stocks"
        Me.Stocks.Size = New System.Drawing.Size(65, 20)
        Me.Stocks.TabIndex = 4
        Me.Stocks.TabStop = True
        Me.Stocks.Text = "Stock"
        Me.Stocks.UseVisualStyleBackColor = False
        '
        'av
        '
        Me.av.AutoSize = True
        Me.av.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.av.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.av.Location = New System.Drawing.Point(469, 12)
        Me.av.Name = "av"
        Me.av.Size = New System.Drawing.Size(62, 20)
        Me.av.TabIndex = 5
        Me.av.TabStop = True
        Me.av.Text = "Avoir"
        Me.av.UseVisualStyleBackColor = False
        '
        'rend
        '
        Me.rend.AutoSize = True
        Me.rend.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rend.Location = New System.Drawing.Point(545, 12)
        Me.rend.Name = "rend"
        Me.rend.Size = New System.Drawing.Size(115, 20)
        Me.rend.TabIndex = 6
        Me.rend.TabStop = True
        Me.rend.Text = "rendez-vous "
        Me.rend.UseVisualStyleBackColor = False
        '
        'employee
        '
        Me.employee.AutoSize = True
        Me.employee.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee.Location = New System.Drawing.Point(666, 12)
        Me.employee.Name = "employee"
        Me.employee.Size = New System.Drawing.Size(87, 20)
        Me.employee.TabIndex = 7
        Me.employee.TabStop = True
        Me.employee.Text = "Employe"
        Me.employee.UseVisualStyleBackColor = False
        '
        'traitementt
        '
        Me.traitementt.AutoSize = True
        Me.traitementt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.traitementt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.traitementt.Location = New System.Drawing.Point(759, 12)
        Me.traitementt.Name = "traitementt"
        Me.traitementt.Size = New System.Drawing.Size(94, 20)
        Me.traitementt.TabIndex = 8
        Me.traitementt.TabStop = True
        Me.traitementt.Text = "traitement"
        Me.traitementt.UseVisualStyleBackColor = False
        '
        'panelutilisateur
        '
        Me.panelutilisateur.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelutilisateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelutilisateur.Controls.Add(Me.Label7)
        Me.panelutilisateur.Controls.Add(Me.cptutilisateur)
        Me.panelutilisateur.Location = New System.Drawing.Point(694, 78)
        Me.panelutilisateur.Margin = New System.Windows.Forms.Padding(2)
        Me.panelutilisateur.Name = "panelutilisateur"
        Me.panelutilisateur.Size = New System.Drawing.Size(157, 63)
        Me.panelutilisateur.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 42)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "rendez-vous"
        '
        'cptutilisateur
        '
        Me.cptutilisateur.AutoSize = True
        Me.cptutilisateur.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cptutilisateur.Location = New System.Drawing.Point(2, 8)
        Me.cptutilisateur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cptutilisateur.Name = "cptutilisateur"
        Me.cptutilisateur.Size = New System.Drawing.Size(29, 31)
        Me.cptutilisateur.TabIndex = 23
        Me.cptutilisateur.Text = "3"
        '
        'panelpointage
        '
        Me.panelpointage.BackColor = System.Drawing.Color.Silver
        Me.panelpointage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpointage.Controls.Add(Me.Label4)
        Me.panelpointage.Controls.Add(Me.cptpointage)
        Me.panelpointage.Location = New System.Drawing.Point(523, 78)
        Me.panelpointage.Margin = New System.Windows.Forms.Padding(2)
        Me.panelpointage.Name = "panelpointage"
        Me.panelpointage.Size = New System.Drawing.Size(157, 63)
        Me.panelpointage.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 42)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Specialite"
        '
        'cptpointage
        '
        Me.cptpointage.AutoSize = True
        Me.cptpointage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cptpointage.Location = New System.Drawing.Point(2, 8)
        Me.cptpointage.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cptpointage.Name = "cptpointage"
        Me.cptpointage.Size = New System.Drawing.Size(44, 31)
        Me.cptpointage.TabIndex = 23
        Me.cptpointage.Text = "10"
        '
        'panelaffectation
        '
        Me.panelaffectation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelaffectation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelaffectation.Controls.Add(Me.Label3)
        Me.panelaffectation.Controls.Add(Me.cptaffectation)
        Me.panelaffectation.Location = New System.Drawing.Point(353, 78)
        Me.panelaffectation.Margin = New System.Windows.Forms.Padding(2)
        Me.panelaffectation.Name = "panelaffectation"
        Me.panelaffectation.Size = New System.Drawing.Size(157, 63)
        Me.panelaffectation.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Patient"
        '
        'cptaffectation
        '
        Me.cptaffectation.AutoSize = True
        Me.cptaffectation.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cptaffectation.Location = New System.Drawing.Point(2, 8)
        Me.cptaffectation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cptaffectation.Name = "cptaffectation"
        Me.cptaffectation.Size = New System.Drawing.Size(29, 31)
        Me.cptaffectation.TabIndex = 23
        Me.cptaffectation.Text = "5"
        '
        'panelemploye
        '
        Me.panelemploye.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelemploye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelemploye.Controls.Add(Me.Label2)
        Me.panelemploye.Controls.Add(Me.cptemploye)
        Me.panelemploye.Location = New System.Drawing.Point(181, 78)
        Me.panelemploye.Margin = New System.Windows.Forms.Padding(2)
        Me.panelemploye.Name = "panelemploye"
        Me.panelemploye.Size = New System.Drawing.Size(157, 63)
        Me.panelemploye.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 40)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Stock"
        '
        'cptemploye
        '
        Me.cptemploye.AutoSize = True
        Me.cptemploye.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cptemploye.Location = New System.Drawing.Point(2, 8)
        Me.cptemploye.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cptemploye.Name = "cptemploye"
        Me.cptemploye.Size = New System.Drawing.Size(29, 31)
        Me.cptemploye.TabIndex = 23
        Me.cptemploye.Text = "4"
        '
        'panelservice
        '
        Me.panelservice.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.panelservice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelservice.Controls.Add(Me.Label1)
        Me.panelservice.Controls.Add(Me.cptservice)
        Me.panelservice.Location = New System.Drawing.Point(11, 78)
        Me.panelservice.Margin = New System.Windows.Forms.Padding(2)
        Me.panelservice.Name = "panelservice"
        Me.panelservice.Size = New System.Drawing.Size(157, 63)
        Me.panelservice.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Dentiste"
        '
        'cptservice
        '
        Me.cptservice.AutoSize = True
        Me.cptservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cptservice.Location = New System.Drawing.Point(6, 10)
        Me.cptservice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cptservice.Name = "cptservice"
        Me.cptservice.Size = New System.Drawing.Size(29, 31)
        Me.cptservice.TabIndex = 23
        Me.cptservice.Text = "6"
        '
        'cabinet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.cabinet.My.Resources.Resources.pexels_andrea_piacquadio_3952008
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(858, 386)
        Me.Controls.Add(Me.panelutilisateur)
        Me.Controls.Add(Me.panelpointage)
        Me.Controls.Add(Me.panelaffectation)
        Me.Controls.Add(Me.panelemploye)
        Me.Controls.Add(Me.panelservice)
        Me.Controls.Add(Me.traitementt)
        Me.Controls.Add(Me.employee)
        Me.Controls.Add(Me.rend)
        Me.Controls.Add(Me.av)
        Me.Controls.Add(Me.Stocks)
        Me.Controls.Add(Me.valider)
        Me.Controls.Add(Me.dentistes)
        Me.Controls.Add(Me.specialite)
        Me.Controls.Add(Me.patient)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "cabinet"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "cabinet"
        Me.panelutilisateur.ResumeLayout(False)
        Me.panelutilisateur.PerformLayout()
        Me.panelpointage.ResumeLayout(False)
        Me.panelpointage.PerformLayout()
        Me.panelaffectation.ResumeLayout(False)
        Me.panelaffectation.PerformLayout()
        Me.panelemploye.ResumeLayout(False)
        Me.panelemploye.PerformLayout()
        Me.panelservice.ResumeLayout(False)
        Me.panelservice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents patient As System.Windows.Forms.RadioButton
    Friend WithEvents specialite As System.Windows.Forms.RadioButton
    Friend WithEvents dentistes As System.Windows.Forms.RadioButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents valider As System.Windows.Forms.Button
    Friend WithEvents Stocks As System.Windows.Forms.RadioButton
    Friend WithEvents av As System.Windows.Forms.RadioButton
    Friend WithEvents rend As System.Windows.Forms.RadioButton
    Friend WithEvents employee As System.Windows.Forms.RadioButton
    Friend WithEvents traitementt As System.Windows.Forms.RadioButton
    Friend WithEvents panelutilisateur As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cptutilisateur As System.Windows.Forms.Label
    Friend WithEvents panelpointage As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cptpointage As System.Windows.Forms.Label
    Friend WithEvents panelaffectation As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cptaffectation As System.Windows.Forms.Label
    Friend WithEvents panelemploye As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cptemploye As System.Windows.Forms.Label
    Friend WithEvents panelservice As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cptservice As System.Windows.Forms.Label
End Class
