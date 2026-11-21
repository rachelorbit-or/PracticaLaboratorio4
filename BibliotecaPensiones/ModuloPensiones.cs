using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPensiones
{
    public class ModuloPensiones
    {
        public static double ObtenerMontoBase(string carrera)
        {
            if (carrera=="SISTEMAS")
            {
                return 400;
            }
            else
            {
                return 350;
            }
        }
        public static double CalcularDescuentoBeca(double montobase,string tieneBeca)
        {
            if (tieneBeca=="SI")
            {
                return montobase * 0.20;//20% descuento , 100.00
            }
            else
            {
                return 0;
            }
        }
        public static double CalcularTotal(double montobase,double descuento )
        {
            return montobase - descuento;
        }
        public static string ConstruirRegistroPipe(string dni, string nombre, string carrera, double total, string fecha)
        {
            return $"{dni}|{nombre}|{carrera}|{total:F2}|{fecha}";
        }

    }
}
