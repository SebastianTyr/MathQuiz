using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math
{
    public partial class MQuiz : Form
    {
        int a;
        int b;
        int timeleft;
        public MQuiz()
        {
            InitializeComponent();
            labeltime.Text = "30 sekund";
            button_restart.Enabled = false;
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            Random wylosowana = new Random();
            a = wylosowana.Next(1, 101);
            b = wylosowana.Next(1, 101);
            PlusLeftLabel.Text = a.ToString();
            PlusRightLabel.Text = b.ToString();
            sum.Value = 0;
            buttonstart.Enabled = false;

            timeleft = 30;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                labeltime.Text = timeleft + " sekund";
            }
            else
            {
                timer1.Stop();
                labeltime.Text = "Czas minął";
                MessageBox.Show("Nieukończyłeś quizu w wyznaczonym czasie");
                button_restart.Enabled = true;
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            Random wylosowana = new Random();
            a = wylosowana.Next(1, 101);
            b = wylosowana.Next(1, 101);
            PlusLeftLabel.Text = a.ToString();
            PlusRightLabel.Text = b.ToString();
            buttonstart.Enabled = false;

            timeleft = 30;
            timer1.Start();
            button_restart.Enabled = false;
        }
    }
}
