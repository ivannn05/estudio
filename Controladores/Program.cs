using pruebaAmbulatorioParaExamen.Dtos;
using pruebaAmbulatorioParaExamen.Servicios;

namespace pruebaAmbulatorioParaExamen.Controladores
{
   
    class Program
    {
        public static List<PacienteDto> lista = new List<PacienteDto>();

        public static void Main(string[] args)
        {
            bool cerrarMenu=false;
            int opc;
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz op = new OperativaImplementacion();

            while(!cerrarMenu)
            {
                opc = mi.mostrarMenu();
                switch(opc)
                {
                    case 0:
                        Console.WriteLine("Eligio cerrar menu");
                        cerrarMenu = true;
                        break;
                    case 1:
                        op.anidirCita();
                        Console.WriteLine("Eligio aniadir cita");
                        break;
                    case 2:
                        Console.WriteLine("Eligio eliminar cita");
                        break;
                    case 3:
                        foreach(PacienteDto p in lista)
                        {
                            Console.WriteLine(p.ToString());
                        }
                        Console.WriteLine("Se mostraron los pacientes");
                        break;
                    case 4:
                        Console.WriteLine("Eligio pedir ticket");
                        break;
                    default: Console.WriteLine("Esta opcion noo existe");
                        break;

                }
            }



        }
    }
}
