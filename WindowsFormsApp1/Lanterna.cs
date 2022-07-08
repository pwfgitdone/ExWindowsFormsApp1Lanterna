using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Lanterna
    {
        public string status = "Desligada";

        public void LigarLanterna()
        {
            this.status = "Ligada";
        }

        public void DesligarLanterna()
        {
            this.status = "Desligada";
        }
    }
}
