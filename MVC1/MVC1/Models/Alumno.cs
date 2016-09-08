using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC1.Models
{
    public class Alumno
    {
        [Required(ErrorMessage = "Por favor ingrese un nombre del alumno.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese por favor un apelludo.")]
        public string Apellido { get; set; }
        
       

    }
}