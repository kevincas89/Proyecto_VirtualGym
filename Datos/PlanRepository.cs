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
        private readonly OracleConnection _connetion;

        public PlanRepository(ConnectionManager connection)
        {
            _connetion = connection._connection;
        }
        
        public int GuardarPlan(Plan plan)
        {
            using (var command = _connetion.CreateCommand() )
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

    }
}
