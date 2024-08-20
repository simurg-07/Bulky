using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bulky.Models;
using Bulky.DataAccess.Repository;
using Bulky.DataAccess.Repository.IRepository;
using Bulky.Models.Models.Concrete;
using Bulky.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Bulky.Utility;
using System.Security.Claims;

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

        // ViewBag kullanarak kategori listesini payla��n
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

        // ViewBag ile kategorileri ge�irin
        ViewBag.Categories = categories;

        // Se�ilen kategori ismini bul
        var selectedCategoryName = categoryId.HasValue
            ? categories.FirstOrDefault(c => c.Id == categoryId.Value)?.Name
            : "All Categories";

        // ViewData veya ViewBag kullanarak kategori ad�n� ge�irin
        ViewBag.SelectedCategoryName = selectedCategoryName;

        // ViewModel olu�turma
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
        ShoppingCart cart = new()
        {
            Product = _unitOfWork.Product.Get(u => u.Id == productId, includeProperties: "Category,Comments"),
            Count = 1,
            ProductId = productId
        };
        return View(cart);
    }






    [HttpPost]
    [Authorize]
    public IActionResult Details(ShoppingCart shoppingCart)
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var UserId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
        shoppingCart.ApplicationUserId = UserId;

        ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(
            u => u.ApplicationUserId == UserId && u.ProductId == shoppingCart.ProductId);


        if (cartFromDb != null) {
            cartFromDb.Count += shoppingCart.Count;
            _unitOfWork.ShoppingCart.Update(cartFromDb);

        } 
        else {
            _unitOfWork.ShoppingCart.Add(shoppingCart);
        }
        
        _unitOfWork.Save();



        // ��lem sonras� ayn� sayfaya d�nmek i�in �r�n� tekrar y�kle ve View'a geri d�n
        ShoppingCart cart = new()
        {
            Product = _unitOfWork.Product.Get(u => u.Id == shoppingCart.ProductId, includeProperties: "Category,Comments"),
            Count = shoppingCart.Count,
            ProductId = shoppingCart.ProductId
        };

        return View(cart);
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
