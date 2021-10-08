using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PlanService
    {
        private readonly PlanRepository repository;
        private readonly ConnectionManager connection;

        public PlanService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new PlanRepository(connection);
        }
       
        public string regitrarPlan(Plan plan)
        {
            try
            {
                connection.Open();

                repository.GuardarPlan(plan);
                return $"se guardo el plan {plan.Nombre} exitosamente.";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";
                
            }finally
            {
                connection.Close();
            }
        }
    }
}
