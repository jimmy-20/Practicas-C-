using FormPrincipal.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPrincipal.Clases
{
    public class PersonasModel
    {
        Persona[] personas;

        public PersonasModel()
        {

        }

        public void Add(Persona p)
        {
            if (personas == null)
            {
                personas = new Persona[1];
                personas[0] = p;
                return;
            }

            Persona[] temp = new Persona[personas.Length + 1];
            Array.Copy(personas,temp,personas.Length);
            temp[temp.Length - 1] = p;
            personas = temp;
        }

        public void Delete(int row)
        {

        }

        public void Edit()
        {

        }

        public Persona[] FindAll()
        {
            return personas;
        }
    }
}
