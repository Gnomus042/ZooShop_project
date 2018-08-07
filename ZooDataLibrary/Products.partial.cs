using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooDataLibrary
{
    [MetadataType(typeof(ProductsMD))]
    partial class Products
    {
        public class ProductsMD
        {
            [HiddenInput(DisplayValue = false)]
            public int Id { get; set; }

            [Display(Name = "Name")]
            public string Name { get; set; }

            [Display(Name = "Quantity")]
            public int Quantity { get; set; }

            [Display(Name = "Price")]
            public double Price { get; set; }

            [Display(Name = "Info")]
            public string Inf { get; set; }

            [Display(Name = "Animal kind")]
            public int Anim_kind { get; set; }

            [Display(Name = "Product kind")]
            public int Product_kind { get; set; }
        }
    }
}
