using System;
using System.Windows.Forms;

namespace Capture_DOT_Alpha
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
