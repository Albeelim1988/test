﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 4, y = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int sum;
            sum=x + y;
            Console.Write(sum);
            x = 3;
            y = x * 3;
            sum = x + y;
            sum = x - y;
            //FileStraem fileO = File.OpenRead("text.txt"); demo 
        }
    }
}
