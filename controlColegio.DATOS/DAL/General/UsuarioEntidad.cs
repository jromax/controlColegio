﻿using System.Data.Entity;
using System.Linq;
//using controlColegio.MODEL;
namespace controlColegio.DATOS.DAL.General
{
    class UsuarioEntidad: DbContext
    {
        //public virtual DbSet<UsuarioModel> usuarios { get; set; }
        public UsuarioEntidad()
            : base("name=GenTiposEntidad") { }
    }
}
