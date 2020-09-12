using System;
using System.Drawing;
using System.Windows.Forms;

namespace Capture_DOT_Alpha
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Theme == "light")
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                ok_button.ForeColor = Color.Black;
            }
            else if (Properties.Settings.Default.Theme == "dark")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;
                ok_button.ForeColor = Color.Black;
            }
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
