
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web_MVC_NET_5.Models
{
    public class ProduksiStringID
    {
        [Key]
        public string PartNumber { get; set; }
        public string Description { get; set; }
    }
}
