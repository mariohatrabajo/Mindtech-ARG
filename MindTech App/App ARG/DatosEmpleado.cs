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
    public partial class DatosEmpleado : Form
    {
        String secreto;
        public DatosEmpleado(string secreto)
        {
            InitializeComponent();

            LoreImagen img;
            LoreTexto txt;
            Informe inf;
            this.secreto = secreto;
            switch (secreto)
            {
                case "folleto":
                    img = new LoreImagen(secreto);
                    img.ShowDialog();
                    break;
                case "buscar:cosmo armonia":
                    txt = new LoreTexto("informe_ia");
                    txt.ShowDialog();
                    break;
                case "presentacion_elia":
                case "la_gran_mente":
                    txt = new LoreTexto(secreto, Color.Firebrick);
                    txt.ShowDialog();
                    break;
                case "desbl_cmd":
                    btnDesbl.Visible = true;
                    break;
                case "mente_conjunta":
                    String sql = "SELECT * FROM archivos WHERE nombre like 'GM-9625_4.txt' AND padre = 29 AND contenido like '62a77cddd8b3962a77cec423b2\n'";
                    Conexion.SetComando(sql);
                    Conexion.SetLector();
                    if (Conexion.lector.Read())
                    {
                        txt = new LoreTexto(secreto, Color.Firebrick);
                        txt.ShowDialog();
                    }
                    else
                    {
                        txtError.Text = "Falta el archivo 'C:/MindTech/ProyectoGM/SujetosGM/GM-9625/GM-9625_4.txt'\n\r" +
                            "62a77cddd8b3962a77cec423b2";
                        txtError.ForeColor = Color.DarkRed;
                        txtError.Visible = true;
                        txtCodigo.PasswordChar = '█';
                        txtDNI.PasswordChar = '█';
                        txtNombre.PasswordChar = '█';
                        txtApellidos.PasswordChar = '█';
                        txtFecNa.PasswordChar = '█';
                        txtFecCo.PasswordChar = '█';
                        txtEquipo.PasswordChar = '█';
                    }
                    Conexion.lector.Close();
                    break;
                case "buscar:Artefacto":
                    inf = new Informe();
                    inf.ShowDialog();
                    break;
                case "buscar:Dimensional":
                    this.Text = "GM-2735";
                    txt = new LoreTexto("exploracion", Color.Firebrick);
                    txt.ShowDialog();
                    break;
                case "buscar:TESTIGO":
                    img = new LoreImagen("GM");
                    img.ShowDialog();
                    break;
                case "buscar:Despertar":
                    txt = new LoreTexto("el_ultimo_paso", Color.Firebrick);
                    txt.ShowDialog();
                    break;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Cuando clickas fuera de cualquier control, el focus vuelve al botón de aceptar
        private void Ventana_Click(object sender, EventArgs e)
        {
            buttonOk.Focus();
        }

        // Al clickar el botón se desbloquea la cmd o la dba
        private void btnDesbl_Click(object sender, EventArgs e)
        {
            String sql = "UPDATE progreso SET valor = 1 WHERE nombre like '"+secreto+"'";
            Conexion.SetComando(sql);
            Conexion.comando.ExecuteNonQuery();
            if(secreto.Equals("desbl_cmd"))
                MessageBox.Show("Se ha concedido acceso a Cmd.exe", "Desbloquear Cmd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(secreto.Equals("desbl_dba"))
                MessageBox.Show("Se han ofrecido permisos de DBA.", "Desbloquear DBA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
