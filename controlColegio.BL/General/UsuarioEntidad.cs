using System.Data.Entity;
using System.Linq;
using controlColegio.MODEL;
namespace controlColegio.BL.General
{
    class UsuarioEntidad: DbContext
    {
        public virtual DbSet<UsuarioModel> usuarios { get; set; }
        public UsuarioEntidad()
            : base("name=GenTiposEntidad") { }
    }
}
