﻿using System.ComponentModel.DataAnnotations;
namespace CrudNetMVC.Models

{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Email { get; set; }

        public DateTime FechaCreacion { get; set; }

    }
}
