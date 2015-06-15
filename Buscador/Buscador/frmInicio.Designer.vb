<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.VisualStudio2012LightTheme1 = New Telerik.WinControls.Themes.VisualStudio2012LightTheme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.Windows7Theme1 = New Telerik.WinControls.Themes.Windows7Theme()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.TelerikMetroTouchTheme1 = New Telerik.WinControls.Themes.TelerikMetroTouchTheme()
        Me.TelerikMetroBlueTheme1 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.TelerikMetroBlueTheme2 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.TelerikMetroBlueTheme3 = New Telerik.WinControls.Themes.TelerikMetroBlueTheme()
        Me.Office2013LightTheme1 = New Telerik.WinControls.Themes.Office2013LightTheme()
        Me.Office2013DarkTheme1 = New Telerik.WinControls.Themes.Office2013DarkTheme()
        Me.Office2010SilverTheme1 = New Telerik.WinControls.Themes.Office2010SilverTheme()
        Me.Office2010BlueTheme1 = New Telerik.WinControls.Themes.Office2010BlueTheme()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.Office2007SilverTheme1 = New Telerik.WinControls.Themes.Office2007SilverTheme()
        Me.Office2007BlackTheme1 = New Telerik.WinControls.Themes.Office2007BlackTheme()
        Me.HighContrastBlackTheme1 = New Telerik.WinControls.Themes.HighContrastBlackTheme()
        Me.DesertTheme1 = New Telerik.WinControls.Themes.DesertTheme()
        Me.BreezeTheme1 = New Telerik.WinControls.Themes.BreezeTheme()
        Me.AquaTheme1 = New Telerik.WinControls.Themes.AquaTheme()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Buscador.My.Resources.Resources.logoPrincipal
        Me.PictureBox1.Location = New System.Drawing.Point(43, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(652, 327)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(43, 3)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(500, 71)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Escribe, busca  y listo .. !!"
        '
        'Timer1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(281, 429)
        Me.ProgressBar1.Maximum = 50
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(182, 20)
        Me.ProgressBar1.TabIndex = 3
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 475)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInicio"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ""
        Me.ThemeName = "ControlDefault"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TelerikMetroTheme1 As Telerik.WinControls.Themes.TelerikMetroTheme
    Friend WithEvents VisualStudio2012LightTheme1 As Telerik.WinControls.Themes.VisualStudio2012LightTheme
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents Windows7Theme1 As Telerik.WinControls.Themes.Windows7Theme
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents TelerikMetroTouchTheme1 As Telerik.WinControls.Themes.TelerikMetroTouchTheme
    Friend WithEvents TelerikMetroBlueTheme1 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents TelerikMetroBlueTheme2 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents TelerikMetroBlueTheme3 As Telerik.WinControls.Themes.TelerikMetroBlueTheme
    Friend WithEvents Office2013LightTheme1 As Telerik.WinControls.Themes.Office2013LightTheme
    Friend WithEvents Office2013DarkTheme1 As Telerik.WinControls.Themes.Office2013DarkTheme
    Friend WithEvents Office2010SilverTheme1 As Telerik.WinControls.Themes.Office2010SilverTheme
    Friend WithEvents Office2010BlueTheme1 As Telerik.WinControls.Themes.Office2010BlueTheme
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents Office2007SilverTheme1 As Telerik.WinControls.Themes.Office2007SilverTheme
    Friend WithEvents Office2007BlackTheme1 As Telerik.WinControls.Themes.Office2007BlackTheme
    Friend WithEvents HighContrastBlackTheme1 As Telerik.WinControls.Themes.HighContrastBlackTheme
    Friend WithEvents DesertTheme1 As Telerik.WinControls.Themes.DesertTheme
    Friend WithEvents BreezeTheme1 As Telerik.WinControls.Themes.BreezeTheme
    Friend WithEvents AquaTheme1 As Telerik.WinControls.Themes.AquaTheme
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class

