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

   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void одномерныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void двумерныйМассивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void классыСМассивамиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void работаСоСтрокамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
