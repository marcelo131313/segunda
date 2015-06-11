using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;


namespace MvcApplication2.Models
{
    public class tblugares
    {
        [MetadataType(typeof(tblugares))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba()
        {

        }


        public interface tblugares
        {            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object idlugar { get; set; }

            //obligatorio
            [Required]
            object titulo { get; set; }

            //obligatorio, tamaño de id 7 letrllllllllllllllllllllllllllllllas
            [Required]
            [StringLength(7)]
            object direccion { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object descripcion { get; set; }

            //obligatorio
            [Required]
            object web { get; set; }

            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object lat { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }



            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object estado { get; set; }



            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idlugar { get; set; }




        }

    }
}



