using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Threading;

namespace CapaNegocio
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
                if (int.TryParse(dato, out int legajo))
                {
                    tabla = objetoCD.Buscar("", 0,legajo);
                }
                else if (long.TryParse(dato, out long cuil))
                {
                    tabla = objetoCD.Buscar("", cuil,0);
                }
                else 
                tabla = objetoCD.Buscar(dato, 0,0);
                return tabla;
            }
            
        }

        public void InsertarPersonal(string nombre, string apellido, string cuil, string ingreso, object puesto, bool activo)
        {

            objetoCD.Insertar(nombre,apellido,Convert.ToInt64(cuil),ingreso,Convert.ToInt32(puesto),activo);
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
