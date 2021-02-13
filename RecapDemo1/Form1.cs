using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form //inheritens
    {
        public Form1() //constructor
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                 //[0. boyut, 1. boyut]
            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) //0. boyutun üst sınırına kadar...
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();

                    buttons[i, j].Top = top;
                    buttons[i, j].Left = left;
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    if ((i+j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }

                    this.Controls.Add(buttons[i, j]);

                    left += 50;
                }
                top += 50;
                left = 0;
            }
        }
    }
}
