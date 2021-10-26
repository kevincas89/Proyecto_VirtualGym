using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class InformeGeneral
    {

        public string CodigoInforme { get; set; }
        public DateTime FechaInforme { get; set; }
        public double Ingresos { get; set; }
        public double Ganancias { get; set; }

    }
}
