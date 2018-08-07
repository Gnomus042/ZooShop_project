using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZooDataLibrary;
using System.ComponentModel.DataAnnotations;

namespace ZooWeb.Models
{
    public class OrdersFilter
    {
        public int client { get; set; }

        [Display(Name = "Search by client")]
        public bool useClient { get; set; }
    }

    public class FilterModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; } = " ";

        [Display(Name = "Search by quantity")]
        public bool UseQuantity { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Search by price")]
        public bool UsePrice { get; set; }

        [Display(Name = "Price from")]
        public int PriceFrom { get; set; }

        [Display(Name = "Price to")]
        public int PriceTo { get; set; }

        [Display(Name = "Search by animal kind")]
        public bool UseAnimKind { get; set; }

        [Display(Name = "Animal kind")]
        public int AnimKind { get; set; } = 1;

        [Display(Name = "Search by product kind")]
        public bool UseProdKind { get; set; }

        [Display(Name = "Product kind")]
        public int ProdKind { get; set; } = 1;
    }
}