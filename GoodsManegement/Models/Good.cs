using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsManegement.Models
{
    public class Good
    {
        [Key]
        public int GoodsId { get; set; }
        public string GoodsName { get; set; }
        public decimal GoodsPrice { get; set; }       
        public string ImageName { get; set; }
        public string UrlImage { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

    }
}
