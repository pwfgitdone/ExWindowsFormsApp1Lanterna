using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Lanterna
    {
        public string statusBotaoEnergia = "Desligado";

        public void Ligar()
        {
            this.statusBotaoEnergia = "Ligado";
        }

        public void Desligar()
        {
            this.statusBotaoEnergia = "Desligado";
        }
    }
}
