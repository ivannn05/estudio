using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaAmbulatorioParaExamen.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opc;
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Crear cita");
            Console.WriteLine("2.Eliminar cita");
            Console.WriteLine("3.Pedir ticket");
            opc=Convert.ToInt32(Console.ReadLine());


            return opc;
        }
    }
}
