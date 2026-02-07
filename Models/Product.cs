using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MA_shop.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string  Name {get; set;}
        public decimal Price {get; set;}
        public string Description {get; set;}
        public double Rate {get; set;}
        public String ? Image {get; set;}
       [Display(Name="Category")]
        public int CategoryId {get; set;}
        public Category Category {get; set;}
    }
}