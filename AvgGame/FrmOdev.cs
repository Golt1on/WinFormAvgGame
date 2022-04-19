using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev_06._04
{
    public partial class FrmOdev06_04 : Form
    {
        public FrmOdev06_04()
        {
            InitializeComponent();
        }

        public double avg(double num1, double num2)
        {
            double result = (num1 + num2) / 2;
            return result;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(txt_num1.Text);
            double number2 = Convert.ToDouble(txt_num2.Text);
            double average = avg(number1, number2);

            Random myRandom = new Random();
            int myRandomNumber = myRandom.Next(0, (int)(number1 + number2));

            if (average > myRandomNumber)
            {
                lbl_result.Text = "Your Average : " + average + "\nThis is threshold : " + myRandomNumber;
                MessageBox.Show("Gratz You Win!");
            }

            else
            {
                lbl_result.Text = "Your Average : " + average + "\nThis is threshold : " + myRandomNumber;
                MessageBox.Show("You Lose :(");
            }

        }

       
    }
}
