<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrementDesPatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationDesInformationsPersonnellesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanificationDesRendezvousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RappelsAutomatiquesPourLesPatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraitementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuiviDesTraitementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuiviDesFournituresDentairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesNiveauxDeStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesCommandesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturationEtPaiementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉmissionDesFacturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuiviDesPaiementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesSpécialitésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesDentistesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesHorairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesCongésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesTâchesAssignéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistiquesEtRapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsSurLactivitéDuCabinetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RevenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParamètreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationDeLapplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.AgendaToolStripMenuItem, Me.TraitementToolStripMenuItem, Me.StocksToolStripMenuItem, Me.FacturationEtPaiementToolStripMenuItem, Me.EmployésToolStripMenuItem, Me.StatistiquesEtRapportsToolStripMenuItem, Me.ParamètreToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(866, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnregistrementDesPatientsToolStripMenuItem, Me.ConsultationDesInformationsPersonnellesToolStripMenuItem})
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(56, 22)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'EnregistrementDesPatientsToolStripMenuItem
        '
        Me.EnregistrementDesPatientsToolStripMenuItem.Name = "EnregistrementDesPatientsToolStripMenuItem"
        Me.EnregistrementDesPatientsToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.EnregistrementDesPatientsToolStripMenuItem.Text = "Enregistrement des patients"
        '
        'ConsultationDesInformationsPersonnellesToolStripMenuItem
        '
        Me.ConsultationDesInformationsPersonnellesToolStripMenuItem.Name = "ConsultationDesInformationsPersonnellesToolStripMenuItem"
        Me.ConsultationDesInformationsPersonnellesToolStripMenuItem.Size = New System.Drawing.Size(303, 22)
        Me.ConsultationDesInformationsPersonnellesToolStripMenuItem.Text = "Consultation des informations personnelles"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanificationDesRendezvousToolStripMenuItem, Me.RappelsAutomatiquesPourLesPatientsToolStripMenuItem})
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(60, 22)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'PlanificationDesRendezvousToolStripMenuItem
        '
        Me.PlanificationDesRendezvousToolStripMenuItem.Name = "PlanificationDesRendezvousToolStripMenuItem"
        Me.PlanificationDesRendezvousToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.PlanificationDesRendezvousToolStripMenuItem.Text = "Planification des rendez-vous"
        '
        'RappelsAutomatiquesPourLesPatientsToolStripMenuItem
        '
        Me.RappelsAutomatiquesPourLesPatientsToolStripMenuItem.Name = "RappelsAutomatiquesPourLesPatientsToolStripMenuItem"
        Me.RappelsAutomatiquesPourLesPatientsToolStripMenuItem.Size = New System.Drawing.Size(281, 22)
        Me.RappelsAutomatiquesPourLesPatientsToolStripMenuItem.Text = "Rappels automatiques pour les patients"
        '
        'TraitementToolStripMenuItem
        '
        Me.TraitementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuiviDesTraitementsToolStripMenuItem})
        Me.TraitementToolStripMenuItem.Name = "TraitementToolStripMenuItem"
        Me.TraitementToolStripMenuItem.Size = New System.Drawing.Size(75, 22)
        Me.TraitementToolStripMenuItem.Text = "Traitement"
        '
        'SuiviDesTraitementsToolStripMenuItem
        '
        Me.SuiviDesTraitementsToolStripMenuItem.Name = "SuiviDesTraitementsToolStripMenuItem"
        Me.SuiviDesTraitementsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SuiviDesTraitementsToolStripMenuItem.Text = "Suivi des traitements"
        '
        'StocksToolStripMenuItem
        '
        Me.StocksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuiviDesFournituresDentairesToolStripMenuItem, Me.GestionDesNiveauxDeStockToolStripMenuItem, Me.GestionDesCommandesToolStripMenuItem})
        Me.StocksToolStripMenuItem.Name = "StocksToolStripMenuItem"
        Me.StocksToolStripMenuItem.Size = New System.Drawing.Size(53, 22)
        Me.StocksToolStripMenuItem.Text = "Stocks"
        '
        'SuiviDesFournituresDentairesToolStripMenuItem
        '
        Me.SuiviDesFournituresDentairesToolStripMenuItem.Name = "SuiviDesFournituresDentairesToolStripMenuItem"
        Me.SuiviDesFournituresDentairesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.SuiviDesFournituresDentairesToolStripMenuItem.Text = "Suivi des fournitures dentaires"
        '
        'GestionDesNiveauxDeStockToolStripMenuItem
        '
        Me.GestionDesNiveauxDeStockToolStripMenuItem.Name = "GestionDesNiveauxDeStockToolStripMenuItem"
        Me.GestionDesNiveauxDeStockToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.GestionDesNiveauxDeStockToolStripMenuItem.Text = "Gestion des niveaux de stock"
        '
        'GestionDesCommandesToolStripMenuItem
        '
        Me.GestionDesCommandesToolStripMenuItem.Name = "GestionDesCommandesToolStripMenuItem"
        Me.GestionDesCommandesToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.GestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes"
        '
        'FacturationEtPaiementToolStripMenuItem
        '
        Me.FacturationEtPaiementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÉmissionDesFacturesToolStripMenuItem, Me.SuiviDesPaiementsToolStripMenuItem})
        Me.FacturationEtPaiementToolStripMenuItem.Name = "FacturationEtPaiementToolStripMenuItem"
        Me.FacturationEtPaiementToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FacturationEtPaiementToolStripMenuItem.Text = "Facturation et Paiement"
        '
        'ÉmissionDesFacturesToolStripMenuItem
        '
        Me.ÉmissionDesFacturesToolStripMenuItem.Name = "ÉmissionDesFacturesToolStripMenuItem"
        Me.ÉmissionDesFacturesToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ÉmissionDesFacturesToolStripMenuItem.Text = "Émission des factures"
        '
        'SuiviDesPaiementsToolStripMenuItem
        '
        Me.SuiviDesPaiementsToolStripMenuItem.Name = "SuiviDesPaiementsToolStripMenuItem"
        Me.SuiviDesPaiementsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.SuiviDesPaiementsToolStripMenuItem.Text = "Suivi des paiements"
        '
        'EmployésToolStripMenuItem
        '
        Me.EmployésToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesSpécialitésToolStripMenuItem, Me.GestionDesDentistesToolStripMenuItem, Me.GestionDesHorairesToolStripMenuItem, Me.GestionDesCongésToolStripMenuItem, Me.GestionDesTâchesAssignéesToolStripMenuItem})
        Me.EmployésToolStripMenuItem.Name = "EmployésToolStripMenuItem"
        Me.EmployésToolStripMenuItem.Size = New System.Drawing.Size(70, 22)
        Me.EmployésToolStripMenuItem.Text = "Employés"
        '
        'GestionDesSpécialitésToolStripMenuItem
        '
        Me.GestionDesSpécialitésToolStripMenuItem.Name = "GestionDesSpécialitésToolStripMenuItem"
        Me.GestionDesSpécialitésToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GestionDesSpécialitésToolStripMenuItem.Text = "Gestion des spécialités"
        '
        'GestionDesDentistesToolStripMenuItem
        '
        Me.GestionDesDentistesToolStripMenuItem.Name = "GestionDesDentistesToolStripMenuItem"
        Me.GestionDesDentistesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GestionDesDentistesToolStripMenuItem.Text = "Gestion des dentistes"
        '
        'GestionDesHorairesToolStripMenuItem
        '
        Me.GestionDesHorairesToolStripMenuItem.Name = "GestionDesHorairesToolStripMenuItem"
        Me.GestionDesHorairesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GestionDesHorairesToolStripMenuItem.Text = "Gestion des horaires"
        '
        'GestionDesCongésToolStripMenuItem
        '
        Me.GestionDesCongésToolStripMenuItem.Name = "GestionDesCongésToolStripMenuItem"
        Me.GestionDesCongésToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GestionDesCongésToolStripMenuItem.Text = "Gestion des congés"
        '
        'GestionDesTâchesAssignéesToolStripMenuItem
        '
        Me.GestionDesTâchesAssignéesToolStripMenuItem.Name = "GestionDesTâchesAssignéesToolStripMenuItem"
        Me.GestionDesTâchesAssignéesToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.GestionDesTâchesAssignéesToolStripMenuItem.Text = "Gestion des tâches assignées"
        '
        'StatistiquesEtRapportsToolStripMenuItem
        '
        Me.StatistiquesEtRapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RapportsSurLactivitéDuCabinetToolStripMenuItem, Me.RevenusToolStripMenuItem})
        Me.StatistiquesEtRapportsToolStripMenuItem.Name = "StatistiquesEtRapportsToolStripMenuItem"
        Me.StatistiquesEtRapportsToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.StatistiquesEtRapportsToolStripMenuItem.Text = "Statistiques et Rapports"
        '
        'RapportsSurLactivitéDuCabinetToolStripMenuItem
        '
        Me.RapportsSurLactivitéDuCabinetToolStripMenuItem.Name = "RapportsSurLactivitéDuCabinetToolStripMenuItem"
        Me.RapportsSurLactivitéDuCabinetToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.RapportsSurLactivitéDuCabinetToolStripMenuItem.Text = "Rapports sur l'activité du cabinet"
        '
        'RevenusToolStripMenuItem
        '
        Me.RevenusToolStripMenuItem.Name = "RevenusToolStripMenuItem"
        Me.RevenusToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.RevenusToolStripMenuItem.Text = "Revenus"
        '
        'ParamètreToolStripMenuItem
        '
        Me.ParamètreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesUtilisateursToolStripMenuItem, Me.ConfigurationDeLapplicationToolStripMenuItem})
        Me.ParamètreToolStripMenuItem.Name = "ParamètreToolStripMenuItem"
        Me.ParamètreToolStripMenuItem.Size = New System.Drawing.Size(73, 22)
        Me.ParamètreToolStripMenuItem.Text = "Paramètre"
        '
        'GestionDesUtilisateursToolStripMenuItem
        '
        Me.GestionDesUtilisateursToolStripMenuItem.Name = "GestionDesUtilisateursToolStripMenuItem"
        Me.GestionDesUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.GestionDesUtilisateursToolStripMenuItem.Text = "Gestion des utilisateurs"
        '
        'ConfigurationDeLapplicationToolStripMenuItem
        '
        Me.ConfigurationDeLapplicationToolStripMenuItem.Name = "ConfigurationDeLapplicationToolStripMenuItem"
        Me.ConfigurationDeLapplicationToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ConfigurationDeLapplicationToolStripMenuItem.Text = "Configuration de l’application"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 22)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 500)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "menu"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PatientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnregistrementDesPatientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultationDesInformationsPersonnellesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanificationDesRendezvousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RappelsAutomatiquesPourLesPatientsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraitementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuiviDesTraitementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuiviDesFournituresDentairesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesNiveauxDeStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesCommandesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturationEtPaiementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÉmissionDesFacturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuiviDesPaiementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesSpécialitésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesDentistesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesHorairesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesCongésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesTâchesAssignéesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatistiquesEtRapportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RapportsSurLactivitéDuCabinetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RevenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParamètreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesUtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigurationDeLapplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
