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
    public class CN_Puestos
    {
        private CD_Puestos objetoCD = new CD_Puestos();

        public DataTable MostrarPuestos()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarPuestos(string puesto, string diassemana, int hssemanales)
        {

            objetoCD.Insertar(puesto, diassemana,Convert.ToInt32(hssemanales));
        }

        public void EditarPuestos(string puesto, string diassemana, int hssemanales, string id)
        {
            objetoCD.Editar(puesto, diassemana, Convert.ToInt32(hssemanales), Convert.ToInt32(id));
        }

        public void EliminarPuestos(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
