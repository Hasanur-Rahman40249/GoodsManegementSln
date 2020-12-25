using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsManegement.ViewModels
{
    public class GoodViewModel
    {
        public string GoodsName { get; set; }
        public decimal GoodsPrice { get; set; }
        public string UrlImage { get; set; }
        public int SupplierId { get; set; }
    }
}
