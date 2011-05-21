using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Wielkanoc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //obliczenie dnia wielkiej nocy
			int a,b,c,d,e1,f,g,h,i,k,l,m,p,n,rok;

			rok = (int)numericUpDown1.Value;
				 a = rok % 19;
				 b = rok/100;
				 c = rok % 100;
				 d = b/4;
				 e1 = b % 4;
				 f = (b+8)/25;
				 g = (b-f+1)/3;
				 h = (19*a+b-d-g+15) % 30;
				 i = c/4;
				 k = c % 4;
				 l = (32+2*e1+2*i-h-k) % 7;
				 m = (a+11*h+22*l)/451;
				 p = (h+l-7*m+114) % 31;

				 p = (p+1);
				 n = (h+l-7*m+114)/31;

				 monthCalendar1.SetDate(new DateTime(rok,n,p));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(this, e);
        }
    }
}