using pruebaAmbulatorioParaExamen.Controladores;
using pruebaAmbulatorioParaExamen.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaAmbulatorioParaExamen.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void anidirCita()
        {
            PacienteDto paciente = new PacienteDto();
            paciente.IdPaciente = incrementoId();
            Console.WriteLine("Escriba el nombre del paciente");
            paciente.NombrePaciente = Console.ReadLine();
            Console.WriteLine("Escriba el DNI del paciente");
            paciente.DniPaciente = Console.ReadLine();
            Console.WriteLine("Fecha de la cita ="+paciente.FechaSolicitudCita.AddDays(2).ToString("dd-MM-yyyy hh:mm"));
            
            Program.lista.Add(paciente);
        }
        private long incrementoId()
        {
            long nuevoId;
            if (Program.lista.Count == 0)
            {
                nuevoId = 1;
            }
            else
            {
                int psn= Program.lista.Count;
                nuevoId=Program.lista[psn].IdPaciente + 1;
            }

            return nuevoId;

        }

        public void eliminarCita()
        {
            Console.WriteLine("Escriba el DNI del cliente a eliminar");
            string dni=Console.ReadLine();
            PacienteDto pacienteAEliminar= new PacienteDto();
            foreach(PacienteDto p in  Program.lista)
            {

            }
        }

        public void pedirTicketCita()
        {
            throw new NotImplementedException();
        }
    }
}
