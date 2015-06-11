using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbusuario
    {
        [MetadataType(typeof(itusuario))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba3()
        {

        }

        public interface itusuario
        {
            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idusuario { get; set; }

            //obligatorio y el tamaño sera de 15 letras
            [Required]
            [StringLength(15)]
            object login { get; set; }

            //obligatorio
            [Required]
            object pass { get; set; }

            //obligatorio, tamaño de id 7 letras
            [Required]
            [StringLength(7)]
            object fid { get; set; }

            //solo tipo email
            [EmailAddress]
            object femail { get; set; }

            [StringLength(20)]
            object fullname { get; set; }

            [Required]
            object gid { get; set; }

            //solo tipo email
            [EmailAddress]
            object gemail { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object creado { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }
            
            [Required]
            object estado { get; set; }



        } 

    }
}