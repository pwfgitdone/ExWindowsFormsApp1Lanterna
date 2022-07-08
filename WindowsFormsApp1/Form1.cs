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
            if (lanterna1.status == "Ligada") {
                if (bateria1.status > 0)
                {
                    bateria1.ReduzirBateria();
                    label4.Text = bateria1.status + "%";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ligar/desligar lanterna
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lanterna1.status=="Desligada")
            {
                lanterna1.LigarLanterna();
                MessageBox.Show("Lanterna está ligada!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                label3.Text = "Ligada";
                if (bateria1.status == 0) { MessageBox.Show("Lanterna precisa trocar bateria!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else
            {
                lanterna1.DesligarLanterna();
                MessageBox.Show("Lanterna está desligada!", "Atention!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                label3.Text = "Desligada";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lanterna lanterna1 = new Lanterna();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bateria1.TrocarBateria();
            label4.Text=bateria1.status + "%";
        }
    }
}
