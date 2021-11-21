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
    public class PlanRepository {
    
        private readonly OracleConnection _connection;

        public PlanRepository(ConnectionManager connection)
        {
            _connection = connection._connection;
        }
        
        /*public int GuardarPlan(Planes plan)
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
        }*/

        public int GuardarPlan(Planes plan)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "agg_plan";
                command.BindByName = true;
                command.Parameters.Add("CodPlan", OracleDbType.Varchar2).Value = plan.CodigoPlan;
                command.Parameters.Add("NombrePlan", OracleDbType.Varchar2).Value = plan.Nombre;
                command.Parameters.Add("ValorPlan", OracleDbType.Decimal).Value = plan.ValorPlan;
                command.Parameters.Add("Duracion", OracleDbType.Int64).Value = plan.Dias;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public Planes BuscarPorCodigoPlan(string CodigoPlan)
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.Parameters.Add(":CodPlan", OracleDbType.Varchar2).Value = CodigoPlan;
                command.CommandText = "select * from planes where CodPlan =:CodPlan";

                dataReader = command.ExecuteReader();
                dataReader.Read();
                Planes plan = DataReaderMapToPlan(dataReader);
                return plan;
            }
        }

        public List<Planes> ConsultarTodosPlanes()
        {
            OracleDataReader dataReader;
            List<Planes> planes = new List<Planes>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select CodPlan,NombrePlan,ValorPlan,Duracion from planes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Planes plan = DataReaderMapToPlan(dataReader);
                        planes.Add(plan);
                    }
                }
            }
            return planes;
        }

       /* public List<Planes> ConsultarTodosPlanes()
        {
            OracleDataReader dataReader;
            List<Planes> planes = new List<Planes>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "F_MostrarPlanes";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Planes plan = DataReaderMapToPlan(dataReader);
                        planes.Add(plan);
                    }
                }
            }
            return planes;
        }*/


            private Planes DataReaderMapToPlan(OracleDataReader dataReader)
            {
            if (!dataReader.HasRows)
                return null;

            Planes plan = new Planes();

            plan.CodigoPlan = dataReader.GetString(0);
            plan.Nombre = dataReader.GetString(1);
            plan.ValorPlan = dataReader.GetDecimal(2);
            plan.Dias = (int)dataReader.GetDouble(3);
            return plan;
        }

        /*public int Modificar(Planes plan)
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
        }*/

        public int Modificar(Planes plan)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "P_ModificarPlan";
                command.BindByName = true;
                command.Parameters.Add("P_CodPlan", OracleDbType.Varchar2).Value = plan.CodigoPlan;
                command.Parameters.Add("P_NombrePlan", OracleDbType.Varchar2).Value = plan.Nombre;
                command.Parameters.Add("P_ValorPlan", OracleDbType.Decimal).Value = plan.ValorPlan;
                command.Parameters.Add("P_Duracion", OracleDbType.Int64).Value = plan.Dias;

                return command.ExecuteNonQuery();
            }
        }

        public int Eliminar(string CodPlan)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "P_EliminarPlan";
                command.BindByName = true;
                command.Parameters.Add("P_CodPlan", OracleDbType.Varchar2).Value = CodPlan;

                return command.ExecuteNonQuery();
            }
        }
    }
}
