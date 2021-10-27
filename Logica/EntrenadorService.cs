using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EntrenadorService
    {
        private readonly EntrenadorRepository repository;
        private readonly ConnectionManager connection;

        public EntrenadorService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new EntrenadorRepository(connection);
        }

        public string regitrarEntrenador(Entrenador entrenador)
        {
            try
            {
                connection.Open();

                repository.GuardarEntrenador(entrenador);
                return $"se guardo el entrenador {entrenador.PrimerNombre} exitosamente.";
            }
            catch (Exception e)
            {
                return $"Error: {e.Message}";

            }
            finally
            {
                connection.Close();
            }
        }

        public EntrenadorConsultaResponse ConsultarEntrenador()
        {
            try
            {
                connection.Open();
                return new EntrenadorConsultaResponse(repository.ConsultarTodosEntrenadores());

            }
            catch (Exception e) { return new EntrenadorConsultaResponse($"Error{e.Message}"); }
            finally { connection.Close(); }
        }

        public string ModificarEntrenador(Entrenador entrenador, string IdentificacionEntrenador)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorIdentificacionEntrenador(IdentificacionEntrenador) != null)
                {
                    repository.ModificarEntrenador(entrenador);
                    return $"El entrenador ha sido modificado de manera exitosa";
                }
                return $"La identificacion del entrenador no se ha encotrado";
            }
            catch (Exception e) { return $"Se presento la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }

        }

    }

    public class EntrenadorConsultaResponse
    {
        public string Mensaje { get; set; }
        public List<Entrenador> Entrenadores { get; set; }
        public bool Errror { get; set; }

        public EntrenadorConsultaResponse(List<Entrenador> entrenadores)
        {
            Entrenadores = entrenadores;
            Errror = false;
        }

        public EntrenadorConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Errror = true;
        }



    }
}

