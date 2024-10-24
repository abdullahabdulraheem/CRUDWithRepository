using CRUDWithRepository.Core;
using CRUDWithRepository.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CRUDWithRepository.UI.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository _productRepository)
        {
            this._productRepository = _productRepository;
        }
        public async Task<ActionResult> Index()
        {
            var products = await _productRepository.GetAll();
            return View(products);
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Product model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    await _productRepository.Add(model);
                    TempData["successMessage"] = "Product added successfully";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    TempData["errorMessage"] = "Model State is invalid";
                    return View();
                }
            }
            catch(Exception ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return View();
            }
        }
    }
}
