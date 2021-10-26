using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    class UsuarioRepository
    {
        
        private readonly OracleConnection _connection;

        public UsuarioRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }

        public int GuardarUsuario(Usuario usuario)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert into planes (IdentificacionCliente,
                                        PrimerNombre, SegundoNombre, PrimerApellido , SegundoApellido ,
                                        Sexo ,FechaNacimiento ,Telefono1 ,Telefono2,Peso,Altura, IMC,CodPlan,
                                        IdentificacionEntrenador)
                                        values (:IdentificacionCliente,:PrimerNombre, :SegundoNombre,
                                        :PrimerApellido ,:SegundoApellido, :Sexo ,:FechaNacimiento,
                                        :Telefono1 ,:Telefono2,:Peso,:Altura, :IMC,:CodPlan,:IdentificacionEntrenador)";
                command.Parameters.Add(":IdentificacionCliente", OracleDbType.Varchar2).Value = usuario.Identificacion;
                command.Parameters.Add(":PrimerNombre", OracleDbType.Varchar2).Value = usuario.PrimerNombre;
                command.Parameters.Add(":SegundoNombre", OracleDbType.Varchar2).Value = usuario.SegundoNombre;
                command.Parameters.Add(":PrimerApellido", OracleDbType.Varchar2).Value = usuario.PrimerApellido;
                command.Parameters.Add(":SegundoApellido", OracleDbType.Varchar2).Value = usuario.SegundoApellido;
                command.Parameters.Add(":Sexo", OracleDbType.Char).Value = usuario.Sexo;
                command.Parameters.Add(":FechaNacimiento", OracleDbType.Date).Value = usuario.FechaNacimiento;
                command.Parameters.Add(":Telefono1", OracleDbType.Varchar2).Value = usuario.Celular1;
                command.Parameters.Add(":Telefono2", OracleDbType.Varchar2).Value = usuario.Celular2;
                command.Parameters.Add(":Peso", OracleDbType.Double).Value = usuario.Peso;
                command.Parameters.Add(":Altura", OracleDbType.Double).Value = usuario.Altura;
                command.Parameters.Add(":IMC", OracleDbType.Double).Value = usuario.IndiceMasaCorporal;
                command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = usuario.plan;
                command.Parameters.Add(":IdentificacionEntrenador", OracleDbType.Varchar2).Value = usuario.entrenador;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public Usuario BuscarPorIdentifiacion(string IdentificacionCliente)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add(":IdentificacionCliente", OracleDbType.Varchar2).Value = IdentificacionCliente;
                command.CommandText = "select * from clientes where IdentificacionCliente =:IdentificacionCliente";

                dataReader = command.ExecuteReader();
                dataReader.Read();
                Usuario usuario = DataReaderMapToUsuario(dataReader);
                return usuario;
            }
        }

        public List<Usuario> ConsultarTodosPlanes()
        {
            OracleDataReader dataReader;
            List<Usuario> usuarios = new List<Usuario>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select IdentificacionCliente,"+
                                        "PrimerNombre, SegundoNombre, PrimerApellido , SegundoApellido,"+
                                        "Sexo ,FechaNacimiento ,Telefono1 ,Telefono2,Peso,Altura, IMC,CodPlan,"+
                                        "IdentificacionEntrenado from planes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Usuario usuario = DataReaderMapToUsuario(dataReader);
                        usuarios.Add(usuario);
                    }
                }
            }
            return usuarios;
        }

        private Usuario DataReaderMapToUsuario(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;

            Usuario usuario = new Usuario();

            usuario.Identificacion = dataReader.GetString(0);
            usuario.PrimerNombre = dataReader.GetString(1);
            usuario.SegundoNombre = dataReader.GetString(2);
            usuario.PrimerApellido = dataReader.GetString(3);
            usuario.SegundoApellido = dataReader.GetString(4);
            usuario.Sexo = (char)dataReader.GetChar(5);
            usuario.FechaNacimiento = dataReader.GetDateTime(6);
            usuario.Celular1 = dataReader.GetString(7);
            usuario.Celular2 = dataReader.GetString(8);
            usuario.Peso = dataReader.GetDouble(9);
            usuario.Altura = dataReader.GetDouble(10);
            usuario.IndiceMasaCorporal = dataReader.GetDouble(11);
            usuario.plan.CodigoPlan = dataReader.GetString(12);
            usuario.entrenador.Identificacion = dataReader.GetString(13);

            return usuario;
        }

        public int Modificar(Usuario plan)
        {
            using (var command = _connection.CreateCommand())
            {

                command.Parameters.Add(":NombrePlan", OracleDbType.Varchar2).Value = plan.Nombre;
                command.Parameters.Add(":ValorPlan", OracleDbType.Decimal).Value = plan.ValorPlan;
                command.Parameters.Add(":Duracion", OracleDbType.Int64).Value = plan.Dias;
                command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = plan.CodigoPlan;

                command.CommandText = "UPDATE planes SET NombrePlan = :NombrePlan, ValorPlan = :ValorPlan," +
                    "Duracion = :Duracion WHERE CodPlan = :CodPlan";

                return command.ExecuteNonQuery();
            }
        }

    }
}
