Imports System.Data.SQLite
Public Class frmMenu
#Region "Variables"
    Dim MyImage As Bitmap
    Dim lst As ListViewItem
    Dim valorBuscado As String
    Dim subCadena As String
    Dim connectionString As String = "Data Source=C:\SearchImagen\Project\DataBase\buscador.db"
    Dim query As String
    Dim dt As DataTable = Nothing
    Dim ds As New DataSet
    Dim urlImagen As String
    Dim urlPdf As String
    Dim descripcion As String
    Dim posicionImagen As Integer = 0
    Dim idCategoria As Integer
#End Region
#Region "Funciones"
    Public Sub buscarValor(ByVal valor As String)
        query = "select l.url_imagen, l.url_pdf, l.descripcion "
        query = query & "from laminas l "
        query = query & "inner join categorias c on l.id_categoria = c.id "
        query = query & "left join sub_laminas s on s.id_lamina = l.id "
        query = query & "where l.descripcion like '" & valor & "%' or c.descripcion like '" & valor & "%' or s.descripcion like '" & valor & "%'  group by l.descripcion"

        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(query, con)
                    con.Open()

                    Dim reader As SQLiteDataReader = cmd.ExecuteReader
                    posicionImagen = 0
                    vectorImagenes.Images.Clear()
                    While reader.Read

                        urlImagen = "C:\SearchImagen\Project\Preview\" & reader(0) & ""
                        urlPdf = reader(1)
                        descripcion = reader(2)

                        MyImage = New Bitmap(urlImagen)
                        MyImage.MakeTransparent(Color.Magenta)
                        vectorImagenes.Images.Add(MyImage)

                        ListView1.View = View.LargeIcon
                        lst = ListView1.Items.Add(urlPdf, descripcion, posicionImagen)
                        lst.SubItems.Add(posicionImagen)

                        posicionImagen = posicionImagen + 1

                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub cargarCategorias()
        Dim mSQL As String = "select id,descripcion from categorias"
        Dim dt As DataTable = Nothing
        Dim ds As New DataSet
        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(mSQL, con)
                    con.Open()
                    Using da As New SQLiteDataAdapter(cmd)
                        da.Fill(ds)
                        dt = ds.Tables(0)
                    End Using
                End Using
            End Using
            listadoCategorias.ValueMember = "id"
            listadoCategorias.DisplayMember = "descripcion"
            listadoCategorias.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub cargarCategorias(ByVal idCategoria As Integer)
        ListView1.Clear()
        query = "select l.url_imagen, l.url_pdf, l.descripcion "
        query = query & "from laminas l "
        query = query & "inner join categorias c on l.id_categoria = c.id "
        query = query & "where c.id = " & idCategoria
        Try
            Using con As New SQLiteConnection(connectionString)
                Using cmd As New SQLiteCommand(query, con)
                    con.Open()

                    Dim reader As SQLiteDataReader = cmd.ExecuteReader
                    posicionImagen = 0
                    vectorImagenes.Images.Clear()
                    While reader.Read

                        urlImagen = "C:\SearchImagen\Project\Preview\" & reader(0) & ""
                        urlPdf = reader(1)
                        descripcion = reader(2)

                        MyImage = New Bitmap(urlImagen)
                        MyImage.MakeTransparent(Color.Magenta)
                        vectorImagenes.Images.Add(MyImage)

                        ListView1.View = View.LargeIcon
                        lst = ListView1.Items.Add(urlPdf, descripcion, posicionImagen)
                        lst.SubItems.Add(posicionImagen)

                        posicionImagen = posicionImagen + 1

                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Eventos"
    Private Sub txtBuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscador.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ListView1.Clear()
            AdobePdf.Visible = False
            ListView1.Visible = True
            valorBuscado = txtBuscador.Text.Trim
            If valorBuscado.Length > 2 Then
                subCadena = valorBuscado.Substring(0, 3)
                buscarValor(subCadena)
            End If
        End If
    End Sub
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AdobePdf.Visible = False
        cargarCategorias()
        ListView1.Clear()
    End Sub
    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim i As ListViewItem
        i = ListView1.SelectedItems(0)
        ListView1.Visible = False
        AdobePdf.Visible = True
        Dim archivo As String = "C:\SearchImagen\Project\Pdfs\" & i.Name
        AdobePdf.src = archivo
    End Sub
    Private Sub listadoCategorias_SelectedIndexChanged(sender As Object, e As Telerik.WinControls.UI.Data.PositionChangedEventArgs) Handles listadoCategorias.SelectedIndexChanged
        ListView1.Clear()
        AdobePdf.Visible = False
        ListView1.Visible = True
        idCategoria = listadoCategorias.SelectedValue
        cargarCategorias(idCategoria)
    End Sub

#End Region

   
End Class
