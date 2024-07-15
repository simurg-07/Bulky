using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Hosting;
using NuGet.Packaging.Signing;

namespace Bulky.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {


        private readonly IUnitOfWork _unitofWork;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitofWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

		}
        public IActionResult Index()
        {
            List<Product> objProductList = _unitofWork.Product.GetAll(includeProperties:"Category").ToList();
            return View(objProductList);
        }

        //GET
        //upsert olayını hem update hem create işlemi için tek çatı altında topladık ve edit methodunu sildik
        public IActionResult Upsert(int? id)
        {


            ProductVM productVM = new()
            {
                CategoryList = _unitofWork.Category.GetAll().Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() }),


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
                productVM.Product = _unitofWork.Product.Get(u => u.Id == id);
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
					string productPath = Path.Combine(wwwRootPath, @"images\product\");

					if (!string.IsNullOrEmpty(productVM.Product.ImageUrl))
					{
						var oldImagePath = Path.Combine(wwwRootPath, productVM.Product.ImageUrl.TrimStart('\\'));
						if (System.IO.File.Exists(oldImagePath))
						{
							System.IO.File.Delete(oldImagePath);
						}
					}

					using (var fileStream = new FileStream(Path.Combine(productPath, fileName), FileMode.Create))
					{
						file.CopyTo(fileStream);
					}
				   productVM.Product.ImageUrl = @"\images\product\" + fileName;
				}

                if (productVM.Product.Id == 0) { 
                    _unitofWork.Product.Add(productVM.Product);
                }else
                {
					_unitofWork.Product.Update(productVM.Product);
				}


				
                _unitofWork.Save();
                TempData["success"] = "Product created successfully";
                return RedirectToAction("Index");
            }
            else
            {
                productVM.CategoryList = _unitofWork.Category.GetAll().Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() });
				

				// Üstteki olay category select kısmındaki category kısmını getiriyor
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


        ////POST
        //[HttpPost]
        //public IActionResult Edit(Product obj)
        //{

           
        //    if (ModelState.IsValid)
        //    {
        //        _unitofWork.Product.Update(obj);
        //        _unitofWork.Save();
        //        TempData["success"] = "Product updated successfully";
        //        return RedirectToAction("Index");
        //    }
        //    return View(obj);
        //}


        //public IActionResult Delete(int? id)
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


        ////POST
        //[HttpPost, ActionName("Delete")]

        //public IActionResult DeletePOST(int? id)
        //{
        //    Product productFromDb = _unitofWork.Product.Get(u => u.Id == id);
        //    if (productFromDb == null)
        //    {

        //        return NotFound();
        //    }

        //    _unitofWork.Product.Remove(productFromDb);
        //    _unitofWork.Save();
        //    TempData["success"] = "Product deleted successfully";
        //    return RedirectToAction("Index");

        //}

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> objProductList = _unitofWork.Product.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = objProductList });
        }

        
     
        public IActionResult Delete(int? id)
        {
            var obj = _unitofWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitofWork.Product.Remove(obj);
            _unitofWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }


        #endregion
    }
    }


