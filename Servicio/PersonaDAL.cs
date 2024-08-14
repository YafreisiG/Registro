using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class PersonaDAL
    {

        public static int AgregarPersona(DBPersona persona)
        {
            int retorna = 0; 

            using (SqlConnection conexion = BDGeneral.obtenerConexion())
                    {
                string query = "insert into persona (Nombre,Edad,Celular) values('"+persona.Nombre+"', "+persona.Edad+", '"+persona.Celular+"' )";
                      SqlCommand comando = new SqlCommand(query, conexion);  
                
                retorna = comando.ExecuteNonQuery();  
                    }

            return retorna;
        }

        public static List<DBPersona> PresentarRegistro()
        {
            List<DBPersona> list = new List<DBPersona>();
            using (SqlConnection conexion = BDGeneral.obtenerConexion())
            {
                string query = "select *from persona";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    DBPersona persona = new DBPersona();
                    persona.id = reader.GetInt32(0);
                    persona.Nombre = reader.GetString(1);
                    persona.Edad = reader.GetInt32(2);
                    persona.Celular = reader.GetString(3);
                    list.Add(persona);
                }
                conexion.Close();
                return list;
            }
        }

        public static int ModificarPersona(DBPersona persona)
        {
            int result = 0; 
            using(SqlConnection conexion = BDGeneral.obtenerConexion())
            {
                string query = "update persona set nombre = '"+persona.Nombre+"', edad="+persona.Edad+", celular='"+persona.Celular+"' where id= "+persona.id+" ";
                SqlCommand comando = new SqlCommand(query, conexion);

                result = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return result;
        }



        public static int EliminarPersona(int id)
        {
            int retorna = 0;

            using (SqlConnection conexion = BDGeneral.obtenerConexion())
            {
                string query = "delete from persona where id=" + id + ""; 
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }

            return retorna;
        }
    }

}
