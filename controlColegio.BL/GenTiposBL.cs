using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using controlColegio.MODEL;
using System.Data.Entity;
using controlColegio.BL.General;

namespace controlColegio.BL
{
    public class GenTiposBL
    {
        public void InicializarBD(){
            //Database.SetInitializer<GenTiposDAL>(new CreateDatabaseIfNotExists<GenTiposDAL>());
        }
        public void Agregar()
        {
            //GenTiposModel model = new GenTiposModel();
            //GenTiposE
            gen_tipos model = new gen_tipos();
            model.id = 3;
            model.tipo ="Sexo";
            model.nombre ="Femenino";
            model.sigla = "F";
            model.atributo1 = "M";            
            model.estado = "1";
            GenTiposEntidad ent = new GenTiposEntidad();
            ent.gen_tipos.Add(model);            
            ent.SaveChanges();
            //var tipo = new GenTiposDAL();
            //tipo.Tipo.Add(model);
            //tipo.SaveChanges();

            var listaTipos = from t in ent.gen_tipos
                             select t;
            
            //return listaTipos.Count
            //var i= Convert.ToInt16(listaTipos.Count);
        }
    }
}
