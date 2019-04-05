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
        public MQuiz()
        {
            InitializeComponent();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            Random wylosowana = new Random();
            //Komputer losuje działania
            a = wylosowana.Next(1, 101);
            b = wylosowana.Next(1, 101);
            label_a.Text = a.ToString();
            label_b.Text = b.ToString();
            buttonstart.Enabled = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int liczba = Convert.ToInt32(textBoxsum.Text);
            int wynik = a + b;
            if (liczba < wynik)
            {
                labelwynik.Text = string.Format("Wynik za mały");
            }
            else if (liczba > wynik)
            {
                labelwynik.Text = string.Format("Wynik za duży");
            }
            else
            {
                labelwynik.Text = string.Format("Brawo ! Wynik poprawny");
            }
        }
    }
}
