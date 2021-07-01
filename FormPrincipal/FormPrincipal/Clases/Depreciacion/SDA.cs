using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases.Depreciacion
{
    public class SDA : IDepreciacion
    {
        public decimal[] calcular(int vida, decimal costo, decimal salvamento)
        {
            int suma = (vida * (1 + vida)) / 2;
            decimal[] depreciacion = new decimal[vida];
            decimal value = costo - salvamento;

            for (int i = vida; i>=1; i--)
            {
                decimal dep = value * ((decimal) i / suma);

                depreciacion[vida-i] = dep;
            }

            return depreciacion;
            
        }
    }
}
