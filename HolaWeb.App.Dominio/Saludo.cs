using System;
using System.ComponentModel.DataAnnotations;
namespace HolaWeb.App.Dominio
{
    public class Saludo
    {
        public int Id {get;set;}
        [Required(ErrorMessage = "Este campo es requerido")]
        public string EnEspañol {get;set;}
        [Required]
        [EmailAddress]
        public string EnIngles {get;set;}

        [Required]
        [Range(0,10)]
        public string EnItaliano {get;set;}

    }
}
