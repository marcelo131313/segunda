using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcApplication2.Models
{
    public partial class tbgaleria
    {
        [MetadataType(typeof(tbgaleria))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba()
        {

        }


        public interface tbgaleria
        {//obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object idimagen { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object nombre { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object descripcion { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object idlugares { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object fechacreacion { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object fechamodificacion { get; set; }


            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object creado { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }


            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object estado { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idimagen { get; set; }
)



        }

    }
}
