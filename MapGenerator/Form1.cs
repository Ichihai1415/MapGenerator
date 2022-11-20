using MapGenerator.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MapGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gen_Click(object sender, EventArgs e)
        {
            double Latitude = (double)Lat.Value;
            double Longitude = (double)Long.Value;
            double Zoom = (double)this.Zoom.Value;
            Img.Size = new Size((int)Math.Round(4000 * Zoom, MidpointRounding.AwayFromZero), (int)Math.Round(3104 * Zoom, MidpointRounding.AwayFromZero));
            double Adjustment = 250;
            int x = (int)Math.Round((Longitude - 115) * -88.88888 * Zoom + Adjustment, MidpointRounding.AwayFromZero);
            int y = (int)Math.Round((50 - Latitude) * -88.68571 * Zoom + Adjustment +100, MidpointRounding.AwayFromZero);
            Img.BackgroundImage = null;
            Img.BackgroundImage = Resources.JapanMap1;
            Img.Location = new Point(x, y);
        }
    }
}
