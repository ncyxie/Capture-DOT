using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Capture_DOT_Alpha
{
    public partial class Main : Form
    {
        bool CanApplicationClose = false;

        public Main()
        {
            InitializeComponent();

            LightMode();
            NoImage();
        }

        public void GetSettings()
        {
            this.BackColor = Properties.Settings.Default.Mode;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.Mode = this.BackColor;

            Properties.Settings.Default.Save();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            GetSettings();

            if (this.BackColor == Color.FromArgb(30, 30, 30))
            {
                DarkMode();
            }
            else
            {
                LightMode();
            }
        }

        private void NoImage()
        {
            if (pictureBox.Image == null)
            {
                save.Enabled = false;
            }
            else
            {
                save.Enabled = true;
            }
        }

        private void captureScreenshot_Click(object sender, EventArgs e)
        {
            if (hideWindow.Checked == true)
            {
                this.Hide();
                System.Threading.Thread.Sleep(400);
                Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics g = Graphics.FromImage(bm);
                g.CopyFromScreen(0, 0, 0, 0, bm.Size);
                pictureBox.Image = bm;
                this.Show();
                NoImage();
            }
            else
            {
                Bitmap bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics g = Graphics.FromImage(bm);
                g.CopyFromScreen(0, 0, 0, 0, bm.Size);
                pictureBox.Image = bm;
                this.Hide();
                System.Threading.Thread.Sleep(400);
                this.Show();
                NoImage();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();

            f.Filter = "JPG Image|*.jpg|PNG Image|*.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(f.FileName);

                MessageBox.Show("Image has been successfully saved. Saved to: \n" + Path.GetFullPath(f.FileName), "Capture DOT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void about_Click(object sender, EventArgs e)
        {
            using (About frm = new About())
            {
                frm.ShowDialog();
            }
        }

        private void darkMode_Click(object sender, EventArgs e)
        {
            DarkMode();
        }

        private void DarkMode()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;
            save.ForeColor = Color.Black;
            about.ForeColor = Color.Black;
            darkMode.ForeColor = Color.Black;
            captureScreenshot.ForeColor = Color.Black;
            lightMode.ForeColor = Color.Black;

            darkMode.Enabled = false;
            lightMode.Enabled = true;

            Properties.Settings.Default.Theme = "dark";
        }

        private void lightMode_Click(object sender, EventArgs e)
        {
            LightMode();
        }

        private void LightMode()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            save.ForeColor = Color.Black;
            about.ForeColor = Color.Black;
            darkMode.ForeColor = Color.Black;
            captureScreenshot.ForeColor = Color.Black;
            lightMode.ForeColor = Color.Black;

            lightMode.Enabled = false;
            darkMode.Enabled = true;

            Properties.Settings.Default.Theme = "light";
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CanApplicationClose == false)
            {
                e.Cancel = true;

                DialogResult confirm = MessageBox.Show("Are you sure you want to exit application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirm == DialogResult.Yes)
                {
                    CanApplicationClose = true;
                    Application.Exit();
                }

                SaveSettings();
            }
        }
    }
}
