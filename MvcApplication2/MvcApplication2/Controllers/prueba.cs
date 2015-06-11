using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class prueba : Controller
    {
        //
        // GET: /prueba/

        public ActionResult Index()
        {
            MvcApplication2.Models.puntoencuentroEntities BD=new Models.puntoencuentroEntities();
            MvcApplication2.Models.tbevento n= new Models.tbevento();
            MvcApplication2.Models.tbpersona p = new Models.tbpersona();
            MvcApplication2.Models.tbusuario u = new Models.tbusuario();
            n.estado = 1;
            n.titulo = "op";
                BD.tbevento.Add(n);
                try
                {
                    if (BD.SaveChanges() == 1) //guarda cambios
                    {
                        //correcto
                    }
                    else
                    {
                        //erroree en informacion
                    }
                }
                catch { 
                
                }
        }

    }

}
