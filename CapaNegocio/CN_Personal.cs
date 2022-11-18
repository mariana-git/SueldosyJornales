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
    public class CN_Personal
    {
        private CD_Personal objetoCD = new CD_Personal();

        public DataTable MostrarPersonal() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPersonal(string nombre, string apellido, string cuil, string ingreso, string puesto, bool activo)
        {

            objetoCD.Insertar(nombre,apellido,Convert.ToInt64(cuil),ingreso,Convert.ToInt32(puesto),activo);
    }

        public void EditarPersonal(string nombre, string apellido, string cuil, string ingreso, string puesto, bool activo,string id)
        {
            objetoCD.Editar(nombre, apellido, Convert.ToInt64(cuil), ingreso, Convert.ToInt32(puesto), activo, Convert.ToInt32(id));
        }

        public void EliminarPersonal(string id) {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
