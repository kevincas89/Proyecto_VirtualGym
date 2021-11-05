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
            SegundoNombre = "vacio";
            SegundoApellido = "vacio";
            Celular1 = "vacio";
            Celular2 = "vacio";
        }
        public double Sueldo { get; set; }

       

    }
}
