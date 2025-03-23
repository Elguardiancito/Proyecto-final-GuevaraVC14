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
    public partial class Form1: Form
    {
        double grados;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) * 9.0 / 5.0+ 32.0;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) + 273.15;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) * 1.5 - 100;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) / 1.9047619 + 7.5;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) / 3.03030303;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) * 1.8 + 491.67;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            grados = Convert.ToDouble(Interaction.InputBox("Ingrese un número:")) / 1.25;
            label5.Text = string.Format("{0:F2}", grados);
        }

        private void farenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fareheit f = new fareheit();
            f.Show();
            this.Hide();
        }
    }
}
