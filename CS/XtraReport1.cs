using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Net;
using System.IO;

namespace WebApplication1
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void XtraReport1_DataSourceDemanded(object sender, EventArgs e)
        {
            string url = @"https://maps.googleapis.com/maps/api/staticmap?size=512x512&zoom=" + ZoomFactor.Value.ToString()+ "&amp;format=png&center=" + Latitude.Value.ToString() + "," + Longitude.Value.ToString() + "&zoom=12&size=700x700&maptype=" + format.Value.ToString();

            using (WebClient wc = new WebClient())
            {
                byte[] bc = wc.DownloadData(url);
                Bitmap bmp = null;
                using (Stream stream = new MemoryStream(bc))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    bmp = Bitmap.FromStream(stream) as Bitmap;
                }
                xrPictureBox1.Image = bmp;
            }


        }

    }
}
