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
    public partial class LoreImagen : Form
    {
        public LoreImagen(String nombreImagen)
        {
            InitializeComponent();

            // Buscamos en la BD el indice de esa imagen
            string sql = $"SELECT indice FROM imagenes WHERE nombre = '{nombreImagen}'";
            Conexion.SetComando(sql);
            Conexion.SetLector();
            if (Conexion.lector.Read())
            {
                imagenLore.Image = imageList1.Images[Conexion.lector.GetInt32(0)];
            }
            Conexion.lector.Close();
        }

        private void imagenLore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
