﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetniTersineÇevirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            string metintersi = "";
            for (int i = metin.Length - 1; i >= 0; i--)
            {
                metintersi += metin.Substring(i, 1);
            }
            textBox2.Text = metintersi;
        }
    }
    }
