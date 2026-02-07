using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MA_shop.Models
{

    public class Category
    {
        public int Id {get; set;}
        [Column("varchar(30)")]
        [MaxLength(30), MinLength(3)]
        public string Name {get; set;}
//public List<Product> Products {get; set;}
        
    }

    internal class requiredAttribute : Attribute
    {
    }
}