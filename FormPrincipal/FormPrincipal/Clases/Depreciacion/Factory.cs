using FormPrincipal.Clases.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases.Depreciacion
{
    public class Factory
    {
        public static IDepreciacion GetInstance(MetodoDepreciacion metodoDepreciacion)
        {
            switch (metodoDepreciacion)
            {
                case MetodoDepreciacion.Linea_Recta:
                    return new LineaRecta();
                case MetodoDepreciacion.SDA:
                    return new SDA();
            }

            return null;
        }
    }
}
