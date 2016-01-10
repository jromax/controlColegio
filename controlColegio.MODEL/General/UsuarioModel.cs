using System.ComponentModel.DataAnnotations.Schema;

namespace controlColegio.MODEL.General
{
    [Table("control2.usuarios")]
    public class UsuarioModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public int estado_reg { get; set; } 
    }
}