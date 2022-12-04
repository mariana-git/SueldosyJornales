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

        public DataTable MostrarPuestos(string dato)
        {

            DataTable tabla = new DataTable();
            if (dato == "")
            {
                tabla = objetoCD.Mostrar();
                return tabla;
            }
            else
            {
                if (int.TryParse(dato, out int hs))
                {
                    tabla = objetoCD.Buscar("", hs);
                }
                else
                    tabla = objetoCD.Buscar(dato, 0);
                return tabla;
            }
            
            
        }

        public void InsertarPuestos(string puesto, string diassemana, string hssemanales, string sueldo)
        {
            if (decimal.TryParse(sueldo, out decimal sueldod))
            {
                objetoCD.Insertar(puesto, diassemana, Convert.ToInt32(hssemanales), sueldod);
            }
            else
                throw new Exception($" {sueldo} no válido.");

        }

        public void EditarPuestos(string puesto, string diassemana, string hssemanales, string sueldo,  string id)
        {
            if (decimal.TryParse(sueldo, out decimal sueldod))
            {
                objetoCD.Editar(puesto, diassemana, Convert.ToInt32(hssemanales), sueldod,  Convert.ToInt32(id));
            }
            else
                throw new Exception($" {sueldo} no válido.");

        }

        public void EliminarPuestos(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
