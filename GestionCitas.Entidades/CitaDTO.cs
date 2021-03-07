using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas.Entidades
{
    class CitaDTO
    {
        public Int32 Id { get; set; }
        public Int32 MedicoId { get; set; }
        public String Medico { get; set; }
        public Int32 PacienteID { get; set; }
        public String PacienteApellidos { get; set; }
        public String PacienteDNI { get; set; }
        public String Estado { get; set; }
        public String Observaciones { get; set; }

        public DateTime FechaAtencion { get; set; }

        public DateTime FechaAtencionInicio { get; set; }

        public DateTime FechaAtencionFin { get; set; }

        public TimeSpan HoraInicio { get; set; }

        public TimeSpan HoraFin { get; set; }

        public Boolean Activo { get; set; }

    }
}
