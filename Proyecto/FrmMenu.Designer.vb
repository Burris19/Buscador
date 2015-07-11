<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.listadoCategorias = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBuscador = New Telerik.WinControls.UI.RadTextBox()
        Me.TelerikMetroTheme2 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.vectorImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AdobePdf = New AxAcroPDFLib.AxAcroPDF()
        CType(Me.listadoCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdobePdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listadoCategorias
        '
        Me.listadoCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listadoCategorias.BackColor = System.Drawing.Color.Transparent
        Me.listadoCategorias.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.listadoCategorias.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listadoCategorias.Location = New System.Drawing.Point(958, 39)
        Me.listadoCategorias.Name = "listadoCategorias"
        Me.listadoCategorias.Size = New System.Drawing.Size(219, 27)
        Me.listadoCategorias.TabIndex = 18
        Me.listadoCategorias.Text = "Animales"
        Me.listadoCategorias.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(793, 41)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(159, 25)
        Me.RadLabel2.TabIndex = 17
        Me.RadLabel2.Text = "Seleccione Categoria"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Proyecto.My.Resources.Resources.creativa_2
        Me.PictureBox1.Image = Global.Proyecto.My.Resources.Resources.CREATIVA_GOOGLE
        Me.PictureBox1.Location = New System.Drawing.Point(423, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Calibri Light", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(65, 110)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(152, 67)
        Me.RadLabel1.TabIndex = 15
        Me.RadLabel1.Text = "Buscar"
        '
        'txtBuscador
        '
        Me.txtBuscador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscador.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(251, 122)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(648, 37)
        Me.txtBuscador.TabIndex = 14
        Me.txtBuscador.ThemeName = "VisualStudio2012Light"
        '
        'vectorImagenes
        '
        Me.vectorImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.vectorImagenes.ImageSize = New System.Drawing.Size(256, 256)
        Me.vectorImagenes.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackgroundImage = Global.Proyecto.My.Resources.Resources.fondolista
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.LargeImageList = Me.vectorImagenes
        Me.ListView1.Location = New System.Drawing.Point(52, 183)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1125, 432)
        Me.ListView1.SmallImageList = Me.vectorImagenes
        Me.ListView1.TabIndex = 19
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'AdobePdf
        '
        Me.AdobePdf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdobePdf.Enabled = True
        Me.AdobePdf.Location = New System.Drawing.Point(52, 183)
        Me.AdobePdf.Name = "AdobePdf"
        Me.AdobePdf.OcxState = CType(resources.GetObject("AdobePdf.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AdobePdf.Size = New System.Drawing.Size(1125, 410)
        Me.AdobePdf.TabIndex = 20
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Proyecto.My.Resources.Resources.Captura
        Me.ClientSize = New System.Drawing.Size(1243, 630)
        Me.Controls.Add(Me.AdobePdf)
        Me.Controls.Add(Me.listadoCategorias)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtBuscador)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmMenu"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = ""
        Me.ThemeName = "TelerikMetro"
        CType(Me.listadoCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdobePdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents listadoCategorias As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents txtBuscador As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TelerikMetroTheme2 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents vectorImagenes As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AdobePdf As AxAcroPDFLib.AxAcroPDF
End Class

