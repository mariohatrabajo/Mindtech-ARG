using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_ARG
{
    public partial class VentanaPpal : Form
    {
        public VentanaPpal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Abrir();
            comprobarAccesoCmd();
        }

        // Abre la cmd simulada
        private void terminalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.FileName = "java";
            // TODO Meter el jar en proyecto y hacer la ruta relativa
            myProcess.StartInfo.Arguments = "-jar D:/io/JavaWorkspace/TFG_Servidor/bin/Servidor/cmd.jar";
            //myProcess.StartInfo.Arguments = "-jar ../Cmd/bin/Servidor/cmd.jar";
            myProcess.Start();
        }

        private void getiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gestion form = new Gestion();
            form.Show();
        }

        // Comprobamos si tiene que estar el boton de la cmd
        private void comprobarAccesoCmd(object sender, EventArgs e)
        {
            comprobarAccesoCmd();
        }

        private void comprobarAccesoCmd()
        {
            String sql = "SELECT valor FROM progreso WHERE nombre = 'desbl_cmd'";
            Conexion.SetComando(sql);
            Conexion.SetLector();
            while (Conexion.lector.Read())
            {
                cmdBoton.Visible = Conexion.lector.GetInt32(0) == 1;
                if(Conexion.lector.GetInt32(0) == 1)
                    timer1.Stop();
            }
            Conexion.lector.Close();
        }
    }
}
