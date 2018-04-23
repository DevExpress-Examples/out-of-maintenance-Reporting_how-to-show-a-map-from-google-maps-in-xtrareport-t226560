Namespace WebApplication1
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim staticListLookUpSettings1 As New DevExpress.XtraReports.Parameters.StaticListLookUpSettings()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.format = New DevExpress.XtraReports.Parameters.Parameter()
            Me.Latitude = New DevExpress.XtraReports.Parameters.Parameter()
            Me.Longitude = New DevExpress.XtraReports.Parameters.Parameter()
            Me.ZoomFactor = New DevExpress.XtraReports.Parameters.Parameter()
            Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1, Me.xrPictureBox1})
            Me.Detail.HeightF = 418.8333F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold)
            Me.xrLabel1.FormattingRules.Add(Me.formattingRule1)
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(26.66667F, 345.5F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(569.1666F, 54.66666F)
            Me.xrLabel1.StylePriority.UseFont = False
            Me.xrLabel1.Text = "The Truth Is Out There..."
            Me.xrLabel1.Visible = False
            ' 
            ' xrPictureBox1
            ' 
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(26.66667F, 0F)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(569.1666F, 345.5F)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' format
            ' 
            Me.format.Description = "Map Type"
            staticListLookUpSettings1.FilterString = Nothing
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("terrain", "terrain"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("roadmap", "roadmap"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("satellite", "satellite"))
            staticListLookUpSettings1.LookUpValues.Add(New DevExpress.XtraReports.Parameters.LookUpValue("hybrid", "hybrid"))
            Me.format.LookUpSettings = staticListLookUpSettings1
            Me.format.Name = "format"
            Me.format.ValueInfo = "terrain"
            ' 
            ' Latitude
            ' 
            Me.Latitude.Description = "Latitude"
            Me.Latitude.Name = "Latitude"
            Me.Latitude.Type = GetType(Decimal)
            Me.Latitude.ValueInfo = "37.263056"
            ' 
            ' Longitude
            ' 
            Me.Longitude.Description = "Longitude"
            Me.Longitude.Name = "Longitude"
            Me.Longitude.Type = GetType(Decimal)
            Me.Longitude.ValueInfo = "-115.79302"
            ' 
            ' ZoomFactor
            ' 
            Me.ZoomFactor.Description = "Zoom Factor"
            Me.ZoomFactor.Name = "ZoomFactor"
            Me.ZoomFactor.Type = GetType(Integer)
            Me.ZoomFactor.ValueInfo = "12"
            ' 
            ' formattingRule1
            ' 
            Me.formattingRule1.Condition = "[Parameters.Latitude]> 37 && [Parameters.Latitude] < 38 &&[Parameters.Longitude]>" & "-116 && [Parameters.Longitude]<-115"
            ' 
            ' 
            ' 
            Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True
            Me.formattingRule1.Name = "formattingRule1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.format, Me.Latitude, Me.Longitude, Me.ZoomFactor})
            Me.Version = "14.2"
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private format As DevExpress.XtraReports.Parameters.Parameter
        Private Latitude As DevExpress.XtraReports.Parameters.Parameter
        Private Longitude As DevExpress.XtraReports.Parameters.Parameter
        Private ZoomFactor As DevExpress.XtraReports.Parameters.Parameter
        Private formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    End Class
End Namespace
