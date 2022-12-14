using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class CN_Liquidaciones
    {
        private CD_Liquidaciones objetoCD = new CD_Liquidaciones();
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        int idperiodo = 0;
        int resultado = 0;


        public DataTable MostrarLiquidaciones(string dato, string periodo)
        {
            if (dato == "" && periodo=="")
            {
                tabla = objetoCD.Mostrar();
                return tabla;
            }
            else
            {

                if (dato != "" && periodo == "")
                {
                   if (long.TryParse(dato, out long cuil))
                    {
                        tabla = objetoCD.Buscar("", cuil, "");
                    }
                    else
                        tabla = objetoCD.Buscar(dato, 0, dato);
                }
                else if(dato != "" && periodo != "")
                {
                    int idP=Convert.ToInt32(periodo);

                    if (long.TryParse(dato, out long cuil))
                    {
                        tabla2 = objetoCD.Buscar("", cuil, "");
                    }
                    else
                        tabla2 = objetoCD.Buscar(dato, 0, dato);

                    tabla = tabla2.Select("IdLiquidacion =" + idP).CopyToDataTable();
                }
                else
                {
                    int idP = Convert.ToInt32(periodo);
                    tabla = objetoCD.Buscar(idP);
                }

                return tabla;
            }

        }

        public DataTable MostrarLiquidacionId(string dato)
        {
            tabla = objetoCD.BuscarxID(Convert.ToInt32(dato));
            return tabla;          

        }

        public DataTable InsertarLiquidaciones(string anio, string mes, string tipo)
        {
            CN_Periodos PeriodosCN = new CN_Periodos();
            idperiodo = PeriodosCN.InsertarPeriodo(anio, mes,tipo);
            CD_Personal PersonalCD = new CD_Personal();
            tabla = PersonalCD.MostrarActivos();
            foreach (DataRow row in tabla.Rows)
            {

                int idPersonal = Convert.ToInt32(row["Id"]);
                decimal bruto = Convert.ToDecimal(row["Bruto"]);
                decimal jubilacion = bruto * 11 / 100;
                decimal PAMI = bruto * 3 / 100;
                decimal os = bruto * 3 / 100;
                decimal neto = bruto - jubilacion - PAMI - os;
                objetoCD.Insertar(idPersonal, idperiodo, bruto, jubilacion, PAMI, os, 0, 0, 0, neto);
            }
            tabla = MostrarLiquidaciones("",idperiodo.ToString());
            return tabla;

        }

        public int EditarLiquidaciones(string idliq, string extras, string anticipos, string bonos, string bruto)
        {
            int idliquidacion = Convert.ToInt32(idliq);
            decimal sumabruto = Convert.ToDecimal(bruto) + Convert.ToDecimal(extras) + Convert.ToDecimal(bonos);
            decimal jubilacion = sumabruto * 11 / 100;
            decimal PAMI = sumabruto * 3 / 100;
            decimal os = sumabruto * 3 / 100;
            decimal neto = sumabruto - jubilacion - PAMI - os - Convert.ToDecimal(anticipos);
            resultado=objetoCD.Editar(idliquidacion, Convert.ToDecimal(extras) , Convert.ToDecimal(anticipos), Convert.ToDecimal(bonos), os, PAMI,jubilacion, neto);

            return resultado;
        }

        public void EliminarLiquidacion(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        // anios meses tipo de periodos
        public DataTable MostrarAnios()
        {
            tabla = objetoCD.MostrarAnios();
            return tabla;
        }
        public DataTable MostrarMeses()
        {
            tabla = objetoCD.MostrarMeses();
            return tabla;
        }
        public DataTable MostrarTipos()
        {
            tabla = objetoCD.MostrarTipos();
            return tabla;
        }
        public DataTable MostrarPeriodos()
        {
            tabla = objetoCD.MostrarPeriodos();
            return tabla;
        }
    }
}
