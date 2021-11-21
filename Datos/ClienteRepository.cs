using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteRepository
    {
        PlanRepository planes;
        EntrenadorRepository entrenadores;
        private readonly OracleConnection _connection;

        public ClienteRepository(ConnectionManager connection)
        {
            planes = new PlanRepository(connection);
            entrenadores = new EntrenadorRepository(connection);
            _connection = connection._connection;
        }

        /*public int GuardarCliente(Clientes cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert into clientes (IdentificacionCliente,
                                        PrimerNombre, SegundoNombre, PrimerApellido , SegundoApellido ,
                                        Sexo ,FechaNacimiento ,Telefono1 ,Telefono2,Peso,Altura, IMC,CodPlan,
                                        IdentificacionEntrenador)
                                        values (:IdentificacionCliente,:PrimerNombre, :SegundoNombre,
                                        :PrimerApellido ,:SegundoApellido, :Sexo ,:FechaNacimiento,
                                        :Telefono1 ,:Telefono2 ,:Peso,:Altura, :IMC,:CodPlan,:IdentificacionEntrenador)";
                command.Parameters.Add(":IdentificacionCliente", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add(":PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add(":SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add(":PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add(":SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add(":Sexo", OracleDbType.Char).Value = cliente.Sexo;
                command.Parameters.Add(":FechaNacimiento", OracleDbType.Date).Value = cliente.FechaNacimiento;
                command.Parameters.Add(":Telefono1", OracleDbType.Varchar2).Value = cliente.Celular1;
                command.Parameters.Add(":Telefono2", OracleDbType.Varchar2).Value = cliente.Celular2;
                command.Parameters.Add(":Peso", OracleDbType.Double).Value = cliente.Peso;
                command.Parameters.Add(":Altura", OracleDbType.Double).Value = cliente.Altura;
                command.Parameters.Add(":IMC", OracleDbType.Double).Value = cliente.IndiceMasaCorporal;
                command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = cliente.plan.CodigoPlan;
                command.Parameters.Add(":IdentificacionEntrenador", OracleDbType.Varchar2).Value = cliente.entrenador.Identificacion;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }*/

        public int GuardarCliente(Clientes cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "agg_cliente";
                command.BindByName = true;
                
                command.Parameters.Add("IdentificacionCliente", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("Sexo", OracleDbType.Char).Value = cliente.Sexo;
                command.Parameters.Add("FechaNacimiento", OracleDbType.Date).Value = cliente.FechaNacimiento;
                command.Parameters.Add("Telefono1", OracleDbType.Varchar2).Value = cliente.Celular1;
                command.Parameters.Add("Telefono2", OracleDbType.Varchar2).Value = cliente.Celular2;
                command.Parameters.Add("Peso", OracleDbType.Double).Value = cliente.Peso;
                command.Parameters.Add("Altura", OracleDbType.Double).Value = cliente.Altura;
                command.Parameters.Add("IMC", OracleDbType.Double).Value = cliente.IndiceMasaCorporal;
                command.Parameters.Add("CodPlan", OracleDbType.Varchar2).Value = cliente.plan.CodigoPlan;
                command.Parameters.Add("IdentificacionEntrenador", OracleDbType.Varchar2).Value = cliente.entrenador.Identificacion;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public Clientes BuscarPorIdentificacionCliente(string IdentificacionCliente)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add(":IdentificacionCliente", OracleDbType.Varchar2).Value = IdentificacionCliente;
                command.CommandText = "select * from clientes where IdentificacionCliente =:IdentificacionCliente";

                dataReader = command.ExecuteReader();
                dataReader.Read();
                Clientes usuario = DataReaderMapToUsuario(dataReader);
                return usuario;
            }
        }

        public List<Clientes> ConsultarTodosClientes()
        {
            OracleDataReader dataReader;
            List<Clientes> clientes = new List<Clientes>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT IdentificacionCliente,PrimerNombre, SegundoNombre, PrimerApellido , SegundoApellido," +
                    "Sexo ,FechaNacimiento ,Telefono1 ,Telefono2,Peso,Altura," +
                    " IMC,CodPlan,IdentificacionEntrenador FROM clientes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Clientes usuario = DataReaderMapToUsuario(dataReader);
                        clientes.Add(usuario);
                    }
                }
            }
            return clientes;
        }

        private Clientes DataReaderMapToUsuario(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;

            Clientes clientes = new Clientes();

            clientes.Identificacion = dataReader.GetString(0);
            clientes.PrimerNombre = dataReader.GetString(1);
            clientes.SegundoNombre = dataReader.GetString(2);
            clientes.PrimerApellido = dataReader.GetString(3);
            clientes.SegundoApellido = dataReader.GetString(4);
            clientes.Sexo = Convert.ToChar( dataReader.GetString(5));
            clientes.FechaNacimiento = (DateTime)dataReader.GetDateTime(6);
            clientes.Celular1 = dataReader.GetString(7);
            clientes.Celular2 = dataReader.GetString(8);
            clientes.Peso = dataReader.GetDouble(9);
            clientes.Altura = dataReader.GetDouble(10);
            clientes.IndiceMasaCorporal = dataReader.GetDouble(11);   
            clientes.plan = planes.BuscarPorCodigoPlan(dataReader.GetString(12));
            clientes.entrenador = entrenadores.BuscarPorIdentificacionEntrenador(dataReader.GetString(13));

            return clientes;
        }

        /*public int ModificarCliente(Clientes cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                
                command.Parameters.Add(":PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add(":SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add(":PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add(":SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add(":Sexo", OracleDbType.Char).Value = cliente.Sexo;
                command.Parameters.Add(":FechaNacimiento", OracleDbType.Date).Value = cliente.FechaNacimiento;
                command.Parameters.Add(":Telefono1", OracleDbType.Varchar2).Value = cliente.Celular1;
                command.Parameters.Add(":Telefono2", OracleDbType.Varchar2).Value = cliente.Celular2;
                command.Parameters.Add(":Peso", OracleDbType.Double).Value = cliente.Peso;
                command.Parameters.Add(":Altura", OracleDbType.Double).Value = cliente.Altura;
                command.Parameters.Add(":IMC", OracleDbType.Double).Value = cliente.IndiceMasaCorporal;
                //command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = cliente.plan;
                //command.Parameters.Add(":IdentificacionEntrenador", OracleDbType.Varchar2).Value = cliente.entrenador;
                command.Parameters.Add(":IdentificacionCliente", OracleDbType.Varchar2).Value = cliente.Identificacion;

                command.CommandText = "UPDATE clientes SET PrimerNombre = :PrimerNombre," +
                    " SegundoNombre = :SegundoNombre, PrimerApellido = :PrimerApellido," +
                    " SegundoApellido =:SegundoApellido, Sexo = :Sexo," +
                    " FechaNacimiento = :FechaNacimiento, Telefono1 = :Telefono1, Telefono2 = :Telefono2," +
                    " Peso = :Peso, Altura = :Altura, IMC =:IMC WHERE IdentificacionCliente = :IdentificacionCliente";
                                           
                return command.ExecuteNonQuery();
            }
        }*/

        public int ModificarCliente(Clientes cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "P_ModificarCliente";
                command.BindByName = true;

                command.Parameters.Add("P_IdentificacionCliente", OracleDbType.Varchar2).Value = cliente.Identificacion;
                command.Parameters.Add("P_PrimerNombre", OracleDbType.Varchar2).Value = cliente.PrimerNombre;
                command.Parameters.Add("P_SegundoNombre", OracleDbType.Varchar2).Value = cliente.SegundoNombre;
                command.Parameters.Add("P_PrimerApellido", OracleDbType.Varchar2).Value = cliente.PrimerApellido;
                command.Parameters.Add("P_SegundoApellido", OracleDbType.Varchar2).Value = cliente.SegundoApellido;
                command.Parameters.Add("P_Sexo", OracleDbType.Char).Value = cliente.Sexo;
                command.Parameters.Add("P_FechaNacimiento", OracleDbType.Date).Value = cliente.FechaNacimiento;
                command.Parameters.Add("P_Telefono1", OracleDbType.Varchar2).Value = cliente.Celular1;
                command.Parameters.Add("P_Telefono2", OracleDbType.Varchar2).Value = cliente.Celular2;
                command.Parameters.Add("P_Peso", OracleDbType.Double).Value = cliente.Peso;
                command.Parameters.Add("P_Altura", OracleDbType.Double).Value = cliente.Altura;
                command.Parameters.Add("P_IMC", OracleDbType.Double).Value = cliente.IndiceMasaCorporal;
                
                return command.ExecuteNonQuery();
            }
        }

        public int EliminarCliente(string IdentificacionCliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "P_EliminarCliente";
                command.BindByName = true;

                command.Parameters.Add("P_IdentificacionCliente", OracleDbType.Varchar2).Value = IdentificacionCliente;
               
                return command.ExecuteNonQuery();
            }
        }
    }
}
