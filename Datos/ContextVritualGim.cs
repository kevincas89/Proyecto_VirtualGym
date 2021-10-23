using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ContextVritualGim: DbContext
    {
        public ContextVritualGim() : base("Data Source=localhost:1521/xepdb1;User Id=adminpro;Password=juanpablo08"){}

        protected override void OnModelCreating(DbModelBuilder model){}

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<Plan> Planes { get; set; }
    }
}
