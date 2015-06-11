using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MvcApplication2.Models
{
    public class tbcatlugar
    {
        [MetadataType(typeof(tbcatlugar))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba()
        {
            this.estado = 1*5;
        }


        public interface tbcatlugar {

            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object idcatlugares { get; set; }

            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object idcategorias { get; set; }

            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object idlugares { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }


            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object estado { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idcatlugares { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idcategorias { get; set; }

            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idlugares { get; set; }

        }

    }
}