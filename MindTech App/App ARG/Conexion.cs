using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_ARG
{
    class Conexion
    {
        private static String pass = "marisma";
        private static String bd = "arg";
        public static MySqlConnection conexion = new MySqlConnection($"server=localhost;user id=root;password={pass};persistsecurityinfo=True;database={bd}");
        public static MySqlCommand comando;
        public static MySqlDataReader lector;

        public static void Abrir()
        {
            conexion.Open();
            SetComando("select id from archivos");
            lector = Conexion.comando.ExecuteReader();
            lector.Close();
        }

        public static void SetComando(String sql)
        {
            comando = new MySqlCommand(sql, Conexion.conexion);
        }

        public static void SetLector()
        {
            if(!lector.IsClosed)
                lector.Close();
            lector = Conexion.comando.ExecuteReader();
        }
    }
}
