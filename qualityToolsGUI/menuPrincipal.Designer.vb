<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BasicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionAuditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuditoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecomendacionesParaDocumentarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DiagramasCasosDeUsoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowMerge = False
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicosToolStripMenuItem, Me.AuditoriaToolStripMenuItem, Me.NovedadesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.DocumentacionToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(654, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "Menú opciones"
        '
        'BasicosToolStripMenuItem
        '
        Me.BasicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionEmpresaToolStripMenuItem, Me.InformacionAuditorToolStripMenuItem})
        Me.BasicosToolStripMenuItem.Name = "BasicosToolStripMenuItem"
        Me.BasicosToolStripMenuItem.Size = New System.Drawing.Size(147, 20)
        Me.BasicosToolStripMenuItem.Text = "Información Finac S.A.S."
        '
        'InformacionEmpresaToolStripMenuItem
        '
        Me.InformacionEmpresaToolStripMenuItem.Name = "InformacionEmpresaToolStripMenuItem"
        Me.InformacionEmpresaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformacionEmpresaToolStripMenuItem.Text = "Finac S.A.S."
        '
        'InformacionAuditorToolStripMenuItem
        '
        Me.InformacionAuditorToolStripMenuItem.Name = "InformacionAuditorToolStripMenuItem"
        Me.InformacionAuditorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InformacionAuditorToolStripMenuItem.Text = "Información auditor"
        '
        'AuditoriaToolStripMenuItem
        '
        Me.AuditoriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarToolStripMenuItem})
        Me.AuditoriaToolStripMenuItem.Name = "AuditoriaToolStripMenuItem"
        Me.AuditoriaToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AuditoriaToolStripMenuItem.Text = "Auditoría"
        '
        'RealizarToolStripMenuItem
        '
        Me.RealizarToolStripMenuItem.Name = "RealizarToolStripMenuItem"
        Me.RealizarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RealizarToolStripMenuItem.Text = "Auditar organización"
        '
        'NovedadesToolStripMenuItem
        '
        Me.NovedadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesosToolStripMenuItem, Me.TiposDeProcesosToolStripMenuItem})
        Me.NovedadesToolStripMenuItem.Name = "NovedadesToolStripMenuItem"
        Me.NovedadesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.NovedadesToolStripMenuItem.Text = "Procesos"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ProcesosToolStripMenuItem.Text = "Mapa de procesos"
        '
        'TiposDeProcesosToolStripMenuItem
        '
        Me.TiposDeProcesosToolStripMenuItem.Name = "TiposDeProcesosToolStripMenuItem"
        Me.TiposDeProcesosToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TiposDeProcesosToolStripMenuItem.Text = "Nuevo Proceso"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecomendacionesParaDocumentarToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'RecomendacionesParaDocumentarToolStripMenuItem
        '
        Me.RecomendacionesParaDocumentarToolStripMenuItem.Name = "RecomendacionesParaDocumentarToolStripMenuItem"
        Me.RecomendacionesParaDocumentarToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.RecomendacionesParaDocumentarToolStripMenuItem.Text = "Reporte de auditoría"
        '
        'DocumentacionToolStripMenuItem
        '
        Me.DocumentacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DiagramasCasosDeUsoToolStripMenuItem})
        Me.DocumentacionToolStripMenuItem.Name = "DocumentacionToolStripMenuItem"
        Me.DocumentacionToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.DocumentacionToolStripMenuItem.Text = "Documentación"
        '
        'DiagramasCasosDeUsoToolStripMenuItem
        '
        Me.DiagramasCasosDeUsoToolStripMenuItem.Name = "DiagramasCasosDeUsoToolStripMenuItem"
        Me.DiagramasCasosDeUsoToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.DiagramasCasosDeUsoToolStripMenuItem.Text = "Recomendaciones para documentar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 547)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(654, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(77, 17)
        Me.ToolStripStatusLabel1.Text = "Quality Tools"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(167, 17)
        Me.ToolStripStatusLabel2.Text = "                                        Usuario"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(151, 17)
        Me.ToolStripStatusLabel3.Text = "                                       Perfil"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "d-MM-yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(523, 549)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'menuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.qualityToolsGUI.My.Resources.Resources.fondoContenedor
        Me.ClientSize = New System.Drawing.Size(654, 569)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "menuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BasicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionEmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionAuditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NovedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuditoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DiagramasCasosDeUsoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecomendacionesParaDocumentarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
