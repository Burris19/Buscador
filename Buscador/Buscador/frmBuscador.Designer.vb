<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscador
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
        Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.listadoResultado = New Telerik.WinControls.UI.RadGridView()
        Me.txtCampo = New Telerik.WinControls.UI.RadTextBox()
        Me.btnBuscar = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.listadoResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listadoResultado.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listadoResultado
        '
        Me.listadoResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.listadoResultado.Cursor = System.Windows.Forms.Cursors.Default
        Me.listadoResultado.EnableHotTracking = False
        Me.listadoResultado.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.listadoResultado.ForeColor = System.Drawing.Color.Black
        Me.listadoResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.listadoResultado.Location = New System.Drawing.Point(36, 92)
        '
        'listadoResultado
        '
        Me.listadoResultado.MasterTemplate.AllowAddNewRow = False
        GridViewImageColumn1.EnableExpressionEditor = False
        GridViewImageColumn1.HeaderText = "imagen"
        GridViewImageColumn1.Name = "imagen"
        GridViewImageColumn1.Width = 569
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "codigo"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "codigo"
        Me.listadoResultado.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewImageColumn1, GridViewTextBoxColumn1})
        Me.listadoResultado.MasterTemplate.ShowColumnHeaders = False
        Me.listadoResultado.MasterTemplate.ShowRowHeaderColumn = False
        Me.listadoResultado.Name = "listadoResultado"
        Me.listadoResultado.ReadOnly = True
        Me.listadoResultado.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.listadoResultado.ShowGroupPanel = False
        Me.listadoResultado.Size = New System.Drawing.Size(698, 419)
        Me.listadoResultado.TabIndex = 0
        Me.listadoResultado.Text = "RadGridView1"
        '
        'txtCampo
        '
        Me.txtCampo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampo.Location = New System.Drawing.Point(36, 55)
        Me.txtCampo.Name = "txtCampo"
        Me.txtCampo.Size = New System.Drawing.Size(549, 31)
        Me.txtCampo.TabIndex = 1
        Me.txtCampo.ThemeName = "ControlDefault"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(604, 55)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(130, 31)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Buscador.My.Resources.Resources.creativa_2
        Me.PictureBox1.Location = New System.Drawing.Point(36, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmBuscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 514)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCampo)
        Me.Controls.Add(Me.listadoResultado)
        Me.Name = "frmBuscador"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        CType(Me.listadoResultado.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listadoResultado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listadoResultado As Telerik.WinControls.UI.RadGridView
    Friend WithEvents txtCampo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents btnBuscar As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

