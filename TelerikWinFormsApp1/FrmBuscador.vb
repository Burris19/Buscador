Public Class FrmBuscador
    Dim MyImage As Bitmap
    Dim lst As ListViewItem


    Private Sub FrmBuscador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyImage = New Bitmap("C:\SearchImagen\preview\uno.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)

        MyImage = New Bitmap("C:\SearchImagen\preview\dos.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)


        MyImage = New Bitmap("C:\SearchImagen\preview\tres.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)


        MyImage = New Bitmap("C:\SearchImagen\preview\cuatro.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)


        MyImage = New Bitmap("C:\SearchImagen\preview\cinco.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)

        MyImage = New Bitmap("C:\SearchImagen\preview\seis.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)

        MyImage = New Bitmap("C:\SearchImagen\preview\siete.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)

        MyImage = New Bitmap("C:\SearchImagen\preview\ocho.png")
        MyImage.MakeTransparent(Color.Magenta)
        vectorImagenes.Images.Add(MyImage)

        ListView1.View = View.LargeIcon
        lst = ListView1.Items.Add("ocho", 7)
        lst.SubItems.Add("7")
        lst = ListView1.Items.Add("siete", 6)
        lst.SubItems.Add("6")
        lst = ListView1.Items.Add("seis", 5)
        lst.SubItems.Add("5")
        lst = ListView1.Items.Add("cinco", 4)
        lst.SubItems.Add("4")
        lst = ListView1.Items.Add("cuatro", 3)
        lst.SubItems.Add("3")
        lst = ListView1.Items.Add("tres", 2)
        lst.SubItems.Add("2")
        lst = ListView1.Items.Add("dos", 1)
        lst.SubItems.Add("1")
        lst = ListView1.Items.Add("uno", 0)
        lst.SubItems.Add("0")
    End Sub
End Class
