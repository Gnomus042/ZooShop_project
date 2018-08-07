using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooDataLibrary
{
    [MetadataType(typeof(OrdersMD))]
    partial class Orders
    {
        public class OrdersMD
        {
            [HiddenInput(DisplayValue = false)]
            public int id { get; set; }

            [Display(Name = "Client")]
            public int Id_client { get; set; }

            [Display(Name = "Product")]
            public int Id_prod { get; set; }

            [Display(Name = "Status")]
            public int Status { get; set; }
        }
    }
}
