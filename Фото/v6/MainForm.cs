﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
        }
    }
    }
