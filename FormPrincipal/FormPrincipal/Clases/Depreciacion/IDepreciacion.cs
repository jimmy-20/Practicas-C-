using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases.Depreciacion
{
    public interface IDepreciacion
    {
        decimal[] calcular(int vida, decimal costo, decimal salvamento);
    }
}
