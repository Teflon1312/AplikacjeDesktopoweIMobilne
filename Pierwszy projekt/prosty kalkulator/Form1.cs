using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosty_kalkulator
{
    public partial class Kalkulator : Form
    {
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void buttonSub_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber - secondNumber;
                labelResult.Text = "Wynik operacji: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }

        private void buttonAdd_MouseUp(object sender, MouseEventArgs e)
        {
           int firstNumber;
            int secondNumber;

            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelResult.Text = "Wynik operacji: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber + secondNumber;
                labelResult.Text = "Wynik operacji: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }




        private void ButtonMul_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            if (int.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && int.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                int result = firstNumber * secondNumber;
                labelResult.Text = "Wynik operacji: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }



        private void buttonDiv_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;

            if (float.TryParse(textBoxFirstNumber.Text, out firstNumber)
                && float.TryParse(textBoxSecondNumber.Text, out secondNumber))
            {
                float result = firstNumber / secondNumber;
                labelResult.Text = "Wynik operacji: " + result;
            }
            else
            {
                labelResult.Text = "Podano nieprawidłowe dane";
            }
        }
    }
}
