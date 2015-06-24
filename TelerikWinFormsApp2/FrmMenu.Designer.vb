<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.listadoCategorias = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.txtBuscador = New Telerik.WinControls.UI.RadTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.vectorImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadPdfViewerNavigator1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
        Me.VisorPdf = New Telerik.WinControls.UI.RadPdfViewer()
        Me.PanelPdf = New Telerik.WinControls.UI.RadPanel()
        CType(Me.listadoCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBuscador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisorPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPdf.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listadoCategorias
        '
        Me.listadoCategorias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listadoCategorias.BackColor = System.Drawing.Color.Transparent
        Me.listadoCategorias.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.listadoCategorias.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listadoCategorias.Location = New System.Drawing.Point(887, 28)
        Me.listadoCategorias.Name = "listadoCategorias"
        Me.listadoCategorias.Size = New System.Drawing.Size(219, 27)
        Me.listadoCategorias.TabIndex = 10
        Me.listadoCategorias.Text = "Animales"
        Me.listadoCategorias.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(722, 30)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(159, 25)
        Me.RadLabel2.TabIndex = 9
        Me.RadLabel2.Text = "Seleccione Categoria"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Calibri Light", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(65, 99)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(152, 67)
        Me.RadLabel1.TabIndex = 7
        Me.RadLabel1.Text = "Buscar"
        '
        'txtBuscador
        '
        Me.txtBuscador.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscador.Location = New System.Drawing.Point(251, 111)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(648, 37)
        Me.txtBuscador.TabIndex = 6
        Me.txtBuscador.ThemeName = "VisualStudio2012Light"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TelerikWinFormsApp2.My.Resources.Resources.creativa_2
        Me.PictureBox1.Location = New System.Drawing.Point(19, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'vectorImagenes
        '
        Me.vectorImagenes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.vectorImagenes.ImageSize = New System.Drawing.Size(200, 200)
        Me.vectorImagenes.TransparentColor = System.Drawing.Color.Transparent
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackgroundImage = Global.TelerikWinFormsApp2.My.Resources.Resources.fondolista
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.LargeImageList = Me.vectorImagenes
        Me.ListView1.Location = New System.Drawing.Point(48, 172)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1106, 433)
        Me.ListView1.SmallImageList = Me.vectorImagenes
        Me.ListView1.TabIndex = 12
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'RadPdfViewerNavigator1
        '
        Me.RadPdfViewerNavigator1.AssociatedViewer = Me.VisorPdf
        Me.RadPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPdfViewerNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.RadPdfViewerNavigator1.Name = "RadPdfViewerNavigator1"
        Me.RadPdfViewerNavigator1.Size = New System.Drawing.Size(1106, 433)
        Me.RadPdfViewerNavigator1.TabIndex = 1
        Me.RadPdfViewerNavigator1.Text = "RadPdfViewerNavigator1"
        Me.RadPdfViewerNavigator1.ThemeName = "VisualStudio2012Light"
        '
        'VisorPdf
        '
        Me.VisorPdf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorPdf.Location = New System.Drawing.Point(3, 33)
        Me.VisorPdf.Name = "VisorPdf"
        Me.VisorPdf.Size = New System.Drawing.Size(1100, 397)
        Me.VisorPdf.TabIndex = 0
        Me.VisorPdf.Text = "RadPdfViewer1"
        Me.VisorPdf.ThemeName = "VisualStudio2012Light"
        Me.VisorPdf.ThumbnailsScaleFactor = 0.15!
        '
        'PanelPdf
        '
        Me.PanelPdf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelPdf.Controls.Add(Me.RadPdfViewerNavigator1)
        Me.PanelPdf.Controls.Add(Me.VisorPdf)
        Me.PanelPdf.Location = New System.Drawing.Point(48, 172)
        Me.PanelPdf.Name = "PanelPdf"
        Me.PanelPdf.Size = New System.Drawing.Size(1106, 433)
        Me.PanelPdf.TabIndex = 13
        Me.PanelPdf.ThemeName = "VisualStudio2012Light"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TelerikWinFormsApp2.My.Resources.Resources.Captura
        Me.ClientSize = New System.Drawing.Size(1172, 625)
        Me.Controls.Add(Me.PanelPdf)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.listadoCategorias)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.txtBuscador)
        Me.Name = "FrmMenu"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RadForm1"
        Me.ThemeName = "TelerikMetro"
        CType(Me.listadoCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBuscador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisorPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelPdf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPdf.ResumeLayout(False)
        Me.PanelPdf.PerformLayout()
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
    Friend WithEvents vectorImagenes As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents RadPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
    Friend WithEvents VisorPdf As Telerik.WinControls.UI.RadPdfViewer
    Friend WithEvents PanelPdf As Telerik.WinControls.UI.RadPanel
End Class

