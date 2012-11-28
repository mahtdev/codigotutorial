Imports Microsoft.Office.Interop.Word 'control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document

        MsgBox("El TDR se guardará en : C:\Users\afgarcia\Desktop\documento de salida.docx")
        FileCopy("C:\plantilla video.docx", "C:\Users\afgarcia\Desktop\documento de salida.docx")
        Documento = MSWord.Documents.Open("C:\Users\afgarcia\Desktop\documento de salida.docx")

        Documento.Bookmarks.Item("nombre").Range.Text = txtnombre.Text
        'Documento.Bookmarks.Item("apellido").Range.Text = txtapellido.Text
        Documento.Bookmarks.Item("direccion").Range.Text = txtdireccion.Text
        Documento.Bookmarks.Item("correo").Range.Text = txtcorreo.Text()
        Documento.Bookmarks.Item("telefono").Range.Text = txttelefono.Text

        Documento.Save()
        MSWord.Visible = True
    End Sub
End Class
