using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ZooDataLibrary
{
    [MetadataType(typeof(ClientMD))]
    partial class Clients
    {
        public class ClientMD
        {
            [HiddenInput(DisplayValue = false)]
            public int Id { get; set; }

            [Display(Name ="Name")]
            public string Name { get; set; }

            [Display (Name = "Card")]
            public string Card { get; set; }

            [Display (Name = "Tel")]
            public string Tel { get; set; }
        }
    }
}
