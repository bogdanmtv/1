using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string y;
            int[,] a = new int[5, 3];
            dg.Rows.Clear();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = random.Next(-100, 100);

                    
                    if (a[i, j] < 0)
                    {
                        y = ("[" + i + " " + j + "]");
                        dg.Rows.Add(y);
                    }
                  

                }
            }
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
