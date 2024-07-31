using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.Models.Concrete;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using NuGet.Packaging.Signing;

namespace Bulky.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {


        private readonly IUnitOfWork _unitOfWork;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

		}
        public IActionResult Index()
        {
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties:"Category").ToList();
            return View(objProductList);
        }

        //GET
        //upsert olayını hem update hem create işlemi için tek çatı altında topladık ve edit methodunu sildik
        public IActionResult Upsert(int? id)
        {


            ProductVM productVM = new()
            {
                CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() }),


                Product = new Product()
            };

            if(id == null || id == 0)
            {
                //create
                return View(productVM);
            }
            else
            {
                //update
                productVM.Product = _unitOfWork.Product.Get(u => u.Id == id);
                return View(productVM);
            }

            
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(ProductVM productVM, IFormFile? file)
{
    if (ModelState.IsValid)
    {
        string wwwRootPath = _webHostEnvironment.WebRootPath;

        if (file != null)
        {
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string productPath = Path.Combine(wwwRootPath, "images", "product");

            if (!string.IsNullOrEmpty(productVM.Product.ImageUrl))
            {
                var oldImagePath = Path.Combine(wwwRootPath, productVM.Product.ImageUrl.TrimStart('\\', '/'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            if (!Directory.Exists(productPath))
            {
                Directory.CreateDirectory(productPath);
            }

            using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
            {
                file.CopyTo(fileStream);
            }

            productVM.Product.ImageUrl = Path.Combine("images", "product", fileName).Replace("\\", "/");
        }

        if (productVM.Product.Id == 0)
        {
            _unitOfWork.Product.Add(productVM.Product);
        }
        else
        {
            _unitOfWork.Product.Update(productVM.Product);
        }

        _unitOfWork.Save();
        TempData["success"] = "Product created successfully";
        return RedirectToAction("Index");
    }
    else
    {
        productVM.CategoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem
        {
            Text = u.Name,
            Value = u.Id.ToString()
        });

        return View(productVM);
    }
}



        ///GET
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Product productFromDb = _unitofWork.Product.Get(u => u.Id == id);

        //    if (productFromDb == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(productFromDb);
        //}


        ////post
        //[httppost]
        //public ıactionresult edit(product obj)
        //{


        //    if (modelstate.ısvalid)
        //    {
        //        _unitofwork.product.update(obj);
        //        _unitofwork.save();
        //        tempdata["success"] = "product updated successfully";
        //        return redirecttoaction("ındex");
        //    }
        //    return view(obj);
        //}


        //public ıactionresult delete(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return notfound();
        //    }
        //    product productfromdb = _unitofwork.product.get(u => u.ıd == id);

        //    if (productfromdb == null)
        //    {
        //        return notfound();
        //    }

        //    return view(productfromdb);
        //}


        ////post
        //[httppost, actionname("delete")]

        //public ıactionresult deletepost(int? id)
        //{
        //    product productfromdb = _unitofwork.product.get(u => u.ıd == id);
        //    if (productfromdb == null)
        //    {

        //        return notfound();
        //    }

        //    _unitofwork.product.remove(productfromdb);
        //    _unitofwork.save();
        //    tempdata["success"] = "product deleted successfully";
        //    return redirecttoaction("ındex");

        //}

        //#region apı calls

        //[httpget]
        //public ıactionresult getall()
        //{
        //    list<product> objproductlist = _unitofwork.product.getall(includeproperties: "category").tolist();
        //    return json(new { data = objproductlist });
        //}



        //public ıactionresult delete(int? id)
        //{
        //    var obj = _unitofwork.product.get(u => u.ıd == id);
        //    if (obj == null)
        //    {
        //        return json(new { success = false, message = "error while deleting" });
        //    }

        //    var oldımagepath = path.combine(_webhostenvironment.webrootpath, obj.ımageurl.trimstart('\\'));
        //    if (system.ıo.file.exists(oldımagepath))
        //    {
        //        system.ıo.file.delete(oldımagepath);
        //    }

        //    _unitofwork.product.remove(obj);
        //    _unitofwork.save();
        //    return json(new { success = true, message = "delete successful" });

        //}


        //#endregion

        
    }
}


