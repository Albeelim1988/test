using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

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
            sum = x + y;
            Console.Write(sum);
            x = 3;
            y = x * 3;
            sum = x + y;
            sum = x - y;
            FileStraam fileO = File.OpenRead("text.txt"); //demo 

            /*test test1 = new test(1);
            test test2 = new test(2);
            test test3 = new test(3);*/
            int test1 = 1; //comment
            /*switch (test1)
            {
                case (test1 <9):
                    Console.WriteLine("Same as Case 2");
                    break;
                case test3:
                    Console.WriteLine("Same as Case 3");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }*/
        }
    }
    class test
    {
        public int value { get; set; }
        public test(int x) { value = x; }
    }
}
