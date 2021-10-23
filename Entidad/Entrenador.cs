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
        }
        public double Sueldo { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }

    }
}
