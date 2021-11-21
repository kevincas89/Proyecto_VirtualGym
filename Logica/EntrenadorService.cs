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
                if (repository.BuscarPorIdentificacionEntrenador(entrenador.Identificacion)==null)
                {
                    repository.GuardarEntrenador(entrenador);
                    return $"Se guardo el entrenador {entrenador.PrimerNombre} exitosamente.";
                }
                return $"El entrenador ya se encuentra registrado.";
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
            catch (Exception e) { return new EntrenadorConsultaResponse($"Error {e.Message}"); }
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
        public string EliminarEntrenador(string IdentificacionEntrenador)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorIdentificacionEntrenador(IdentificacionEntrenador) != null)
                {
                    repository.EliminarEntrenador(IdentificacionEntrenador);
                    return $"El entrenador ha sido eliminado de manera exitosa";
                }
                return $"La identificacion del entrenador no se ha encotrado";
            }
            catch (Exception e) { return $"Se presento la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }

        }
        public EntrenadorRegistroResponse BuscarRegistro(string IdentifiacionEntrenador)
        {
            try
            {
                connection.Open();
                Entrenador entrenador = repository.BuscarPorIdentificacionEntrenador(IdentifiacionEntrenador);
                if (entrenador != null)
                {
                    return new EntrenadorRegistroResponse(entrenador);
                }
                return new EntrenadorRegistroResponse("El entrenador no se encuetra registrado");

            }
            catch (Exception e) { return new EntrenadorRegistroResponse($"Error{e.Message}"); }
            finally { connection.Close(); }
        }

    }

    public class EntrenadorConsultaResponse
    {
        public string Mensaje { get; set; }
        public List<Entrenador> Entrenador { get; set; }
        public bool Errror { get; set; }

        public EntrenadorConsultaResponse(List<Entrenador> entrenadores)
        {
            Entrenador = entrenadores;
            Errror = false;
        }

        public EntrenadorConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Errror = true;
        }

    }
    public class EntrenadorRegistroResponse
    {
        public string Mensaje { get; set; }
        public Entrenador entrenador { get; set; }
        public bool Errror { get; set; }

        public EntrenadorRegistroResponse(Entrenador entrenadores)
        {
            entrenador = entrenadores;
            Errror = false;
        }

        public EntrenadorRegistroResponse(string mensaje)
        {
            Mensaje = mensaje;
            Errror = true;
        }
    }
}

