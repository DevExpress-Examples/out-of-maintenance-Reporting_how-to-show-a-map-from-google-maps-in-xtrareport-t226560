Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Net
Imports System.IO

Namespace WebApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraReport1_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
            Dim url As String = "https://maps.googleapis.com/maps/api/staticmap?size=512x512&zoom=" & ZoomFactor.Value.ToString() & "&amp;format=png&center=" & Latitude.Value.ToString() & "," & Longitude.Value.ToString() & "&zoom=12&size=700x700&maptype=" & format.Value.ToString()

            Using wc As New WebClient()
                Dim bc() As Byte = wc.DownloadData(url)
                Dim bmp As Bitmap = Nothing
                Using stream As Stream = New MemoryStream(bc)
                    stream.Seek(0, SeekOrigin.Begin)
                    bmp = TryCast(Bitmap.FromStream(stream), Bitmap)
                End Using
                xrPictureBox1.Image = bmp
            End Using


        End Sub

    End Class
End Namespace
