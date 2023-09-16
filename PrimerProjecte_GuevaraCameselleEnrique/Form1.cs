using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProjecte_GuevaraCameselleEnrique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void datosMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peticiónMóduloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            //form2.Show();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
