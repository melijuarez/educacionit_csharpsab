using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDemo
{
    public static class CalculoIva
    {
        //public static decimal IVA = 1.21m;
        //public static decimal IVA = Convert.ToDecimal(1.21);
        //public const decimal IVA = 1.21m;

        /*private static decimal iva = 1.21m;

        public static decimal IVA
        {
            get
            {
                return iva;
            }
        }*/

        public static decimal IVA => 1.21m;

        public static decimal AgregarIva(decimal valor)
        {
            return valor * IVA;
        }
    }
}
