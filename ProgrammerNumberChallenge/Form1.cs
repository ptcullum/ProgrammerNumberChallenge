using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammerNumberChallenge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double s = 0;
        double s2 = 0;
        double a;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i ++)
            {
                s += Math.Pow(i,2);
                s2 += i;
            }
            a = Math.Pow(s2,2) - s;
            a = Math.Pow(a,(1.0/3.0));
            a = Math.Round(a, 1);
            lblNumber.Text = a.ToString();
            if (a % 2 ==0)
            {
                lbl2.Text = "Even";
            }
            else{lbl2.Text = "Odd";}        
        }
    }
}
