using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCitas.Entidades
{
    class PacienteDTO
    {
        public Int32 Id { get; set; }

        public String Nombre { get; set; }

        public String Apellidos { get; set; }

        public String DNI { get; set; }

        public String Direccion { get; set; }

        public String Telefono { get; set; }

        public String Sexo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Boolean Activo { get; set; }
    }
}
