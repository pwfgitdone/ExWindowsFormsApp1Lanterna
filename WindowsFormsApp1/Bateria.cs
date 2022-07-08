using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Bateria
    {
        public int status = 100;

        public void ReduzirBateria()
        {
            this.status--;
        }

        public void TrocarBateria()
        {
            this.status = 100;
        }
    }
}
