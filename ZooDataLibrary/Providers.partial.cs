using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooDataLibrary
{
    [MetadataType(typeof(ProvidersMD))]
    partial class Providers
    {
        public class ProvidersMD
        {
            [HiddenInput(DisplayValue = false)]
            public int Id { get; set; }

            [Display(Name = "Name")]
            public string Name { get; set; }

            [Display(Name = "City")]
            public int City { get; set; }
        }
    }
}
