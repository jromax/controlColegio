using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using controlColegio.DATOS.DAL.General;
//using controlColegio.DATOS.BL.General;
using controlColegio.MODEL.General;
using System.Dynamic;
using System.Data;
namespace controlColegio.DATOS.BL.General
{
    public class GenTiposBL
    {
        
        public void InicializarBD(){
            //Database.SetInitializer<GenTiposDAL>(new CreateDatabaseIfNotExists<GenTiposDAL>());
        }
        public dynamic Obtener()
        {
           GenTiposEntidad ent = new GenTiposEntidad();
            //var listaTipos = from t in ent.gen_tipos
            //                select t;
             var registers = (from t in ent.gen_tipos select t).ToList();
             return registers;
            //return listaTipos
        }
        public dynamic Agregar( GenTiposModel model)
        {
            GenTiposEntidad ent = new GenTiposEntidad();
            dynamic respuesta = new ExpandoObject();  respuesta.resultado = true;
            ent.gen_tipos.Add(model);            
            try
            {
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                respuesta.resultado = false;
                respuesta.excepcion = ex;                
            }
            return respuesta;
           

            //var listaTipos = from t in ent.gen_tipos
            //                 select t;
            
            //return listaTipos.Count
            //var i= Convert.ToInt16(listaTipos.Count);
        }
    }
}
