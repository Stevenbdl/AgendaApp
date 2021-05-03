using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AgendaApp
{
    public partial class Window : Form
    {
        bool modoEditar = false;//Se usa para saber si se debe editar un valor o insertar nuevos datos
        public Window()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
        public void ActualizarTabla()
        {
            //Actualiza la tabla cuando se carga la interfaz y luego de insertar, editar o borrar datos
            TablaContactos.DataSource = TablaDatos();
        }
        public DataTable TablaDatos()
        {
            DataTable tabla = new DataTable();
            string consultaString = "SELECT * FROM CONTACTOS";
            
            SqlDataAdapter adaptadorDatos = new SqlDataAdapter(BD.HacerConsulta(consultaString));
            adaptadorDatos.Fill(tabla);

            return tabla;
        }
        public void Guardar()
        {
            //Guardar en la base de datos
            string consultaString = $"INSERT INTO CONTACTOS VALUES('{InputNombre.Text}','{InputNumero.Text}')";

            BD.HacerConsulta(consultaString);

            //Limpiar los campos luego de guardar los datos
            LimpiarCampos();
        }
        public void LimpiarCampos()
        {
            //Limpiar campos
            InputNombre.Text = "";
            InputNumero.Text = "";
        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            //Validacion de campos antes de guardar datos
            if(InputNombre.TextLength > 20 || InputNumero.TextLength > 13)
            {
                MessageBox.Show("Nombre o numero telefonico muy largo");
                return;
            }
            if ((InputNombre.TextLength > 0 && InputNumero.TextLength > 0) || modoEditar == true)
            {
                if (modoEditar == true) Editar();
                else Guardar();

                //Quitar el modo editar
                modoEditar = false;

                //Actualizar la tabla cuando se agreguen o editen datos
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("Por favor llena todos los campos");
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            int filaSeleccionadas = TablaContactos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (filaSeleccionadas > 0)
            {
                //MessageBox.Show(filaSeleccionadas.ToString());
                //Se crea una lista para almacenar los IDs de las filas seleccionadas
                List<string> IDs = new List<string>();
                for(int i = 0;i < filaSeleccionadas; i++)
                {
                    /*Index error al tratar de eliminar multiples elementos
                     */
                    IDs.Add(TablaContactos.SelectedRows[i].Cells["ID"].Value.ToString());
                }
                foreach(string id in IDs)
                {
                    string consultaString = $"DELETE FROM CONTACTOS WHERE ID='{id}'";

                    //Realizar la consulta.
                    BD.HacerConsulta(consultaString);
                }
                //Actualizar la tabla
                ActualizarTabla();
            }
            else
            {
                MessageBox.Show("No se han seleccionado filas");
            }
        }

        public void Editar()
        {
            
            //Se obtiene el unico elemento seleccionado mediante el indice 0
            string id = TablaContactos.SelectedRows[0].Cells["ID"].Value.ToString();

            string consultaString = $"UPDATE CONTACTOS SET Nombre='{InputNombre.Text}', " +
                $"Numero='{InputNumero.Text}' WHERE ID={id}";

            BD.HacerConsulta(consultaString);

            //Limpiar los campos luego de cada consulta
            LimpiarCampos();
        }
        private void EditarBtn_Click(object sender, EventArgs e)
        {
            int filaSeleccionadas = TablaContactos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (filaSeleccionadas == 1)
            {
                //Llenar las cajas de textos para insertar datos con los datos de la fila seleccionada
                InputNombre.Text = TablaContactos.SelectedRows[0].Cells["Nombre"].Value.ToString();
                InputNumero.Text = TablaContactos.SelectedRows[0].Cells["Numero"].Value.ToString();

                modoEditar = true;
            }
            else
            {
                MessageBox.Show("Debe tener una sola fila seleccionada");
            }
        }
    }
}
