using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lanterna1.statusBotaoEnergia == "Ligado") {
                if (bateria1.status > 0)
                {
                    label3.Text = "Ligada";
                    bateria1.ReduzirBateria();
                    label4.Text = bateria1.status + "%";
                }
                if (bateria1.status == 0) label3.Text = "Desligada";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lanterna1.statusBotaoEnergia == "Desligado")
            {
                lanterna1.Ligar();
                label7.Text = "Ligado";
                if (bateria1.status > 0)
                {
                    label3.Text = "Ligada";
                    MessageBox.Show("Lanterna está ligada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else { 
                    MessageBox.Show("Lanterna precisa trocar bateria!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                }
            }
            else
            {
                lanterna1.Desligar();
                label7.Text = "Desligado";
                label3.Text = "Desligada";
                MessageBox.Show("Lanterna está desligada!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bateria1.TrocarBateria();
            label4.Text=bateria1.status + "%";
            if (lanterna1.statusBotaoEnergia == "Ligado") label3.Text = "Ligada";
        }
    }
}
