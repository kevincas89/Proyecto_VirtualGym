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
    public class EntrenadorRepository
    {
        private readonly OracleConnection _connection;

        public EntrenadorRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        /*public int GuardarEntrenador(Entrenador entrenador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"INSERT INTO entrenador (IdentificacionEntrenador,
                                        PrimerNombre,SegundoNombre,PrimerApellido ,SegundoApellido ,
                                        Sexo,FechaNacimiento,Telefono1,Telefono2,Sueldo)
                                        VALUES (:IdentificacionEntrenador,:PrimerNombre,:SegundoNombre,
                                        :PrimerApellido,:SegundoApellido,:Sexo,:FechaNacimiento,
                                        :Telefono1,:Telefono2,:Sueldo)";
                command.Parameters.Add(":IdentificacionEntrenador", OracleDbType.Varchar2).Value = entrenador.Identificacion;
                command.Parameters.Add(":PrimerNombre", OracleDbType.Varchar2).Value = entrenador.PrimerNombre;
                command.Parameters.Add(":SegundoNombre", OracleDbType.Varchar2).Value = entrenador.SegundoNombre;
                command.Parameters.Add(":PrimerApellido", OracleDbType.Varchar2).Value = entrenador.PrimerApellido;
                command.Parameters.Add(":SegundoApellido", OracleDbType.Varchar2).Value = entrenador.SegundoApellido;
                command.Parameters.Add(":Sexo", OracleDbType.Char).Value = entrenador.Sexo;
                command.Parameters.Add(":FechaNacimiento", OracleDbType.Date).Value = entrenador.FechaNacimiento;
                command.Parameters.Add(":Telefono1", OracleDbType.Varchar2).Value = entrenador.Celular1;
                command.Parameters.Add(":Telefono2", OracleDbType.Varchar2).Value = entrenador.Celular2;
                command.Parameters.Add(":Sueldo", OracleDbType.Double).Value = entrenador.Sueldo;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }*/

        public int GuardarEntrenador(Entrenador entrenador)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "agg_entrenador";
                command.BindByName = true;

                command.Parameters.Add("IdentificacionEntrenador", OracleDbType.Varchar2).Value = entrenador.Identificacion;
                command.Parameters.Add("PrimerNombre", OracleDbType.Varchar2).Value = entrenador.PrimerNombre;
                command.Parameters.Add("SegundoNombre", OracleDbType.Varchar2).Value = entrenador.SegundoNombre;
                command.Parameters.Add("PrimerApellido", OracleDbType.Varchar2).Value = entrenador.PrimerApellido;
                command.Parameters.Add("SegundoApellido", OracleDbType.Varchar2).Value = entrenador.SegundoApellido;
                command.Parameters.Add("Sexo", OracleDbType.Char).Value = entrenador.Sexo;
                command.Parameters.Add("FechaNacimiento", OracleDbType.Date).Value = entrenador.FechaNacimiento;
                command.Parameters.Add("Telefono1", OracleDbType.Varchar2).Value = entrenador.Celular1;
                command.Parameters.Add("Telefono2", OracleDbType.Varchar2).Value = entrenador.Celular2;
                command.Parameters.Add("Sueldo", OracleDbType.Double).Value = entrenador.Sueldo;
                var filas = command.ExecuteNonQuery();
                return filas;

            }
        }

        public Entrenador BuscarPorIdentificacionEntrenador(string IdentificacionEntrenador)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add(":IdentificacionEntrenador", OracleDbType.Varchar2).Value = IdentificacionEntrenador;
                command.CommandText = "SELECT * FROM entrenador WHERE IdentificacionEntrenador = :IdentificacionEntrenador";

                dataReader = command.ExecuteReader();
                dataReader.Read();
                Entrenador entrenador = DataReaderMapToEntrenador(dataReader);
                return entrenador;
            }
        }

        public List<Entrenador> ConsultarTodosEntrenadores()
        {
            OracleDataReader dataReader;
            List<Entrenador> entrenadores = new List<Entrenador>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT IdentificacionEntrenador,PrimerNombre, SegundoNombre, PrimerApellido , SegundoApellido,Sexo ,FechaNacimiento ,Telefono1 ,Telefono2,Sueldo FROM entrenador";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Entrenador entrenador = DataReaderMapToEntrenador(dataReader);
                        entrenadores.Add(entrenador);
                    }
                }
            }
            return entrenadores;
        }

        private Entrenador DataReaderMapToEntrenador(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;

            Entrenador entrenador = new Entrenador();

            entrenador.Identificacion = dataReader.GetString(0);
            entrenador.PrimerNombre = dataReader.GetString(1);  
            entrenador.SegundoNombre = dataReader.GetString(2);
            entrenador.PrimerApellido = dataReader.GetString(3);       
            entrenador.SegundoApellido = dataReader.GetString(4);         
            entrenador.Sexo = Convert.ToChar(dataReader.GetString(5));
            entrenador.FechaNacimiento =(DateTime) dataReader.GetDateTime(6);
            entrenador.Celular1 = dataReader.GetString(7);
            entrenador.Celular2 = dataReader.GetString(8);
            entrenador.Sueldo = dataReader.GetDouble(9);
            

            return entrenador;
        }

        /*public int ModificarEntrenador(Entrenador entrenador)
        {
            string Id = entrenador.Identificacion;
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add(":PrimerNombre", OracleDbType.Varchar2).Value = entrenador.PrimerNombre;
                command.Parameters.Add(":SegundoNombre", OracleDbType.Varchar2).Value = entrenador.SegundoNombre;
                command.Parameters.Add(":PrimerApellido", OracleDbType.Varchar2).Value = entrenador.PrimerApellido;
                command.Parameters.Add(":SegundoApellido", OracleDbType.Varchar2).Value = entrenador.SegundoApellido;
                command.Parameters.Add(":Sexo", OracleDbType.Varchar2).Value = entrenador.Sexo;
                command.Parameters.Add(":FechaNacimiento", OracleDbType.Date).Value = entrenador.FechaNacimiento;
                command.Parameters.Add(":Telefono1", OracleDbType.Varchar2).Value = entrenador.Celular1;
                command.Parameters.Add(":Telefono2", OracleDbType.Varchar2).Value = entrenador.Celular2;
                command.Parameters.Add(":Sueldo", OracleDbType.Decimal).Value = entrenador.Sueldo;
                command.Parameters.Add(":Id", OracleDbType.Varchar2).Value = Id;

                command.CommandText = "Update entrenador set PrimerNombre = :PrimerNombre," +
                    " SegundoNombre = :SegundoNombre, PrimerApellido = :PrimerApellido," +
                    " SegundoApellido = :SegundoApellido, Sexo = :Sexo, FechaNacimiento = :FechaNacimiento," +
                    " Telefono1 = :Telefono1,Telefono2 = :Telefono2, Sueldo = :Sueldo where IdentificacionEntrenador = :Id";
                                        
                return command.ExecuteNonQuery();
            }
        }*/

        public int ModificarEntrenador(Entrenador entrenador)
        {
            string Id = entrenador.Identificacion;
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "P_ModificarEntrenador";
                command.BindByName = true;

                command.Parameters.Add("P_IdentificacionEntrenador", OracleDbType.Varchar2).Value = Id;
                command.Parameters.Add("P_PrimerNombre", OracleDbType.Varchar2).Value = entrenador.PrimerNombre;
                command.Parameters.Add("P_SegundoNombre", OracleDbType.Varchar2).Value = entrenador.SegundoNombre;
                command.Parameters.Add("P_PrimerApellido", OracleDbType.Varchar2).Value = entrenador.PrimerApellido;
                command.Parameters.Add("P_SegundoApellido", OracleDbType.Varchar2).Value = entrenador.SegundoApellido;
                command.Parameters.Add("P_Sexo", OracleDbType.Varchar2).Value = entrenador.Sexo;
                command.Parameters.Add("P_FechaNacimiento", OracleDbType.Date).Value = entrenador.FechaNacimiento;
                command.Parameters.Add("P_Telefono1", OracleDbType.Varchar2).Value = entrenador.Celular1;
                command.Parameters.Add("P_Telefono2", OracleDbType.Varchar2).Value = entrenador.Celular2;
                command.Parameters.Add("P_Sueldo", OracleDbType.Decimal).Value = entrenador.Sueldo;

                return command.ExecuteNonQuery();
            }
        }

        public int EliminarEntrenador(string IdentificacionEntrenador)
        {
            string Id = IdentificacionEntrenador;
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "P_EliminarEntrenador";
                command.BindByName = true;
                command.Parameters.Add("P_IdentificacionEntrenador", OracleDbType.Varchar2).Value = Id;

                return command.ExecuteNonQuery();
            }
        }
    }
}
