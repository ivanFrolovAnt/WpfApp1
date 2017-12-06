using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            while (Visible)
            {
                int c = 255;
                while (c > 0 && Visible)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                    c--;
                }
                while (c < 255 && Visible)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                    c++;
                }
                //int length = 253;
                //for (int i = 0; i < length ; i++)
                //{
                //    this.BackColor = Color.FromArgb(i, 255 - i, i);
                //    Application.DoEvents();
                //    System.Threading.Thread.Sleep(3);
                //}

                //for (int i = 255; i > 0; i--)
                //{
                //    this.BackColor = Color.FromArgb(i, 255 - i, i);
                //    Application.DoEvents();
                //    System.Threading.Thread.Sleep(3);
                //}
            }
            
        }
    }
}
