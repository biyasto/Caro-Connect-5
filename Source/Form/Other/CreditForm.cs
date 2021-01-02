using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caro
{
    public partial class CreditForm : Form
    {
        public CreditForm(Point location)
        {
            InitializeComponent();
            Location = location;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            //Show StartForm
            foreach (Form frm in Application.OpenForms)
                frm.Visible = true;
            //close CreditForm
            Close();
        }
    }
}
