using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public partial class tbpersona
    {
        [MetadataType(typeof(itpersona))]
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {
            
        }


        public interface itpersona
        {
            //dato estado sera obligatorio
            [Key]
            [ScaffoldColumn(false)] //no sera visaulizado
            object idpersona { get; set; }

            //el titulo tendra como minimo 2 letras
            [MinLengthAttribute(2)]
            object nombre { get; set; }

            //el titulo tendra como minimo 3 letras
            [MinLengthAttribute(3)]
            object paterno { get; set; }

            //el titulo tendra como minimo 3 letras
            [MinLengthAttribute(3)]
            object materno { get; set; }

            //le damos un rago de 7 a 9 letras para el ID
            [Range(600000,900000)]
            object ci { get; set; }

            //no se podra editar, y eltipo debe ser de datetime
            [Editable(false)] 
            [DataType(DataType.DateTime,ErrorMessage="debe introducir una fecha valida")]
            object fechanac { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }
            
            [Required]
            object estado { get; set; }



        } 

    }
}