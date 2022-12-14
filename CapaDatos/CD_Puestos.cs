using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Puestos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPuestos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Buscar(string puesto, int hs)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@hs", hs);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            comando.Parameters.Clear();
            return tabla;

        }

        public void Insertar(string puesto, string diassemana, int hssemanales, decimal sueldo)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPuestos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@diasSemana", diassemana);
            comando.Parameters.AddWithValue("@hsSemanales", hssemanales);
            comando.Parameters.AddWithValue("@bruto", sueldo);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Editar(string puesto, string diassemana, int hssemanales, decimal sueldo, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPuestos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@puesto", puesto);
            comando.Parameters.AddWithValue("@diasSemana", diassemana);
            comando.Parameters.AddWithValue("@hsSemanales", hssemanales);
            comando.Parameters.AddWithValue("@bruto", sueldo);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPuestos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idPuestos", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
