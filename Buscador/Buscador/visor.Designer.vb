<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visor
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
        Me.pdfView = New Telerik.WinControls.UI.RadPdfViewer()
        CType(Me.pdfView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pdfView
        '
        Me.pdfView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pdfView.Location = New System.Drawing.Point(0, 0)
        Me.pdfView.Name = "pdfView"
        Me.pdfView.Size = New System.Drawing.Size(781, 500)
        Me.pdfView.TabIndex = 0
        Me.pdfView.Text = "RadPdfViewer1"
        Me.pdfView.ThemeName = "ControlDefault"
        Me.pdfView.ThumbnailsScaleFactor = 0.15!
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 500)
        Me.Controls.Add(Me.pdfView)
        Me.Name = "Visor"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "Visor"
        CType(Me.pdfView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pdfView As Telerik.WinControls.UI.RadPdfViewer
End Class

