namespace WebApplication1
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.Parameters.StaticListLookUpSettings staticListLookUpSettings1 = new DevExpress.XtraReports.Parameters.StaticListLookUpSettings();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.format = new DevExpress.XtraReports.Parameters.Parameter();
            this.Latitude = new DevExpress.XtraReports.Parameters.Parameter();
            this.Longitude = new DevExpress.XtraReports.Parameters.Parameter();
            this.ZoomFactor = new DevExpress.XtraReports.Parameters.Parameter();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrPictureBox1});
            this.Detail.HeightF = 418.8333F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.FormattingRules.Add(this.formattingRule1);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(26.66667F, 345.5F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(569.1666F, 54.66666F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.Text = "The Truth Is Out There...";
            this.xrLabel1.Visible = false;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(26.66667F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(569.1666F, 345.5F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // format
            // 
            this.format.Description = "Map Type";
            staticListLookUpSettings1.FilterString = null;
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("terrain", "terrain"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("roadmap", "roadmap"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("satellite", "satellite"));
            staticListLookUpSettings1.LookUpValues.Add(new DevExpress.XtraReports.Parameters.LookUpValue("hybrid", "hybrid"));
            this.format.LookUpSettings = staticListLookUpSettings1;
            this.format.Name = "format";
            this.format.ValueInfo = "terrain";
            // 
            // Latitude
            // 
            this.Latitude.Description = "Latitude";
            this.Latitude.Name = "Latitude";
            this.Latitude.Type = typeof(decimal);
            this.Latitude.ValueInfo = "37.263056";
            // 
            // Longitude
            // 
            this.Longitude.Description = "Longitude";
            this.Longitude.Name = "Longitude";
            this.Longitude.Type = typeof(decimal);
            this.Longitude.ValueInfo = "-115.79302";
            // 
            // ZoomFactor
            // 
            this.ZoomFactor.Description = "Zoom Factor";
            this.ZoomFactor.Name = "ZoomFactor";
            this.ZoomFactor.Type = typeof(int);
            this.ZoomFactor.ValueInfo = "12";
            // 
            // formattingRule1
            // 
            this.formattingRule1.Condition = "[Parameters.Latitude]> 37 && [Parameters.Latitude] < 38 &&[Parameters.Longitude]>" +
    "-116 && [Parameters.Longitude]<-115";
            // 
            // 
            // 
            this.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.formattingRule1.Name = "formattingRule1";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.format,
            this.Latitude,
            this.Longitude,
            this.ZoomFactor});
            this.Version = "14.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.XtraReport1_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.Parameters.Parameter format;
        private DevExpress.XtraReports.Parameters.Parameter Latitude;
        private DevExpress.XtraReports.Parameters.Parameter Longitude;
        private DevExpress.XtraReports.Parameters.Parameter ZoomFactor;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
    }
}
