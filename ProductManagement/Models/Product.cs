using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductManagement.Models
{
    public class Product
    {
        [Display(Name="Product Item Code")]
        public int ProductItemCode { get; set; }

        [Required(ErrorMessage="Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Unit price is mandatory")]
        public decimal UnitPrice { get; set; }
    }
}