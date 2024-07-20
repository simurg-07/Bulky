using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Models.Models.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace Bulky.Areas.Admin.Controllers
{   


    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductApiController : Controller
    {


        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductApiController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;

        }

         #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            //var options = new JsonSerializerOptions
            //{
            //    ReferenceHandler = ReferenceHandler.Preserve,
            //    MaxDepth = 64 ,// Adjust as needed,
            //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            //};

           
            List<Product> objProductList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();

			//         var result = _unitOfWork.Product.GetAll("Category").Select(p => new 
			//         { 
			//           Title = p.Title,
			//           Price = p.Price,
			//           Author=p.Author,
			//ISBN = p.ISBN,
			//         category=p.Category.Name

			//         }).ToList();
			////var json = JsonSerializer.Serialize(objProductList, options);
			//return Json(new { data = result });
			return Json(new { data = objProductList });
		}



        public IActionResult Delete(int? id)
        {
            var obj = _unitOfWork.Product.Get(u => u.Id == id);
            if (obj == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, obj.ImageUrl.TrimStart('\\'));
            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });

        }


        #endregion
    }
}
