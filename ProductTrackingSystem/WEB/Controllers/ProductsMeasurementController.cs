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
    public class ProductsMeasurementController : Controller
    {
        private readonly IProductMeasurementUnitsService _productMeasurementUnitsService;
        private readonly IMapper _mapper;

        public ProductsMeasurementController(IProductMeasurementUnitsService productMeasurementUnitsService, IMapper mapper)
        {
            _productMeasurementUnitsService = productMeasurementUnitsService;
            _mapper = mapper;
        } 

        public async Task<IActionResult> Index()
        {
            var productMeasurement = await _productMeasurementUnitsService.GetWebAllProductMeasurement();
            dynamic mymodel = new ExpandoObject();
            mymodel._productMeasurement = productMeasurement;
            mymodel.activeProductMeasurementCount = productMeasurement.Where(t => t.IsActive == 1).Count();
            mymodel.passiveProductMeasurementCount = productMeasurement.Where(t => t.IsActive == 0).Count();
            return View(mymodel);
        }



        public async Task<IActionResult> Save()
        {
            var productMeasurement = await _productMeasurementUnitsService.GetAllAsync(); //    var productsColor = await _productColorsService.GetAllAsync();
            var productMeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurement.ToList());
            ViewBag.productMeasurement = new SelectList(productMeasurementDto, "Id", "Name");
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Save(ProductMeasurementUnitsDto productMeasurementUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productMeasurementUnitsService.AddAsync(_mapper.Map<ProductMeasurementUnits>(productMeasurementUnitsDto));
                TempData.Add("Success", "Ürün başarıyla eklenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Error", "Hata Oluştu. ProductsController|Save|54");
            var productMeasurement = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurement.ToList());
            ViewBag.productMeasurement = new SelectList(productMeasurementDto, "Id", "Name");
            return View();
        }

        public async Task<IActionResult> Update(int Id)
        {
            var productMeasurement = await _productMeasurementUnitsService.GetByIdAsync(Id);
            var ProductMeasurement = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(ProductMeasurement.ToList());
            ViewBag.productMeasurement = new SelectList(productMeasurementDto, "Id", "Name", productMeasurement);
            return View(_mapper.Map<ProductMeasurementUnitsDto>(productMeasurement));
        }



        [HttpPost]
        public async Task<IActionResult> Update(ProductMeasurementUnitsDto productMeasurementUnitsDto)
        {
            if (ModelState.IsValid)
            {
                await _productMeasurementUnitsService.UpdateAsync(_mapper.Map<ProductMeasurementUnits>(productMeasurementUnitsDto));
                TempData.Add("Info", "Ürün başarıyla güncellenmiştir.");
                return RedirectToAction(nameof(Index));
            }
            TempData.Add("Info", "Hata Oluştu. ProductsController|Update|79");
            var productMeasurement = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurement.ToList());
            ViewBag.productMeasurement = new SelectList(productMeasurementDto, "Id", "Name", productMeasurementDto);
            return View();
        }

        public async Task<IActionResult> Delete(int Id)
        {
            var productMeasurement = await _productMeasurementUnitsService.GetByIdAsync(Id);
            await _productMeasurementUnitsService.RemoveAsync(productMeasurement);
            TempData.Add("Info", "Ürün başarıyla silinmiştir.");
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Details(int Id)
        {
            var productMeasurement = await _productMeasurementUnitsService.GetByIdAsync(Id);
            var ProductMeasurement = await _productMeasurementUnitsService.GetAllAsync();
            var productMeasurementDto = _mapper.Map<List<ProductMeasurementUnitsDto>>(ProductMeasurement.ToList());
            ViewBag.productMeasurement = new SelectList(productMeasurementDto, "Id", "Name", productMeasurement);
            return View(_mapper.Map<ProductMeasurementUnitsDto>(productMeasurement));
        }





    }
}