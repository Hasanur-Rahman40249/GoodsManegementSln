using GoodsManegement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsManegement.Controllers
{
    [Authorize]
    //[Authorize(Roles = "Admin")]
    public class SupplierController:Controller
    {
        private readonly AppDBContext _entities;

        public SupplierController(AppDBContext entities)
        {
            _entities = entities;
        }
        public ViewResult Index()
        {

            return View();
        }


        [HttpGet]
        public JsonResult SupplierList()
        {
            var data = _entities.Suppliers.ToList();

            return Json(data, new Newtonsoft.Json.JsonSerializerSettings());

        }
        [HttpPost]
        public JsonResult AddSupplier([FromBody]Supplier supplier)
        {

            _entities.Suppliers.Add(supplier);
            _entities.SaveChanges();
            var p = _entities.Suppliers.ToList();
            return Json(p, new Newtonsoft.Json.JsonSerializerSettings());

        }
        [HttpPost]
        public JsonResult UpdateSupplier([FromBody]Supplier supplier)
        {
            var upsupplier = _entities.Suppliers.FirstOrDefault(s => s.SupplierId == supplier.SupplierId); 
            upsupplier.SupplierName = supplier.SupplierName;          
            _entities.Entry(upsupplier).State = EntityState.Modified; 
            _entities.SaveChanges();
            var p = _entities.Suppliers.ToList(); 
            return Json(p, new Newtonsoft.Json.JsonSerializerSettings());


        }

        public string DeleteSupplier(int SupplierId)
        {
            var data = _entities.Suppliers
                   .Where(s => s.SupplierId == SupplierId)
                   .Select(s => s)
                   .FirstOrDefault();

            if (data != null)
            {
                _entities.Suppliers.Remove(data);
            }
            _entities.SaveChanges();

            return "Delete Success full";
        }
    }
}
