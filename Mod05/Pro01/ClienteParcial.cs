using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro01
{
    public partial class  Cliente
    {
        public int edad()
        {
            int iEdad=0;
            int iDias = 0;
            iDias = (int)DateTime.Today.Subtract(FecNacimiento).TotalDays;
            iEdad = (int)(iDias / 365.25);
            return iEdad;
        }
    }
}
