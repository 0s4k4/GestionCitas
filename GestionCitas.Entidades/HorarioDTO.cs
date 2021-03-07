using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas.Entidades
{
    class HorarioDTO
    {

        public Int32 Id { get; set; }
        public Int32 MedicoId { get; set; }
        public DateTime FechaAtencion { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFin { get; set; }
        public Boolean Activo { get; set; }
    }
}
