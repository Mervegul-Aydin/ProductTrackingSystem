using Microsoft.AspNetCore.Mvc;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Dynamic;
using MyJeweleryShop.Core.Models;

namespace MyJeweleryShop.WEB.Controllers
{
    public class ProductsBrandsController : Controller
    {
        private readonly IProductBrandsService _productBrandsService;
        private readonly IMapper _mapper;

        public ProductsBrandsController(IProductBrandsService productBrandsService, IMapper mapper)
        {
            _productBrandsService = productBrandsService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var productBrands = await _productBrandsService.GetWebAllProductBrands();
            dynamic mymodel = new ExpandoObject();
            mymodel._productBrands = productBrands;
            mymodel.activeProductBrandCount = productBrands.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductBrandCount = productBrands.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productBrands = await _productBrandsService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var ProductBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrands.ToList());
            ViewBag.productBrands = new SelectList(ProductBrandsDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductBrandsDto productBrandsDto)
        {
            if (ModelState.IsValid)
            {
                await _productBrandsService.AddAsync(_mapper.Map<ProductBrands>(productBrandsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var productBrands = await _productBrandsService.GetAllAsync();
            var ProductBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrands.ToList());
            ViewBag.productBrands = new SelectList(ProductBrandsDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productBrands = await _productBrandsService.GetByIdAsync(Id);
            var productBrand = await _productBrandsService.GetAllAsync();
            var ProductBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrand.ToList());
            ViewBag.productBrands = new SelectList(ProductBrandsDto, "Id", "Name", productBrands);
            return View(_mapper.Map<ProductBrandsDto>(productBrands));
        }



        [HttpPost]
        public async Task<IActionResult> Update(ProductBrandsDto productBrandsDto)
        {
            if (ModelState.IsValid)
            {
                await _productBrandsService.UpdateAsync(_mapper.Map<ProductBrands>(productBrandsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var productBrands = await _productBrandsService.GetAllAsync();
            var ProductBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrands.ToList());
            ViewBag.productBrands = new SelectList(ProductBrandsDto, "Id", "Name", productBrandsDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var productBrands = await _productBrandsService.GetByIdAsync(Id);
            await _productBrandsService.RemoveAsync(productBrands);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var productBrands = await _productBrandsService.GetByIdAsync(Id);
            var productBrand = await _productBrandsService.GetAllAsync();
            var ProductBrandsDto = _mapper.Map<List<ProductBrandsDto>>(productBrand.ToList());
            ViewBag.productBrands = new SelectList(ProductBrandsDto, "Id", "Name", productBrands);
            return View(_mapper.Map<ProductBrandsDto>(productBrands));
        }





    }
}