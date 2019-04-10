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
        //Creating generator random numbers
        Random generator = new Random();

        int addend_a;
        int addend_b;
        int minuend;
        int subtrahend;
        int multiplicant;
        int multiplier;
        int dividend;
        int divisor;

        int start_time;
        int timeleft;
        public MQuiz()
        {
            InitializeComponent();
            labeltime.Text = "45 sekund";
            button_restart.Enabled = false;
        }

        public void QuizStart()
        {
            //dAddition
            addend_a = generator.Next(1, 101);
            addend_b = generator.Next(1, 101);
            PlusLeftLabel.Text = addend_a.ToString();
            PlusRightLabel.Text = addend_b.ToString();
            sum.Value = 0;

            //Subtrahend
            minuend = generator.Next(1, 101);
            subtrahend = generator.Next(1, minuend);
            MinusLeftLabel.Text = minuend.ToString();
            MinusRightLabel.Text = subtrahend.ToString();

            //Multiplication
            multiplicant = generator.Next(1, 101);
            multiplier = generator.Next(1, 101);
            TimesLeftLabel.Text = multiplicant.ToString();
            TimesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Division
            divisor = generator.Next(2, 11);
            int temporaryQuotient = generator.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            DividedLeftLabel.Text = dividend.ToString();
            DividedRightLabel.Text = divisor.ToString();

            //The timer
            start_time = 45;
            timeleft = start_time;
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend_a + addend_b == sum.Value) && (minuend - subtrahend == minus.Value))
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
            if (CheckTheAnswer())
            {
                //Function returns true value - correct answer
                timer1.Stop();
                MessageBox.Show("Gratulacje! Wszystkie odpowiedzi są prawidłowe");
                button_restart.Enabled = true;
            }
            else if (timeleft > 0)
            {
                //Function returns false value - incorrect answer
                timeleft = timeleft - 1;
                labeltime.Text = timeleft + " sekund";
            }
            else
            {
                timer1.Stop();
                labeltime.Text = "Czas minął";
                MessageBox.Show("Nieukończyłeś quizu w wyznaczonym czasie");
                button_restart.Enabled = true;
                sum.Value = addend_a + addend_b;
                minus.Value = minuend - subtrahend;
            }
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            labeltime.Text = "45 sekund";
            PlusLeftLabel.Text = "?";
            PlusRightLabel.Text = "?";
            MinusLeftLabel.Text = "?";
            MinusRightLabel.Text = "?";
            TimesLeftLabel.Text = "?";
            TimesRightLabel.Text = "?";
            DividedLeftLabel.Text = "?";
            DividedRightLabel.Text = "?";
            sum.Value = 0;
            minus.Value = 0;
            product.Value = 0;
            quotient.Value = 0;
            button_restart.Enabled = false;
            buttonstart.Enabled = true;
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
