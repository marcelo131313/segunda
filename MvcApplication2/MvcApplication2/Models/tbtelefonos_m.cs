using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcApplication2.Models
{
    public class tbpago
    {
        [MetadataType(typeof(tbtelefonos))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba()
        {

        }


        public interface tbtelefonos {            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idtelefonos { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object numero { get; set; }

            //obligatorio
            [Required]
            object tipo { get; set; }

            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object codigoarea { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idlugares { get; set; }

              [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object estado { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idtelefonos { get; set; }

        }

    }
}



