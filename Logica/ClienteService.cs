﻿using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ClienteService
    {
        private readonly ClienteRepository repository;
        private readonly ConnectionManager connection;
        private readonly PlanRepository _repository;

        public ClienteService(string connectionString)
        {
            connection = new ConnectionManager(connectionString);
            repository = new ClienteRepository(connection);
            _repository = new PlanRepository(connection);
        }

        public string regitrarUsuario(Clientes cliente)
        {
            try
            {
                connection. Open();
                if (repository.BuscarPorIdentificacionCliente(cliente.Identificacion) == null)
                {
                    if (_repository.BuscarPorCodigoPlan(cliente.plan.CodigoPlan) != null)
                    {
                        cliente.CalcularIndiceMasaCorporal();
                        repository.GuardarCliente(cliente);
                        return $"se guardo el cliente {cliente.PrimerNombre} exitosamente.";
                    }
                    
                }
                return $"El cliente ya se encuentra registrado.";
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

        public ClienteConsultaResponse Consultar()
        {
            try
            {
                connection.Open();
                return new ClienteConsultaResponse(repository.ConsultarTodosClientes());

            }
            catch (Exception e) { return new ClienteConsultaResponse($"Error{e.Message}"); }
            finally { connection.Close(); }
        }

        public string Modificar(Clientes cliente, string IdentifiacionCliente)
        {
            try
            {
                connection.Open();

                if (repository.BuscarPorIdentificacionCliente(IdentifiacionCliente) != null)
                {
                    repository.ModificarCliente(cliente);
                    return $"Cliente modificado de manera exitosa";
                }
                return $"La identificacion del cliente no se ha encotrado";
            }
            catch (Exception e) { return $"Se presento la siguiente Excepción: {e.Message}"; }
            finally
            {
                connection.Close();
            }

        }

    }

    public class ClienteConsultaResponse
    {
        public string Mensaje { get; set; }
        public List<Clientes> Clientes { get; set; }
        public bool Errror { get; set; }

        public ClienteConsultaResponse(List<Clientes> clientes)
        {
            Clientes = clientes;
            Errror = false;
        }

        public ClienteConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Errror = true;
        }

    }
}
