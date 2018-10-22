using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewPC02_NETFRAMEWORK.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace NewPC02_NETFRAMEWORK.Models
{
    public class ValidateProduct
    {
        [DisplayName("Codigo del producto")]
        [Required(ErrorMessage ="campo requerido")]
        public int idProduct { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        public string name { get; set; }
        public string idCategory { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [Range(10,50)]
        public int price { get; set; }
        public string expirationDate { get; set; }
        [Required(ErrorMessage = "campo requerido")]
        [Range(100,1000)]
        public int unit { get; set; }
    }
}