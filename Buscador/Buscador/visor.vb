Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Reflection
Imports System.IO
Public Class Visor

    Private Sub Visor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPdf("animales_domesticos.pdf")
    End Sub

    Public Sub cargarPdf(ByVal archivo As String)

        'MessageBox.Show(My.Application.Info.DirectoryPath)


        Dim path As String = My.Application.Info.DirectoryPath
        Dim pdffile As String = IO.Path.Combine(path, "animales_domesticos.pdf")
        Me.pdfView.LoadDocument(pdffile)
    End Sub



End Class
