using FormPrincipal.Clases.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases.Poco
{
    public class ActivoFijo
    {
        public string Nombre { get; set; }
        public TipoActivoFijo TipoActivoFijo { get; set; }
        public int VidaUtil { get; set; }
        public decimal Costo { get; set; }
        public decimal Salvamento { get; set; }
    }
}
