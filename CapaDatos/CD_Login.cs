using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaSoporte;

namespace CapaDatos
{
    public class CD_Login
    {
        private readonly string str = "Server=(local);DataBase= SistemaSueldos;Integrated Security=true";
        public string Usuario { private get; set; }
        public string Clave { private get; set; }
        public int Intentos { private get; set; }


        protected SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection(str);
            if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            sqlConnection.Open();
            return sqlConnection;
        }

        protected int ScalarQ(string query)
        {
            using (SqlConnection Conexion = Connect())
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
                Conexion.Open();
                using (SqlCommand Comando = new SqlCommand(query, Conexion))
                {
                    return Convert.ToInt32(Comando.ExecuteScalar());
                }
            }
        }

        protected DataTable ReaderQ(string query)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = query;
                    SqlDataReader leer = Command.ExecuteReader();
                    using (DataTable DT = new DataTable())
                    {
                        DT.Load(leer);
                        return DT;
                    }
                }
            }
        }
        protected int NonQueryQ(string query)
        {
            using (SqlCommand Command = new SqlCommand())
            {
                using (Command.Connection = Connect())
                {
                    Command.CommandTimeout = 15;
                    Command.CommandType = CommandType.Text;
                    Command.CommandText = query;
                    return Command.ExecuteNonQuery();
                }
            }
        }


        public void Users_Read()
        {
            using (DataTable dt = ReaderQ($"SELECT u.IDUSUARIO,IDDIRECTORIO, USUARIO, TIPOPERM " +
                $"FROM Usuarios u, Permisos p, UsuPerm up WHERE u.IDUSUARIO = up.IDUSUARIO " +
                $"AND up.IDPERMISO = p.IDPERMISO " +
                $"AND (USUARIO = '{Usuario}' AND CLAVE = '{Clave}')"))
            {
                //cargo en la Capa Soporte los datos del usuario 
                CS_UsuarioActivo.IdUsuario = Convert.ToInt32(dt.Rows[0]["IDUSUARIO"]);
                CS_UsuarioActivo.IdDirectorio = Convert.ToInt32(dt.Rows[0]["IDDIRECTORIO"]);
                CS_UsuarioActivo.Usuario = dt.Rows[0]["USUARIO"].ToString();
                CS_UsuarioActivo.TipoPermiso = dt.Rows[0]["TIPOPERM"].ToString();
            }
            ;
        }
        public int UpdateUserLoginTry()
        {
            return NonQueryQ($"UPDATE Usuarios SET INTENTOS = {Intentos} WHERE USUARIO = '{Usuario}'");
        }

        public int BlockUserLoginTry()
        {
            return NonQueryQ($"UPDATE Usuarios SET IDDIRECTORIO = 2 WHERE USUARIO = '{Usuario}'");
        }

        public int Users_Search()
        {
            return ScalarQ($"SELECT COUNT(*) FROM Usuarios WHERE USUARIO = '{Usuario}'");
        }
        public int UsersPass_Search()
        {
            return ScalarQ($"SELECT COUNT(*) FROM Usuarios WHERE USUARIO = '{Usuario}' AND CLAVE = '{Clave}'");
        }
        public int UsersLoginTry_Search()
        {
            return ScalarQ($"SELECT INTENTOS FROM Usuarios WHERE USUARIO = '{Usuario}'");
        }
        public int UsersDirectory_Search()
        {
            return ScalarQ($"SELECT IDDIRECTORIO FROM Usuarios WHERE USUARIO = '{Usuario}'");
        }
    }
}
