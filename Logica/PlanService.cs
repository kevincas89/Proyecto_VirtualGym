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
       
        public string regitrarPlan(Planes plan)
        {
            try
            {
                connection.Open();
                if (repository.BuscarPorCodigoPlan(plan.CodigoPlan) == null)
                {
                    repository.GuardarPlan(plan);
                    return $"se guardo el plan {plan.Nombre} exitosamente.";
                }
                return $"El plan ya se encuentra registrado.";
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

        public string Modificar(Planes plan, string CodPlan)
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
            catch (Exception e) { return $"Se presento la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }

        }

        public string Eliminar(string CodPlan)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorCodigoPlan(CodPlan) != null)
                {
                    repository.Eliminar(CodPlan);
                    return $"Plan eliminado de manera exitosa";
                }
                return $"El codigo del plan no se ha encotrado";
            }
            catch (Exception e) { return $"Se presento la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }

        }

        public PlanRegistroResponse BuscarRegistro(string CodPlan)
        {
            try
            {
                connection.Open();
                Planes plan =  repository.BuscarPorCodigoPlan(CodPlan);
                if (plan!=null)
                {
                    return new PlanRegistroResponse(plan);
                }
                return new PlanRegistroResponse("El plan no se encuetra registrado");

            }
            catch (Exception e) { return new PlanRegistroResponse($"Error{e.Message}"); }
            finally { connection.Close(); }
        }
    }

    public class PlanConsultaResponse
    {
        public string Mensaje { get; set; }
        public List<Planes> Planes { get; set; }
        public bool Errror { get; set; }

        public PlanConsultaResponse(List<Planes> planes)
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

    public class PlanRegistroResponse
    {
        public string Mensaje { get; set; }
        public Planes Planes { get; set; }
        public bool Errror { get; set; }

        public PlanRegistroResponse(Planes planes)
        {
            Planes = planes;
            Errror = false;
        }

        public PlanRegistroResponse(string mensaje)
        {
            Mensaje = mensaje;
            Errror = true;
        }
    }
}
