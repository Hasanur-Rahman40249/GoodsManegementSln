using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodsManegement.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsManegement.Interface
{
    public class GoodRepository : IGoodRepository
    {
        private readonly AppDBContext _goodContext;

        public GoodRepository(AppDBContext goodContext)
        {
            _goodContext = goodContext;
        }
        public Good AddGood(Good objGood)
        {
            _goodContext.Goods.Add(objGood);
            _goodContext.SaveChanges();
            return objGood;
        }

        public void DeleteGood(int id)
        {
            var data = GetGoodById(id);
            if (data != null)
            {
                _goodContext.Remove(data);
            }
            _goodContext.SaveChanges();
        }

        public Good GetGoodById(int id)
        {
            Good good = _goodContext.Goods.FirstOrDefault(g => g.GoodsId == id);
            return good;
        }


        public IEnumerable<Supplier> GetSuppliers()
        {
            var data = _goodContext.Suppliers.ToList();
            return data;
        }

        public IEnumerable<Good> GetGoods()
        {
            var data = _goodContext.Goods.Select(g => new Good
            {
                GoodsId = g.GoodsId,
                GoodsName = g.GoodsName,
                GoodsPrice = g.GoodsPrice,
                SupplierId = g.SupplierId,
                UrlImage = g.UrlImage,
                Supplier = _goodContext.Suppliers.Where(s => s.SupplierId == s.SupplierId).FirstOrDefault()
            }).ToList();
            return data;
        }

       

        public Good UpdateGood(Good changeGood)
        {
            var good = _goodContext.Goods.Attach(changeGood);
            good.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _goodContext.SaveChanges();
            return changeGood;
        }

        public Good Details(int? id)
        {
            return _goodContext.Goods
                 .Include(s => s.Supplier).FirstOrDefault();
        }
    }
}
