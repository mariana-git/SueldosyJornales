using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Threading;

namespace CapaPresentacion
{
    public class CN_Personal
    {
        private CD_Personal objetoCD = new CD_Personal();
        DataTable tabla = new DataTable();


        public DataTable MostrarPersonal(string dato) {


            if (dato == "")
            {
                tabla = objetoCD.Mostrar();
                return tabla;
            }
            else
            {
               if (long.TryParse(dato, out long cuil))
                {
                    tabla = objetoCD.Buscar("", cuil,"");
                }
                else 
                tabla = objetoCD.Buscar(dato, 0,dato);
                return tabla;
            }
            
        }

        public DataTable MostrarPersonalActivo(string dato)
        {


            if (dato == "")
            {
                tabla = objetoCD.MostrarActivos();
                return tabla;
            }
            else
            {
                if (long.TryParse(dato, out long cuil))
                {
                    tabla = objetoCD.BuscarActivo("", cuil, "");
                }
                else
                    tabla = objetoCD.BuscarActivo(dato, 0, dato);
                return tabla;
            }

        }

        public void InsertarPersonal(string nombre, string apellido, string cuil, string ingreso, object puesto, bool activo)
        {

            objetoCD.Insertar(nombre,apellido,Convert.ToInt64(cuil), ingreso,Convert.ToInt32(puesto),activo);
    }

        public void EditarPersonal(string nombre, string apellido, string cuil, string ingreso, object puesto, bool activo,string id)
        {
            objetoCD.Editar(nombre, apellido, Convert.ToInt64(cuil), ingreso, Convert.ToInt32(puesto), activo, Convert.ToInt32(id));
        }

        public void EliminarPersonal(string id) {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
