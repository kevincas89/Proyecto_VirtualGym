using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Entrenador: Persona
    {

        public Entrenador()
        {
            Tipo = "Entrenador";
            if (SegundoNombre == null)
            {
                SegundoNombre = "  ";
            }
            if (SegundoApellido == null)
            {
                SegundoApellido = "  ";
            }
            if (Celular1 == null)
            {
                Celular1 = "  ";
            }
            if (Celular2 == null)
            {
                Celular2 = "  ";
            }
             
        }
        public double Sueldo { get; set; }

       

    }
}
