using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_final_GuevaraVC14
{
    public partial class fareheit: Form
    {
        double grados;
        public fareheit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) - 32;
                grados = grados/ 1.8;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) - 32;
            grados = grados / 1.8;
            grados = grados + 273.15;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) - 32;
            grados = grados / 1.2;
                grados = grados -100;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) - 32;
            grados = grados / 3.42857139;
            grados = grados +7.5;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) - 32; 
            grados = grados/ 5.45454555;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) + 459.67;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) - 32;
                grados = grados / 2.25000002;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void celciusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 C = new Form1();
            C.Show();
            this.Hide();
        }
    }
}
