namespace controlColegio.BL.General
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("control2.gen_tipos")]
    public partial class gen_tipos
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(45)]
        public string tipo { get; set; }

        [StringLength(45)]
        public string nombre { get; set; }

        [StringLength(15)]
        public string sigla { get; set; }

        [StringLength(45)]
        public string atributo1 { get; set; }

        [Required]
        [StringLength(1)]
        public string estado { get; set; }
    }
}