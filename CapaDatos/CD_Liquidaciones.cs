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
    public class CD_Liquidaciones
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
            comando.CommandText = "MostrarLiquidaciones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable Buscar(string apellido, long cuil, int legajo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarLiquidacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@cuil", cuil);
            comando.Parameters.AddWithValue("@legajo", legajo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable Buscar(int idperiodo)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarLiquidacionxPeriodo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idperiodo", idperiodo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            comando.Parameters.Clear();
            return tabla;
        }
        public DataTable Buscar(int anio, int mes, int tipo)
        {
            //TODO terminar la busqueda de liquidaciones
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarLiquidacionPeriodo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@mes", mes);
            comando.Parameters.AddWithValue("@tipo", tipo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            comando.Parameters.Clear();
            return tabla;
        }

        public void Insertar(int idPersonal, int idperiodo, decimal bruto, decimal jubilacion, decimal PAMI, decimal os, decimal extras, decimal anticipos, decimal bonos, decimal neto)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarLiquidaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPersonal", idPersonal);
            comando.Parameters.AddWithValue("@idperiodo", idperiodo);
            comando.Parameters.AddWithValue("@bruto", bruto);
            comando.Parameters.AddWithValue("@jubilacion", jubilacion);
            comando.Parameters.AddWithValue("@PAMI", PAMI);
            comando.Parameters.AddWithValue("@os", os);
            comando.Parameters.AddWithValue("@extras", extras);
            comando.Parameters.AddWithValue("@anticipos", anticipos);
            comando.Parameters.AddWithValue("@bonos", bonos);
            comando.Parameters.AddWithValue("@neto", neto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(int idliquidacion, decimal extras, decimal anticipos, decimal bonos, decimal os, decimal PAMI, decimal jubilacion, decimal neto)
        {
            //PROCEDIMNIENTO

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarLiquidaciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", idliquidacion);
            comando.Parameters.AddWithValue("@extras", extras);
            comando.Parameters.AddWithValue("@anticipos", anticipos);
            comando.Parameters.AddWithValue("@bonos", bonos);
            comando.Parameters.AddWithValue("@os", os);
            comando.Parameters.AddWithValue("@PAMI", PAMI);
            comando.Parameters.AddWithValue("@jubilacion", jubilacion);
            comando.Parameters.AddWithValue("@neto", neto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarLiquidacion";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idliquidacion", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


        //cmb anios mes tipo

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
        public DataTable MostrarTipos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTipoPeriodo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public DataTable MostrarPeriodos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarPeriodos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

    }
}
