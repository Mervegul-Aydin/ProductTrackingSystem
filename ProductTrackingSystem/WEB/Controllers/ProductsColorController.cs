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
    public class ProductsColorController : Controller
    {
        private readonly IProductColorsService _productColorsService;
        private readonly IMapper _mapper;

        public ProductsColorController(IProductColorsService productColorsService, IMapper mapper)
        {
            _productColorsService = productColorsService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var productColors = await _productColorsService.GetWebAllProductColors();
            dynamic mymodel = new ExpandoObject();
            mymodel._productColors = productColors;
            mymodel.activeProductsColorCount = productColors.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductsColorCount = productColors.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }

        public async Task<IActionResult> Save()
        {
            var productsColor = await _productColorsService.GetAllAsync();
            var ProductColorsDto = _mapper.Map<List<ProductColorsDto>>(productsColor.ToList());
            ViewBag.productColors = new SelectList(ProductColorsDto, "Id", "Name");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Save(ProductColorsDto productColorsDto)
        {
            if (ModelState.IsValid)
            {
                await _productColorsService.AddAsync(_mapper.Map<ProductColors>(productColorsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var ProductColors = await _productColorsService.GetAllAsync();
            var ProductColorsDto = _mapper.Map<List<ProductColorsDto>>(ProductColors.ToList());
            ViewBag.productColors = new SelectList(ProductColorsDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var ProductColors = await _productColorsService.GetByIdAsync(Id);
            var ProductColor = await _productColorsService.GetAllAsync();
            var ProductColorsDto = _mapper.Map<List<ProductColorsDto>>(ProductColor.ToList());
            ViewBag.productColors = new SelectList(ProductColorsDto, "Id", "Name", ProductColors);
            return View(_mapper.Map<ProductColorsDto>(ProductColors));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProductColorsDto productColorsDto)
        {
            if (ModelState.IsValid)
            {
                await _productColorsService.UpdateAsync(_mapper.Map<ProductColors>(productColorsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var ProductColor = await _productColorsService.GetAllAsync();
            var ProductColorsDto = _mapper.Map<List<ProductColorsDto>>(ProductColor.ToList());
            ViewBag.productColors = new SelectList(ProductColorsDto, "Id", "Name", productColorsDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var ProductColor = await _productColorsService.GetByIdAsync(Id);
            await _productColorsService.RemoveAsync(ProductColor);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var ProductColors = await _productColorsService.GetByIdAsync(Id);
            var ProductColor = await _productColorsService.GetAllAsync();
            var ProductColorsDto = _mapper.Map<List<ProductColorsDto>>(ProductColor.ToList());
            ViewBag.productColors = new SelectList(ProductColorsDto, "Id", "Name", ProductColors);
            return View(_mapper.Map<ProductColorsDto>(ProductColors));
        }





    }
}