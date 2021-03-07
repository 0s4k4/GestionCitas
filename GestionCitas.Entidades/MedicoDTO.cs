using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas.Entidades
{
    class MedicoDTO
    {
        public Int32 Id { get; set; }

        public String Nombres { get; set; }

        public String Apellidos { get; set; }

        public String Dni { get; set; }

        public String Direccion { get; set; }

        public String Correo { get; set; }
        public String Telefono { get; set; }

        public String Sexo { get; set; }

        public String NumeroColegiatura { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Boolean Activo { get; set; }

        public List<MedicoEspecialidadDTO>ListaEspecialidad { get; set; } //esta es la lista de especialidades que tiene el medico
    }
}
