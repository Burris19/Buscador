Public Class frmBuscador
#Region "Variables"
    Private listaImagenes As New List(Of Bitmap)()
    Dim valorBuscado As String
    Dim codigoPdf As Integer
#End Region

#Region "Eventos"
    Private Sub txtCampo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCampo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            valorBuscado = txtCampo.Text
            buscar(valorBuscado)
        End If
    End Sub
#End Region
#Region "Funciones"
    Public Sub buscar(ByVal valor As String)
        listaImagenes.Clear()
        listadoResultado.Rows.Clear()
        If valor = "animales salvajes" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.animales_salvajes)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 1)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "animales domesticos" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.animales_domesticos)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 2)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "cinco sentidos" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.cinco_sentidos)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 3)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "escuela" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.escuela)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 4)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "frutas" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.frutas)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 5)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "sistema nervioso" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.sistemas)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 6)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "verduras" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.verduras)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 7)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "vocal" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.vocales)
            bmp.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)

            Me.listadoResultado.Rows.Add(listaImagenes(0), 8)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill

        ElseIf valor = "animales" Then
            Me.listadoResultado.MasterTemplate.EnableSorting = True
            Me.listadoResultado.TableElement.RowHeight = 310
            Dim bmp As New Bitmap(My.Resources.animales_salvajes)
            Dim bmp1 As New Bitmap(My.Resources.animales_domesticos)
            bmp.MakeTransparent(Color.Magenta)
            bmp1.MakeTransparent(Color.Magenta)
            listaImagenes.Add(bmp)
            listaImagenes.Add(bmp1)
            Me.listadoResultado.Rows.Add(listaImagenes(0), 1)
            Me.listadoResultado.Rows.Add(listaImagenes(1), 2)
            listadoResultado.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Else
            listadoResultado.Rows.Clear()
        End If
    End Sub
#End Region
    

    

    Private Sub listadoResultado_CellDoubleClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles listadoResultado.CellDoubleClick
        codigoPdf = CInt(listadoResultado.Rows(e.RowIndex).Cells("codigo").Value)
        MessageBox.Show(codigoPdf)


    End Sub




End Class
