using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_5_Tutorials.Models
{
    [MetadataType(typeof(Product.MetaData))]  
    public partial class Product
    {
       sealed class MetaData
        {
            [Key]
            public System.Guid ProductId { get; set; }

            // [Required]
            [Display(Name="Product Name")]
            [StringLength(10)]
            public string Name { get; set; }

            // [Required]
            [RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]  // we are creating the $ amount
            public string Price { get; set; }
        }

    }
}