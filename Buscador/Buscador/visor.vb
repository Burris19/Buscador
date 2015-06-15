Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Reflection
Imports System.IO
Public Class Visor
    Public archivo As String = "animales_domesticos.pdf"
    Private Sub Visor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPdf(archivo)
    End Sub

    Public Sub cargarPdf(ByVal archivo As String)
        Dim path As String = My.Application.Info.DirectoryPath
        Dim pdffile As String = IO.Path.Combine(path, archivo)
        Me.pdfview.LoadDocument(pdffile)
    End Sub

  

End Class
