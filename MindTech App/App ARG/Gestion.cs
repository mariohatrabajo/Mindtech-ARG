using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ARG
{
    public partial class Gestion : Form
    {
       int colNombre = 2, colApell = 3, colSecreto = 8;

        public Gestion()
        {
            InitializeComponent();
            cargando.BringToFront();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'argDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.argDataSet.empleados);
            // TODO: esta línea de código carga datos en la tabla 'argDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.argDataSet.empleados);

            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            statusNumEmp.Text = tabla.RowCount.ToString();
            tabla.Sort(tabla.Columns[colNombre], ListSortDirection.Ascending);

            cargando.SendToBack();
        }

        private void VerDatos(object sender, EventArgs e)
        {
            DatosEmpleado form = new DatosEmpleado(tabla.CurrentRow.Cells[colSecreto].Value.ToString());

            // Cargamos los datos
            form.txtNombre.Text = tabla.CurrentRow.Cells[colNombre].Value.ToString();
            form.txtApellidos.Text = tabla.CurrentRow.Cells[colApell].Value.ToString();
            form.txtDNI.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            form.txtCodigo.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            form.txtEquipo.Text = tabla.CurrentRow.Cells[5].Value.ToString();
            form.txtFecNa.Text = tabla.CurrentRow.Cells[6].Value.ToString();
            form.txtFecCo.Text = tabla.CurrentRow.Cells[7].Value.ToString();

            form.Show();
        }

        // Busca en el datagridview por nombre o apellido
        private void buscador_TextChanged(object sender, EventArgs e)
        {
            if (buscador.Text != buscador.Hint)
            {
                // Buscar por nombre, apellidos o secreto
                for (int i = 0; i < tabla.RowCount; i++)
                {
                    tabla.CurrentCell = null;
                    String nombreCompleto = tabla.Rows[i].Cells[colNombre].Value.ToString().ToUpper() + " " + tabla.Rows[i].Cells[colApell].Value.ToString().ToUpper();
                    bool nombre = nombreCompleto.StartsWith(buscador.Text.ToUpper());
                    bool apellidos = tabla.Rows[i].Cells[colApell].Value.ToString().ToUpper().StartsWith(buscador.Text.ToUpper());
                    bool buscar = tabla.Rows[i].Cells[colSecreto].Value.ToString().ToLower().Equals("buscar:" + buscador.Text.ToLower());
                    bool buscarCS = tabla.Rows[i].Cells[colSecreto].Value.ToString().Equals("buscarCS:" + buscador.Text);
                    tabla.Rows[i].Visible = (nombre || apellidos || buscar || buscarCS);
                }
            }
            else
            {
                // Hacemos visible todas las filas
                for (int i = 0; i < tabla.RowCount; i++)
                {
                    tabla.Rows[i].Visible = true;
                }
            }
        }
    }
}
