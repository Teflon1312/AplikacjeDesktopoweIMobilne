﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Witaj w pierwszym programie WinForms");
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            MessageBox.Show("benc");
        }

        private void buttonSecond_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonFirst_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Witaj w pierwszym programie WinForms");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonName_Click(object sender, EventArgs e)
        {
            string message = "Witaj " + textBoxName.Text + " w tym programie";
            MessageBox.Show(message);
            textBoxName.Text = "Adam";
            labelName.Text = "Inny text";
            

        }
    }
}
