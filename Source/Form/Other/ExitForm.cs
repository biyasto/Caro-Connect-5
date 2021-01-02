using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class ExitForm : Form
    {
        public ExitForm(Point Location)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            this.Location = Location;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            Application.Exit();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click);
            Close();
        }
    }
}
