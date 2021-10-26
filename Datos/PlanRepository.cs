using Entidad;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PlanRepository
    {
        private readonly OracleConnection _connection;

        public PlanRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }
        
        public int GuardarPlan(Usuario plan)
        {
            using (var command = _connection.CreateCommand() )
            {
                command.CommandText = @"Insert into planes (CodPlan,NombrePlan,ValorPlan,Duracion)
                                        values (:CodPlan,:NombrePlan,:ValorPlan,:Duracion)";
                command.Parameters.Add(":CodPlan",OracleDbType.Varchar2).Value=plan.CodigoPlan;
                command.Parameters.Add(":NombrePlan", OracleDbType.Varchar2).Value = plan.Nombre;
                command.Parameters.Add(":ValorPlan", OracleDbType.Decimal).Value = plan.ValorPlan;
                command.Parameters.Add(":Duracion",OracleDbType.Int64).Value = plan.Dias;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public Usuario BuscarPorCodigoPlan(string CodigoPlan)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = CodigoPlan;
                command.CommandText = "select * from planes where CodPlan =:CodPlan";

                dataReader = command.ExecuteReader();
                dataReader.Read();
                Usuario plan = DataReaderMapToPlan(dataReader);
                return plan;
            }
        }

        public List<Usuario> ConsultarTodosPlanes()
        {
            OracleDataReader dataReader;
            List<Usuario> planes = new List<Usuario>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select CodPlan,NombrePlan,ValorPlan,Duracion from planes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Usuario plan = DataReaderMapToPlan(dataReader);
                        planes.Add(plan);
                    }
                }
            }
            return planes;
        }

        private Usuario DataReaderMapToPlan(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows)
                return null;

            Usuario plan = new Usuario();

            plan.CodigoPlan = dataReader.GetString(0);
            plan.Nombre = dataReader.GetString(1);
            plan.ValorPlan = dataReader.GetDecimal(2);
            plan.Dias = (int)dataReader.GetDouble(3);
            return plan;
        }

        public int Modificar(Usuario plan)
        {
            using (var command = _connection.CreateCommand())
            {
                
                command.Parameters.Add(":NombrePlan", OracleDbType.Varchar2).Value = plan.Nombre;
                command.Parameters.Add(":ValorPlan", OracleDbType.Decimal).Value = plan.ValorPlan;
                command.Parameters.Add(":Duracion", OracleDbType.Int64).Value = plan.Dias;
                command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = plan.CodigoPlan;

                command.CommandText = "UPDATE planes SET NombrePlan = :NombrePlan, ValorPlan = :ValorPlan,"+
                    "Duracion = :Duracion WHERE CodPlan = :CodPlan";
                
                return command.ExecuteNonQuery();
            }
        }

    }
}
