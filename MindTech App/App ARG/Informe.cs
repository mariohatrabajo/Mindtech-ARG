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
    public partial class Informe : Form
    {
        public Informe()
        {
            InitializeComponent();
        }

        private void Informe_Load(object sender, EventArgs e)
        {

            String sql = "SELECT lore FROM lore WHERE nombre = 'informe_artefacto'";
            Conexion.SetComando(sql);
            MySqlDataReader lector = Conexion.comando.ExecuteReader();
            while (lector.Read())
            {
                txtLore.Text = lector.GetString(0);
            }
            lector.Close();
        }
    }
}
