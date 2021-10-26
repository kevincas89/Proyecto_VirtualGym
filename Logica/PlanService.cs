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

        public PlanConsultaResponse Consultar()
        {
            try
            {
                connection.Open();
                return new PlanConsultaResponse(repository.ConsultarTodosPlanes());

            }
            catch (Exception e) { return new PlanConsultaResponse($"Error{e.Message}"); }
            finally { connection.Close(); }
        }

        public string Modificar(Plan plan, string CodPlan)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorCodigoPlan(CodPlan) != null)
                {
                    repository.Modificar(plan);
                    return $"Plan modificado de manera exitosa";
                }
                return $"El codigo del plan no se ha encotrado";
            }
            catch (Exception e) { return $"Se preseto la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }

        }

    }

    public class PlanConsultaResponse
    {
        public string Mensaje { get; set; }
        public List<Plan> Planes { get; set; }
        public bool Errror { get; set; }

        public PlanConsultaResponse(List<Plan> planes)
        {
            Planes = planes;
            Errror = false;
        }

        public PlanConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Errror = true;
        }



    }
}
