﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                othersTextBox.Visible = true;
            }
            else
            {
                othersTextBox.Visible = false;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string str = " ";

            //japan
            if(checkBox1.Checked == true)
            {
                str = str + checkBox1.Text;
                str += "\n";
            }

            //philippines
            if (checkBox2.Checked == true)
            {
                str = str + checkBox2.Text;
                str += "\n";
            }

            //thailand
            if (checkBox3.Checked == true)
            {
                str = str + checkBox3.Text;
                str += "\n";
            }

            //SK
            if (checkBox4.Checked == true)
            {
                str = str + checkBox4.Text;
                str += "\n";
            }

            //china
            if (checkBox5.Checked == true)
            {
                str = str + checkBox5.Text;
                str += "\n";
            }

            //others
            if (checkBox6.Checked == true)
            {
                str = str + othersTextBox.Text;
                str += "\n";
            }

            if (str != null)
            {
                MessageBox.Show("You selected: \n" + str + "\nThank You!", "survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void othersTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
