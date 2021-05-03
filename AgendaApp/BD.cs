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
            /*Server = Nombre de tu instancia del servidor en SQL Server.
             * Initial Catalog = Nombre de tu base de datos(Como asumo que le dejarás AGENDA le dejo el mismo nombre).
             * USER ID = Tu usuario nombre de usuario creado para conectarte con la base de datos.
             * Password = La contraseña asociada con ese nombre de usuario.
            */
            string conString = "Server = <nombre de tu instancia del servidor>; " +
                "Initial Catalog = AGENDA; USER ID = <tu usuario>; Password = <tu contraseña>";

            /*Objeto SqlConnection, es el que se devuelve y se puede utilizar para cerrar la conexion
            fuera de la la funcion*/
            SqlConnection conexion = new SqlConnection(conString);

            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al abrir la conexion a la base de datos " + e.ToString());
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
