using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases.Depreciacion
{
    public class LineaRecta : IDepreciacion
    {
        public decimal[] calcular(int vida, decimal costo, decimal salvamento)
        {
            decimal value = (costo - salvamento) / vida;
            decimal[] depreciacion = new decimal[vida];

            for (int i = 0; i<vida; i++)
            {
                depreciacion[i] = value;
            }

            return depreciacion;
        }
    }
}
