<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscador
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
        Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TelerikMetroTheme1 = New Telerik.WinControls.Themes.TelerikMetroTheme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.vectorImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.RadThemeManager1 = New Telerik.WinControls.RadThemeManager()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadTextBox1
        '
        Me.RadTextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTextBox1.Location = New System.Drawing.Point(286, 111)
        Me.RadTextBox1.Name = "RadTextBox1"
        Me.RadTextBox1.Size = New System.Drawing.Size(648, 37)
        Me.RadTextBox1.TabIndex = 0
        Me.RadTextBox1.ThemeName = "VisualStudio2012Light"
        '
        'RadLabel1
        '
        Me.RadLabel1.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel1.Font = New System.Drawing.Font("Calibri Light", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(100, 99)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(152, 67)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.creativa_2
        Me.PictureBox1.Location = New System.Drawing.Point(54, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadLabel2.BackColor = System.Drawing.Color.Transparent
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(719, 30)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(159, 25)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Seleccione Categoria"
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadDropDownList1.BackColor = System.Drawing.Color.Transparent
        Me.RadDropDownList1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadDropDownList1.Location = New System.Drawing.Point(884, 28)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.Size = New System.Drawing.Size(219, 27)
        Me.RadDropDownList1.TabIndex = 4
        Me.RadDropDownList1.Text = "Animales"
        Me.RadDropDownList1.ThemeName = "VisualStudio2012Light"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TelerikWinFormsApp1.My.Resources.Resources.lupa2
        Me.PictureBox2.Location = New System.Drawing.Point(381, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(86, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
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
        Me.ListView1.BackgroundImage = Global.TelerikWinFormsApp1.My.Resources.Resources.fondolista
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.LargeImageList = Me.vectorImagenes
        Me.ListView1.Location = New System.Drawing.Point(35, 176)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1068, 433)
        Me.ListView1.SmallImageList = Me.vectorImagenes
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'FrmBuscador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TelerikWinFormsApp1.My.Resources.Resources.Captura
        Me.ClientSize = New System.Drawing.Size(1134, 625)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.RadTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmBuscador"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "TelerikMetro"
        CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadTextBox1 As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents vectorImagenes As System.Windows.Forms.ImageList
    Friend WithEvents RadThemeManager1 As Telerik.WinControls.RadThemeManager
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class

