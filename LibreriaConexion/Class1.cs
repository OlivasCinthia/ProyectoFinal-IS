using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaConexion
{
    public class Class1
    {
        static string connectionstr = @"Server=tcp:universidad-itt.database.windows.net,1433;Initial Catalog=ProyectoFIS;Persist Security Info=False;User ID=Administrador;Password=Itt12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con;
            Con = new SqlConnection(connectionstr);
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;
        }
    }
}
