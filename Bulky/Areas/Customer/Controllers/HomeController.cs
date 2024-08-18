using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bulky.Models;
using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models.Models.Concrete;
using Bulky.Models.ViewModels;

namespace Bulky.Areas.Customer.Controllers;

[Area("Customer")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
    {
        _logger = logger;
        _unitOfWork = unitOfWork;

    }




    public IActionResult Index(int? categoryId)
    {
        var products = _unitOfWork.Product.GetAllWithCategory(categoryId);
        var categories = _unitOfWork.Category.GetAll().ToList();

        // ViewBag kullanarak kategori listesini paylaþýn
        ViewBag.Categories = categories;

        var viewModel = new HomeViewModel
        {
            Products = products,
            Categories = categories,
        };

        return View(viewModel);
    }

    public IActionResult CategoryDetail(int? categoryId)
    {
        // Kategorileri al
        var categories = _unitOfWork.Category.GetAll().ToList();

        // ViewBag ile kategorileri geçirin
        ViewBag.Categories = categories;

        // Seçilen kategori ismini bul
        var selectedCategoryName = categoryId.HasValue
            ? categories.FirstOrDefault(c => c.Id == categoryId.Value)?.Name
            : "All Categories";

        // ViewData veya ViewBag kullanarak kategori adýný geçirin
        ViewBag.SelectedCategoryName = selectedCategoryName;

        // ViewModel oluþturma
        var viewModel = new HomeViewModel
        {
            Products = _unitOfWork.Product.GetAllWithCategory(categoryId),
            Categories = categories,
            title = selectedCategoryName
		};

        return View(viewModel);
    }







    public IActionResult Details(int productId)
    {
        var product = _unitOfWork.Product.Get(
            u => u.Id == productId,
            includeProperties: "Category,Comments"
        );
        return View(product);
    }

    [HttpPost]
    public IActionResult AddComment(int productId, Comment comment)
    {
        if (ModelState.IsValid)
        {
            comment.ProductId = productId;
            _unitOfWork.Comment.Add(comment);
            _unitOfWork.Save();
        }
        return RedirectToAction("Details", new { productId });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Panel()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
