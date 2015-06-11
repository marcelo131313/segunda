using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcApplication2.Models
{
    public partial class tbcategorias
    {
        [MetadataType(typeof(tbcategorias))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba()
        {

        }


        public interface tbcategorias
        {
            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object idcategorias { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object nombre { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object responsable { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object padre { get; set; }

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
            object idcategorias { get; set; }
        }

    }
}