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
    public class ProductsVatController : Controller
    {
        private readonly IProductVatUnitsService _productVatUnitsService;
        private readonly IMapper _mapper;

        public ProductsVatController(IProductVatUnitsService productVatUnitsService, IMapper mapper)
        {
            _productVatUnitsService = productVatUnitsService;
            _mapper = mapper;
        } 

        public async Task<IActionResult> Index()
        {
            var productVat = await _productVatUnitsService.GetWebAllProductVatUnits();
            dynamic mymodel = new ExpandoObject();
            mymodel._productVat = productVat;
            mymodel.activeProductVatCount = productVat.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductVatCount = productVat.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productVat = await _productVatUnitsService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var productVatDto = _mapper.Map<List<ProductVatUnitsDto>>(productVat.ToList());
            ViewBag.productVat = new SelectList(productVatDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductVatUnitsDto productVatUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productVatUnitsService.AddAsync(_mapper.Map<ProductVatUnits>(productVatUnitsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var productVat = await _productVatUnitsService.GetAllAsync();
            var productVatDto = _mapper.Map<List<ProductVatUnitsDto>>(productVat.ToList());
            ViewBag.productVat = new SelectList(productVatDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productVat = await _productVatUnitsService.GetByIdAsync(Id);
            var ProductVat = await _productVatUnitsService.GetAllAsync();
            var productVatDto = _mapper.Map<List<ProductVatUnitsDto>>(ProductVat.ToList());
            ViewBag.productVat = new SelectList(productVatDto, "Id", "Name", productVat);
            return View(_mapper.Map<ProductVatUnitsDto>(productVat));
        }



        [HttpPost]
        public async Task<IActionResult> Update(ProductVatUnitsDto productVatUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productVatUnitsService.UpdateAsync(_mapper.Map<ProductVatUnits>(productVatUnitsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var productVat = await _productVatUnitsService.GetAllAsync();
            var productVatDto = _mapper.Map<List<ProductVatUnitsDto>>(productVat.ToList());
            ViewBag.productVat = new SelectList(productVatDto, "Id", "Name", productVatDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var productVat = await _productVatUnitsService.GetByIdAsync(Id);
            await _productVatUnitsService.RemoveAsync(productVat);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var productVat = await _productVatUnitsService.GetByIdAsync(Id);
            var ProductVat = await _productVatUnitsService.GetAllAsync();
            var productVatDto = _mapper.Map<List<ProductVatUnitsDto>>(ProductVat.ToList());
            ViewBag.productVat = new SelectList(productVatDto, "Id", "Name", productVat);
            return View(_mapper.Map<ProductVatUnitsDto>(productVat));
        }





    }
}