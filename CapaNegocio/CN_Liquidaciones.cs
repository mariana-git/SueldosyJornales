using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Liquidaciones
    {
        private CD_Liquidaciones objetoCD = new CD_Liquidaciones();
        DataTable tabla = new DataTable();


        public DataTable MostrarLiquidaciones(string dato)
        {


            if (dato == "")
            {
                tabla = objetoCD.Mostrar();
                return tabla;
            }
            else
            {
                if (long.TryParse(dato, out long cuil))
                {
                    tabla = objetoCD.Buscar("", cuil);
                }
                else
                    tabla = objetoCD.Buscar(dato, 0);
                return tabla;
            }

        }

        public void InsertarPersonal(string nombre, string apellido, string cuil, string ingreso, object puesto, bool activo)
        {

            objetoCD.Insertar(nombre, apellido, Convert.ToInt64(cuil), ingreso, Convert.ToInt32(puesto), activo);
        }

        public void EditarPersonal(string nombre, string apellido, string cuil, string ingreso, object puesto, bool activo, string id)
        {
            objetoCD.Editar(nombre, apellido, Convert.ToInt64(cuil), ingreso, Convert.ToInt32(puesto), activo, Convert.ToInt32(id));
        }

        public void EliminarPersonal(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
