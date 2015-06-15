<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Busquerda_vb
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Busquerda_vb))
        Dim GridViewImageColumn2 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New Telerik.WinControls.UI.RadButton()
        Me.txtCampo = New Telerik.WinControls.UI.RadTextBox()
        Me.listadoResultado = New Telerik.WinControls.UI.RadGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoResultado.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Buscador.My.Resources.Resources.creativa
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        resources.ApplyResources(Me.btnBuscar, "btnBuscar")
        Me.btnBuscar.Name = "btnBuscar"
        '
        'txtCampo
        '
        resources.ApplyResources(Me.txtCampo, "txtCampo")
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.ThemeName = "ControlDefault"
        '
        'listadoResultado
        '
        Me.listadoResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listadoResultado.Cursor = System.Windows.Forms.Cursors.Default
        Me.listadoResultado.EnableHotTracking = False
        resources.ApplyResources(Me.listadoResultado, "listadoResultado")
        Me.listadoResultado.ForeColor = System.Drawing.Color.Black
        '
        'listadoResultado
        '
        Me.listadoResultado.MasterTemplate.AllowAddNewRow = False
        GridViewImageColumn2.EnableExpressionEditor = False
        resources.ApplyResources(GridViewImageColumn2, "GridViewImageColumn2")
        GridViewImageColumn2.Name = "imagen"
        GridViewImageColumn2.Width = 569
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        resources.ApplyResources(GridViewTextBoxColumn2, "GridViewTextBoxColumn2")
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "codigo"
        Me.listadoResultado.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewImageColumn2, GridViewTextBoxColumn2})
        Me.listadoResultado.MasterTemplate.ShowColumnHeaders = False
        Me.listadoResultado.MasterTemplate.ShowRowHeaderColumn = False
        Me.listadoResultado.Name = "listadoResultado"
        Me.listadoResultado.ReadOnly = True
        Me.listadoResultado.ShowGroupPanel = False
        '
        'Menu_Busquerda_vb
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.listadoResultado)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu_Busquerda_vb"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoResultado.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscar As Telerik.WinControls.UI.RadButton
    Friend WithEvents txtCampo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents listadoResultado As Telerik.WinControls.UI.RadGridView
End Class

