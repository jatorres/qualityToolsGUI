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
        Me.ProcesosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalizacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicosToolStripMenuItem, Me.AuditoriaToolStripMenuItem, Me.NovedadesToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.DocumentacionToolStripMenuItem, Me.EstadisticasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BasicosToolStripMenuItem
        '
        Me.BasicosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionEmpresaToolStripMenuItem, Me.InformacionAuditorToolStripMenuItem})
        Me.BasicosToolStripMenuItem.Name = "BasicosToolStripMenuItem"
        Me.BasicosToolStripMenuItem.Size = New System.Drawing.Size(155, 20)
        Me.BasicosToolStripMenuItem.Text = "Información organización"
        '
        'InformacionEmpresaToolStripMenuItem
        '
        Me.InformacionEmpresaToolStripMenuItem.Name = "InformacionEmpresaToolStripMenuItem"
        Me.InformacionEmpresaToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.InformacionEmpresaToolStripMenuItem.Text = "Informacion Empresa"
        '
        'InformacionAuditorToolStripMenuItem
        '
        Me.InformacionAuditorToolStripMenuItem.Name = "InformacionAuditorToolStripMenuItem"
        Me.InformacionAuditorToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.InformacionAuditorToolStripMenuItem.Text = "Informacion Auditor"
        '
        'AuditoriaToolStripMenuItem
        '
        Me.AuditoriaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RealizarToolStripMenuItem})
        Me.AuditoriaToolStripMenuItem.Name = "AuditoriaToolStripMenuItem"
        Me.AuditoriaToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AuditoriaToolStripMenuItem.Text = "Auditoria"
        '
        'RealizarToolStripMenuItem
        '
        Me.RealizarToolStripMenuItem.Name = "RealizarToolStripMenuItem"
        Me.RealizarToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RealizarToolStripMenuItem.Text = "Auditar organización"
        '
        'NovedadesToolStripMenuItem
        '
        Me.NovedadesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesosToolStripMenuItem, Me.TiposDeProcesosToolStripMenuItem, Me.ProcesosToolStripMenuItem1, Me.PersonalizacionToolStripMenuItem})
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
        'ProcesosToolStripMenuItem1
        '
        Me.ProcesosToolStripMenuItem1.Name = "ProcesosToolStripMenuItem1"
        Me.ProcesosToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ProcesosToolStripMenuItem1.Text = "Procesos"
        '
        'PersonalizacionToolStripMenuItem
        '
        Me.PersonalizacionToolStripMenuItem.Name = "PersonalizacionToolStripMenuItem"
        Me.PersonalizacionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PersonalizacionToolStripMenuItem.Text = "Personalizacion"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'DocumentacionToolStripMenuItem
        '
        Me.DocumentacionToolStripMenuItem.Name = "DocumentacionToolStripMenuItem"
        Me.DocumentacionToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.DocumentacionToolStripMenuItem.Text = "Documentacion"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 550)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(794, 22)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.qualityToolsGUI.My.Resources.Resources.logo_quality
        Me.PictureBox1.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'menuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "menuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BasicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionEmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionAuditorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NovedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeProcesosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcesosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PersonalizacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DocumentacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuditoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
