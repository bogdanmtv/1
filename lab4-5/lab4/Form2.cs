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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            Array ob = new Array();
            string andr = ob.a[5];
            dg.Rows.Add(andr.ToString());

            string f = ob.a[4];
            dg.Rows.Add(f.ToString());
            string r = ob.a[3];
            dg.Rows.Add(r.ToString());
            string x = ob.a[2];
            dg.Rows.Add(x.ToString());
            string t = ob.a[1];
            dg.Rows.Add(t.ToString());
            string u = ob.a[0];
            dg.Rows.Add(u.ToString());

          
        }

        class Array {
            
            public string[] a = { "Диасамидзе", "Саакашвили", "Поттер", "Шилдт", "Бондаренко", "Гречкань"};
          

            }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    }

    




