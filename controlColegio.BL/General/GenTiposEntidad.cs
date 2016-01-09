namespace controlColegio.BL.General
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public  class GenTiposEntidad : DbContext
    {
        public GenTiposEntidad()
            : base("name=GenTiposEntidad")
        {
        }

        public virtual DbSet<gen_tipos> gen_tipos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gen_tipos>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<gen_tipos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<gen_tipos>()
                .Property(e => e.sigla)
                .IsUnicode(false);

            modelBuilder.Entity<gen_tipos>()
                .Property(e => e.atributo1)
                .IsUnicode(false);

            modelBuilder.Entity<gen_tipos>()
                .Property(e => e.estado)
                .IsUnicode(false);
        }
    }
}