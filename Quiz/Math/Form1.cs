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
        //Tworzymy "generator" liczb losowych
        Random generator = new Random();

        int plus_a;
        int plus_b;
        int minuend;
        int subtrahend;

        int timeleft;
        public MQuiz()
        {
            InitializeComponent();
            labeltime.Text = "30 sekund";
            button_restart.Enabled = false;
        }

        public void QuizStart()
        {
            //dodawanie
            plus_a = generator.Next(1, 101);
            plus_b = generator.Next(1, 101);
            PlusLeftLabel.Text = plus_a.ToString();
            PlusRightLabel.Text = plus_b.ToString();
            sum.Value = 0;

            //odejmowanie
            minuend = generator.Next(1, 101);
            subtrahend = generator.Next(1, minuend);
            MinusLeftLabel.Text = minuend.ToString();
            MinusRightLabel.Text = subtrahend.ToString();

            //nasz timer
            timeleft = 30;
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((plus_a + plus_b == sum.Value) && (minuend - subtrahend == minus.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            QuizStart();
            buttonstart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Sprawdzenie poprawnosci odpowiedzi
            if (CheckTheAnswer())
            {
                //funkcja zwraca true - poprawna odpowiedz
                timer1.Stop();
                MessageBox.Show("Gratulacje! Wszystkie odpowiedzi są prawidłowe");
                button_restart.Enabled = true;
            }
            else if (timeleft > 0)
            {
                //funkcja zwraca false - kontynuuj odliczanie
                timeleft = timeleft - 1;
                labeltime.Text = timeleft + " sekund";
            }
            else
            {
                timer1.Stop();
                labeltime.Text = "Czas minął";
                MessageBox.Show("Nieukończyłeś quizu w wyznaczonym czasie");
                button_restart.Enabled = true;
                sum.Value = plus_a + plus_b;
                minus.Value = minuend - subtrahend;
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            QuizStart();
            sum.Value = 0;
            minus.Value = 0;
            product.Value = 0;
            quotient.Value = 0;
            button_restart.Enabled = false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfanswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfanswer);
            }
        }
    }
}
