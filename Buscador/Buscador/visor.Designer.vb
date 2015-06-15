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
        Me.RadPdfViewerNavigator1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
        Me.pdfview = New Telerik.WinControls.UI.RadPdfViewer()
        CType(Me.RadPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pdfview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPdfViewerNavigator1
        '
        Me.RadPdfViewerNavigator1.AssociatedViewer = Me.pdfview
        Me.RadPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPdfViewerNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.RadPdfViewerNavigator1.Name = "RadPdfViewerNavigator1"
        Me.RadPdfViewerNavigator1.Size = New System.Drawing.Size(781, 38)
        Me.RadPdfViewerNavigator1.TabIndex = 1
        Me.RadPdfViewerNavigator1.Text = "RadPdfViewerNavigator1"
        '
        'pdfview
        '
        Me.pdfview.Location = New System.Drawing.Point(3, 44)
        Me.pdfview.Name = "pdfview"
        Me.pdfview.Size = New System.Drawing.Size(778, 453)
        Me.pdfview.TabIndex = 2
        Me.pdfview.Text = "RadPdfViewer1"
        Me.pdfview.ThumbnailsScaleFactor = 0.15!
        '
        'Visor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 500)
        Me.Controls.Add(Me.pdfview)
        Me.Controls.Add(Me.RadPdfViewerNavigator1)
        Me.Name = "Visor"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor"
        CType(Me.RadPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pdfview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
    Friend WithEvents pdfview As Telerik.WinControls.UI.RadPdfViewer
End Class

