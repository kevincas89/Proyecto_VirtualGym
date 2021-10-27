using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Planes
    {

        public string CodigoPlan { get; set; }
        public decimal ValorPlan { get; set; }
        public string Nombre { get; set; }
        public int Dias { get; set; }



    }
}
