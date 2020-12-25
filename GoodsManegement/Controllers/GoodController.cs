using GoodsManegement.Interface;
using GoodsManegement.Models;
using GoodsManegement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GoodsManegement.Controllers
{
    [Authorize]
    public class GoodController:Controller
    {
        private readonly IGoodRepository _goodRepository;
        private readonly IHostingEnvironment _hostingEnviorment;

        public GoodController(IGoodRepository goodRepository,IHostingEnvironment hostingEnviorment)
        {
            _goodRepository = goodRepository;
            _hostingEnviorment = hostingEnviorment;
        }
        [AllowAnonymous]
        public IActionResult Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewData["CurrentFilter"] = searchString;
            var data = _goodRepository.GetGoods();
            
            if (!string.IsNullOrEmpty(searchString))
            {
                data = data.Where(g => g.GoodsName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    data = data.OrderBy(g => g.GoodsName);
                    break;
                default:
                    data = data.OrderByDescending(g => g.GoodsName);
                    break;
            }
            int pageSize = 3;
            return View(PaginetedList<Good>.Create(data.AsQueryable<Good>(), pageNumber ?? 1, pageSize));
        }
        [HttpGet]
      
        public IActionResult Create()
        {
            SupplierDDL();
            return View();
        }
        [HttpPost]
        public IActionResult Create(GoodViewModel model)
        {
            if (ModelState.IsValid)
            {
                string UrlImage = "";
                var files = HttpContext.Request.Form.Files;
                foreach (var image in files)
                {
                    if (image != null && image.Length > 0)
                    {
                        var file = image;
                        var uploadFile = Path.Combine(_hostingEnviorment.WebRootPath, "imags");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("_", "") + file.FileName;
                            using (var fileStream = new FileStream(Path.Combine(uploadFile, fileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                                UrlImage = fileName;
                            }
                        }
                    }
                }
                var data = new Good()
                {
                    GoodsName = model.GoodsName,
                    GoodsPrice = model.GoodsPrice,
                    SupplierId = model.SupplierId,
                    UrlImage = UrlImage
                };
                _goodRepository.AddGood(data);
                return RedirectToAction("Index");
            }

            SupplierDDL();
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var good = _goodRepository.GetGoodById(id);
            SupplierDDL();
            return View(good);
        }
        [HttpPost]
        public IActionResult Edit(int id, Good changeGood)
        {
            if (ModelState.IsValid)
            {
                string UrlImage = "";
                var files = HttpContext.Request.Form.Files;
                foreach (var Image in files)
                {
                    if (Image != null && Image.Length > 0)
                    {
                        var file = Image;
                        var uploadfile = Path.Combine(_hostingEnviorment.WebRootPath, "imags");
                        if (file.Length > 0)
                        {
                            var fileName = Guid.NewGuid().ToString().Replace("_", "") + file.FileName;
                            using (var fileStream = new FileStream(Path.Combine(uploadfile, fileName), FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                                UrlImage = fileName;
                            }
                        }
                    }
                }
                var data = _goodRepository.GetGoodById(id);
                data.GoodsName = changeGood.GoodsName;
                data.GoodsPrice = changeGood.GoodsPrice;
                data.SupplierId = changeGood.SupplierId;
                if (data.UrlImage != null)
                {
                    string fp = Path.Combine(_hostingEnviorment.WebRootPath, "imags", data.UrlImage);
                    System.IO.File.Delete(fp);
                }
                data.UrlImage = UrlImage;
                _goodRepository.UpdateGood(data);
                return RedirectToAction("Index");
            }
            SupplierDDL();
            return View();
        }

        private void SupplierDDL(object SupplierSelect = null)
        {
            var suppliers = _goodRepository.GetSuppliers();
            ViewBag.ListOfSuppliers = new SelectList(suppliers, "SupplierId", "SupplierName", SupplierSelect);
        }
        public IActionResult Delete(int id)
        {
            _goodRepository.DeleteGood(id);
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public IActionResult Details(int? id)
        {
            Good data = _goodRepository.Details(id);
            if (data == null)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }
    }
}
