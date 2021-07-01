using FormPrincipal.Clases.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases.ActivoFijoModel
{
    public class ActivoFijoModel
    {
        private ActivoFijo[] activoFijos;

        public ActivoFijoModel()
        {

        }

        public void Add(ActivoFijo af)
        {
            if (activoFijos == null)
            {
                activoFijos = new ActivoFijo[1];
                activoFijos[0] = af;
                return;

            }

            ActivoFijo[] temp = new ActivoFijo[activoFijos.Length + 1];
            Array.Copy(activoFijos, temp, activoFijos.Length);
            temp[activoFijos.Length] = af;

            activoFijos = temp;
        }

        public void Edit()
        {

        }

        public ActivoFijo[] FindAll()
        {
            return activoFijos;
        }

        public bool Delete()
        {
            return true;

        }

        public int Max()
        {
            if (activoFijos == null)
            {
                return 0;
            }

            int columns = (int)activoFijos.OrderBy(a => a.TipoActivoFijo)
                          .Reverse().FirstOrDefault().TipoActivoFijo;

            return columns;
        }

    }
}
