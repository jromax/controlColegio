using System.ComponentModel.DataAnnotations.Schema;
namespace controlColegio.MODEL.General
{
    [Table("control2.gen_tipos")]
    public class GenTiposModel
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
        public string sigla { get; set; }        
        public string atributo1 { get; set; }
        public int estado { get; set; }
    }
}