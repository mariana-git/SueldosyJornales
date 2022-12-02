using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaDatos
{
    public class CD_Periodos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        int resultado = new int();
        object id = new object();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPeriodos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Buscar(int idanio, int idmes, int idtipo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarPeriodos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idanio", idanio);
            comando.Parameters.AddWithValue("@idmes", idmes);
            comando.Parameters.AddWithValue("@idtipo", idtipo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            comando.Parameters.Clear();
            return tabla;

        }

        public int Insertar(int idanio, int idmes, int idtipo)
        {
            //PROCEDIMNIENTO

            comando.Parameters.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarPeriodos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idanio", idanio);
            comando.Parameters.AddWithValue("@idmes", idmes);
            comando.Parameters.AddWithValue("@idtipo", idtipo);
            //con el siguiente codigo obtengo el ID del registro insertado.
            //en la BD el INSERT debe estar configurado asi:
            //            ALTER proc[dbo].[InsertarPeriodos]
            //            @idmes int,
            //            @idanio int,
            //            @idTipo int
            //             as
            //              DECLARE @ID INT;
            //              insert into Periodos values(@idmes, @idanio, @idtipo)
            //              SET @ID = SCOPE_IDENTITY()
            //              SELECT @ID

            id = comando.ExecuteScalar();
            if (id != null)
            {
                resultado = Convert.ToInt32(id);
            }

            conexion.CerrarConexion();
            return resultado;
            //,,,,,,,
        }

        public void Editar(int idanio, int idmes, int idtipo, int id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPeriodos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idanio", idanio);
            comando.Parameters.AddWithValue("@idmes", idmes);
            comando.Parameters.AddWithValue("@idtipo", idtipo);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPeriodos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public DataTable MostrarAnios()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAnios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarMeses()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMeses";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable MostrarTiposPeriodo()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTipoPeriodo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
    }
}
