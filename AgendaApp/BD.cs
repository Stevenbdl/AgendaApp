using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaApp
{
    class BD
    {
        public static SqlConnection Conectar()
        {
            string conString = "Server = DESKTOP-NB7JEUO\\STEVENBDL; " +
                "Initial Catalog = AGENDA; USER ID = sa; Password = stevenbdl30";
            /*Objeto SqlConnection, es el que se devuelve y se puede utilizar para cerrar la conexion
            fuera de la la funcion*/
            SqlConnection conexion = new SqlConnection(conString);

            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al abrir la conexion a la base de datos");
            }
            return conexion;
        }

        public static SqlCommand HacerConsulta(string consultaString)
        {
            SqlCommand Sql = new SqlCommand(consultaString, Conectar());
            Sql.ExecuteNonQuery();
            return Sql;
        }
    }
}
