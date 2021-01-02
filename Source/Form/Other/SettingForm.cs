using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caro
{
    public partial class SettingForm : Form
    {
        public SettingForm(Point Location)
        {

            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            this.Location = Location;
            Setting_Applied(0);
            Setting_Applied(1);
            Setting_Applied(2);

        }
        public void ReadSetting()
        {
            if (File.Exists(Application.StartupPath + "Setting.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + "Setting.txt");
                Cons.index[0] = Int32.Parse(lines[0]); Setting_Applied(0);
                Cons.index[1] = Int32.Parse(lines[1]); Setting_Applied(1);
                Cons.index[2] = Int32.Parse(lines[2]); Setting_Applied(2);
            }
            else
            {
                String[] lines = { "1","1","3"};
                File.WriteAllLines(Application.StartupPath + "Setting.txt", lines);
                ReadSetting();
            }

        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
         
            Cons.index[0]++;
            limit_index(0);
            Setting_Applied(0);
            sound.Play(sound.click);

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            
            Cons.index[1]--;
            limit_index(1);
            Setting_Applied(1);
            sound.Play(sound.click);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Cons.index[1]++;
            limit_index(1);
            Setting_Applied(1);
            sound.Play(sound.click);
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            Cons.index[2]--;
            limit_index(2);
            Setting_Applied(2);
            sound.Play(sound.click);
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            
            Cons.index[2]++;
            limit_index(2);
            Setting_Applied(2);
            sound.Play(sound.click);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           
            Cons.index[0]--;
            limit_index(0);
            Setting_Applied(0);
            sound.Play(sound.click);
        }
        private void limit_index(int num)
        {
            if(num==0 || num == 1)
            {
                if (Cons.index[num] > 1) Cons.index[num] -= 2;
                if (Cons.index[num] < 0) Cons.index[num] += 2;
            }
                else if (num == 2)
            {
                    if (Cons.index[num] > 5) Cons.index[num] -= 6;
                    if (Cons.index[num] < 0) Cons.index[num] += 6;
            }
        }
        public void Setting_Applied(int num)
        {

            if (num == 0)

                switch (Cons.index[num])
                {
                    case 0: { gunaLabel1.Text = "Off";sound.Theme_on = false;sound.PlayTheme(false); break;  }
                    case 1: { gunaLabel1.Text = "On"; sound.Theme_on = true; sound.PlayTheme(true); break;  }
                }

            else if (num == 1)
                switch (Cons.index[num])
                {
                    case 0: { gunaLabel4.Text = "Off"; sound.Sound_on = false; break; }
                    case 1: { gunaLabel4.Text = "On"; sound.Sound_on = true; break; }
                }
           
            else if (num == 2)
                switch(Cons.index[num])
                {
                    case 0: { Cons.PlayTime = 0; gunaLabel5.Text = "No Limit"; break; }
                    case 1: { Cons.PlayTime = 120; gunaLabel5.Text = "02:00"; break; }
                    case 2: { Cons.PlayTime = 180; gunaLabel5.Text = "03:00"; break; }
                    case 3: { Cons.PlayTime = 300; gunaLabel5.Text = "05:00"; break; }
                    case 4: { Cons.PlayTime = 480; gunaLabel5.Text = "08:00"; break; }
                    case 5: { Cons.PlayTime = 600; gunaLabel5.Text = "10:00"; break; }
                }
            
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            sound.Play(sound.click2);
            //Save Setting to txt file
            String[] lines = { Cons.index[0].ToString(), Cons.index[1].ToString(), Cons.index[2].ToString() };
            System.IO.File.WriteAllLines(Application.StartupPath + "Setting.txt", lines);
            //close
            this.Close();
        }
    }
}
