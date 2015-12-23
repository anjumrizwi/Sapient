using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GloboMart.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProductType Type { get; set; }
        public decimal Price { get; set; }
    }

    public enum ProductType
    {
        Electronics = 1,
        Furniture = 1
    }
}