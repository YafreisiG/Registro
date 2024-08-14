using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class BDGeneral
    {
        public static SqlConnection obtenerConexion() 
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BdPersonas;Data Source=LAPTOP-G5KJU60G");
            conexion.Open();

            return conexion;   
                }
    }
}
