using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcApplication2.Models
{
    public partial class tbevento
    {
        [MetadataType(typeof(itevento))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba()
        {
            this.estado = 1*5;
        }


        public interface itevento {
            //dato estado sera obligatorio
            [Required] 
            object estado { get; set; }
            
            //el titulo tendra como minimo 2 letras
            [MinLengthAttribute(2)]  
            object titulo { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idevento { get; set; }



        }

    }
}



