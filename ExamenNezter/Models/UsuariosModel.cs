using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenNezter.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Cp { get; set; }
        public int Id_ciudad { get; set; }
        public int Id_tipo_usuario { get; set; }
        public string Contrasena { get; set; }
    }
}
