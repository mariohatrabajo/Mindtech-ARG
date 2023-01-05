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
    public partial class LoreTexto : Form
    {
        public LoreTexto(String nombreLore) : this(nombreLore, Color.Teal)
        {}
        public LoreTexto(String nombreLore, Color color)
        {
            InitializeComponent();

            tbLore.ForeColor = color;

            string sql = $"SELECT lore FROM lore WHERE nombre = '{nombreLore}'";
            Conexion.SetComando(sql);
            Conexion.SetLector();
            if (Conexion.lector.Read())
            {
                tbLore.Text = Conexion.lector.GetString(0);
            }
            else
            {
                tbLore.Text = "Nombre de lore incorrecto.";
            }

            Conexion.lector.Close();
        }
    }
}
