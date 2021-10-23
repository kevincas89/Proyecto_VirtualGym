using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario : Persona
    {      
        public Usuario()
        {
            Tipo = "Usuario";
        }

        public int DiasDisponibles { get; set; }        
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IndiceMasaCorporal { get; set; }

        public void CalcularIndiceMasaCorporal()
        {
            IndiceMasaCorporal = Peso / Altura;
        }
<<<<<<< HEAD
        public Plan plan { get; set; }
=======

        public string CodigoPlan { get; set; }
        public Plan plan { get; set; }

        public string IdEntrenador { get; set; }
        public Entrenador Entrenador { get; set; }
>>>>>>> 3718cf7eb41d52ead7e0d16111d86f3f55d9e440
    }


}
