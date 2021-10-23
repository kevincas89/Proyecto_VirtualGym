using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Plan
    {
<<<<<<< HEAD
=======
        [Key]
>>>>>>> 3718cf7eb41d52ead7e0d16111d86f3f55d9e440
        public string CodigoPlan { get; set; }
        public decimal ValorPlan { get; set; }
        public string Nombre { get; set; }
        public int Dias { get; set; }
<<<<<<< HEAD
=======

        public ICollection<Usuario> Usuarios { get; set; }
>>>>>>> 3718cf7eb41d52ead7e0d16111d86f3f55d9e440
    }
}
