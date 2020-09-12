using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductEnum.Models
{

    public enum CategoryType
    {
        Electronicos=10,
        Alimenticios=20,
        Moda=30,
        Belleza=40,
        Automotriz=50,
        libros=60
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

       
        [Display(Name ="Nombre del producto")]
        [Required(ErrorMessage = "debe ingreasar el nombre del producto")]
        public string Name { get; set; }

        
        [Display(Name = "Categoria del producto")]
        [Required(ErrorMessage = "debe ingreasar la categoria del producto")]
        public CategoryType Category { get; set; }
    }
}