using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controlColegio.MODEL;
using controlColegio.DAL;
using System.Data.Entity;
namespace controlColegio.BL
{
    public class GenTiposBL
    {
        public void InicializarBD(){
            //Database.SetInitializer<GenTiposDAL>(new CreateDatabaseIfNotExists<GenTiposDAL>());
        }
        public void Agregar()
        {
            GenTiposModel model = new GenTiposModel();
            model.Id = 1;
            model.Nombre="Sexo";
            model.Atributo1 = "M";
            var tipo = new GenTiposDAL();
            tipo.Tipo.Add(model);
            tipo.SaveChanges();
            var listaTipos = from t in tipo.Tipo
                             select t;
            var i=0;
            //int i = listaTipos.Count;
        }
    }
}
