using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_SoftwareArch_GUI
{
    public partial class Form1 : Form
    {
        int flag = 0;
        int m, n, p;
        public Form1()
        {
            InitializeComponent();
            
            outLabel.Text = "Guess an int, M, in range 0 to 10: M =";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                string msg = textBox1.Text;
                m = Int32.Parse(msg);
                if (m < 0 || m > 10)
                {
                    outLabel.Text = "Invalid Enter!";
                }
                else
                {
                    m = Int32.Parse(msg);
                    outLabel.Text = "I guess int, N, in range 0, 10-M. Now you type an int, P, such that M + N + P = 10: P =";
                    Random r = new Random();
                    n = r.Next(0, 10 - m + 1);
                    flag = 1;
                }
            }
            else
            {
                string msg = textBox1.Text;
                p = Int32.Parse(msg);
                if ((m + n + p) == 10)
                {
                    outLabel.Text = "You win!";
                }
                else
                {
                    outLabel.Text = "You lose!";
                }
                button1.Enabled = false;
            }
            
                
            
           
        }
        
    }
}
