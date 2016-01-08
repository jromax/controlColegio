using controlColegio.MODEL;
using System.Data.Entity;
namespace controlColegio.DAL
{
    public class GenTiposDAL:DbContext
    {
        public DbSet<GenTiposModel> Tipo { get; set; }
    }
}
