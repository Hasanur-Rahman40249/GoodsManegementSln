using GoodsManegement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsManegement.Interface
{
    public interface IGoodRepository
    {
        IEnumerable<Good> GetGoods();
        Good AddGood(Good objGood);
        Good GetGoodById(int id);
        Good UpdateGood(Good changeGood);
        void DeleteGood(int id);
        IEnumerable<Supplier> GetSuppliers();
        Good Details(int? id);

    }
}
