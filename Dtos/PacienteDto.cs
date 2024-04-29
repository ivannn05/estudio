using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaAmbulatorioParaExamen.Dtos
{
    internal class PacienteDto
    {
        long idPaciente;
        string nombrePaciente = "aaaa";
        string dniPaciente = "aaaa";
        DateTime fechaSolicitudCita = DateTime.Now;
        DateTime fechaPedidaTicket = new DateTime(9999, 12, 31);

        public PacienteDto()
        {
        }

        public PacienteDto(long idPaciente,string nombrePaciente, string dniPaciente, DateTime fechaSolicitudCita, DateTime fechaPedidaTicket)
        {
            this.idPaciente= idPaciente;
            this.nombrePaciente = nombrePaciente;
            this.dniPaciente = dniPaciente;
            this.fechaSolicitudCita = fechaSolicitudCita;
            this.fechaPedidaTicket = fechaPedidaTicket;
        }

        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string DniPaciente { get => dniPaciente; set => dniPaciente = value; }
        public DateTime FechaSolicitudCita { get => fechaSolicitudCita; set => fechaSolicitudCita = value; }
        public DateTime FechaPedidaTicket { get => fechaPedidaTicket; set => fechaPedidaTicket = value; }
        public long IdPaciente { get => idPaciente; set => idPaciente = value; }

        override 

            public string ToString()
        {
            string contenido = "Numero de cliente=" + this.idPaciente + "\n" +
                "Nombre cliente=" + this.nombrePaciente + "\n" +
                "DNI paciente=" + this.dniPaciente + "\n" +
                "Fecha de su cita=" + this.fechaSolicitudCita.AddDays(5).ToString("dd-MM-yyyy hh:mm");

            return contenido;
        }
        public string ToStringFichero()
        {
            string contenido =this.idPaciente+";"+this.nombrePaciente+";"+ this.dniPaciente+";"+this.fechaSolicitudCita;



                return contenido;
        }
    }
}
