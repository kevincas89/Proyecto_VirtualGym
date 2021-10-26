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
        public Usuario plan { get; set; }
        public Entrenador entrenador { get; set; }

    }


}
