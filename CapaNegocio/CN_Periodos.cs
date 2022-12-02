using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Periodos
    {
        private CD_Periodos objetoCD = new CD_Periodos();
        DataTable tabla = new DataTable();
        int insertado = 0;


        public DataTable MostrarPeridos(string dato)
        {


            if (dato == "")
            {
                tabla = objetoCD.Mostrar();
                return tabla;
            }
            else
            {
                if (int.TryParse(dato, out int anio))
                {
                    tabla = objetoCD.Buscar(anio, 0, 0);
                }
                else if (int.TryParse(dato, out int mes))
                {
                    tabla = objetoCD.Buscar(0, mes, 0);
                }
                else if (int.TryParse(dato, out int tipo))
                {
                    tabla = objetoCD.Buscar(0, 0, tipo);
                }
                return tabla;
            }

        }

        public int InsertarPeriodo(string idanio, string idmes, string idtipo)
        {

            insertado = objetoCD.Insertar(Convert.ToInt32(idanio), Convert.ToInt32(idmes), Convert.ToInt32(idtipo));
            return insertado;
        }

        public void EditarPerido(int idanio, int idmes, int idtipo, int id)
        {
            objetoCD.Editar( idanio,  idmes,  idtipo, id);
        }

        public void EliminarPeriodo(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public DataTable MostrarAnios(string dato)
        {
            if (dato == "")
            {
                tabla = objetoCD.MostrarAnios();
                return tabla;
            }
            else
            {
               if (int.TryParse(dato, out int tipo))
                {
                   // tabla = objetoCD.Buscar(tipo);
                }
                return tabla;
            }
        }
        public DataTable MostrarMeses(string dato)
        {
            if (dato == "")
            {
                tabla = objetoCD.MostrarMeses();
                return tabla;
            }
            else
            {
                if (int.TryParse(dato, out int tipo))
                {
                    // tabla = objetoCD.Buscar(tipo);
                }
                return tabla;
            }
        }
        public DataTable MostrarTipoPeriodo(string dato)
        {
            if (dato == "")
            {
                tabla = objetoCD.MostrarTiposPeriodo();
                return tabla;
            }
            else
            {
                if (int.TryParse(dato, out int tipo))
                {
                    // tabla = objetoCD.Buscar(tipo);
                }
                return tabla;
            }
        }
    }
}
