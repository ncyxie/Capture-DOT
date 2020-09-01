using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capture_DOT_Alpha
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }


        private void captureScreenshot_Click(object sender, EventArgs e)
        {
            if (hideWindow.Checked == true)
            {
                this.Hide();
                System.Threading.Thread.Sleep(500);
                SendKeys.Send("{PRTSC}");
                Image myImage = Clipboard.GetImage();
                pictureBox.Image = myImage;
                this.Show();
            }
            else
            {
                SendKeys.Send("{PRTSC}");
                Image myImage = Clipboard.GetImage();
                pictureBox.Image = myImage;
                this.Hide();
                System.Threading.Thread.Sleep(500);
                this.Show();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            SaveFileDialog f = new SaveFileDialog();
            Image myImage = Clipboard.GetImage();
            pictureBox.Image = myImage;

            f.Filter = "JPG (*.jpg)|*.jpg";

            if (f.ShowDialog() == DialogResult.OK)
            {
                myImage.Save(f.FileName);
            }
        }
    }
}
