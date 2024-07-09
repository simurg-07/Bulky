using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bulky.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {


        private readonly IUnitOfWork _unitofWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitofWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> objProductList = _unitofWork.Product.GetAll().ToList();
            return View(objProductList);
        }

        //GET
        public IActionResult Create()
        {


            ProductVM productVM = new()
            {
                CategoryList = _unitofWork.Category.GetAll().Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() }),


                Product = new Product()
            };

            // Üstteki olay category select kısmındaki category kısmını getiriyor
            return View(productVM);
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductVM productVM)
        {
          
            if (ModelState.IsValid)
            {
                _unitofWork.Product.Add(productVM.Product);
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


        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product productFromDb = _unitofWork.Product.Get(u => u.Id == id);

            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }


        //POST
        [HttpPost]
        public IActionResult Edit(Product obj)
        {

           
            if (ModelState.IsValid)
            {
                _unitofWork.Product.Update(obj);
                _unitofWork.Save();
                TempData["success"] = "Product updated successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Product productFromDb = _unitofWork.Product.Get(u => u.Id == id);

            if (productFromDb == null)
            {
                return NotFound();
            }

            return View(productFromDb);
        }


        //POST
        [HttpPost, ActionName("Delete")]

        public IActionResult DeletePOST(int? id)
        {
            Product productFromDb = _unitofWork.Product.Get(u => u.Id == id);
            if (productFromDb == null)
            {

                return NotFound();
            }

            _unitofWork.Product.Remove(productFromDb);
            _unitofWork.Save();
            TempData["success"] = "Product deleted successfully";
            return RedirectToAction("Index");

        }
    }
}
