using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Personal
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() { 
       
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPersonal";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
        }

        public void Insertar(string nombre,string apellido,long cuil,string ingreso, int puesto, bool activo ) {
            //PROCEDIMNIENTO
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarPersonal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cuil", cuil);
            comando.Parameters.AddWithValue("@ingreso", ingreso);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@activo", activo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        
        }

        public void Editar(string nombre, string apellido, long cuil, string ingreso, int puesto, bool activo, int id)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPersonal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cuil", cuil);
            comando.Parameters.AddWithValue("@ingreso", ingreso);
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@id",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPersonal";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpersonal",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
