using AutoMapper;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJeweleryShop.Service.Mapping
{
    public class MapProfiles:Profile
    {
        public MapProfiles()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Products, ProductDto>().ReverseMap();
            CreateMap<ProductFeatures, ProductFeaturesDto>().ReverseMap();
            CreateMap<ProductColors, ProductColorsDto>().ReverseMap();
            CreateMap<ProductMeasurementUnits, ProductMeasurementUnitsDto>().ReverseMap();
            CreateMap<ProductVatUnits, ProductVatUnitsDto>().ReverseMap();
            CreateMap<ProductBrands, ProductBrandsDto>().ReverseMap();
            CreateMap<Products, ProductCategoryDto>().ReverseMap();
            CreateMap<Category, CategoryProductDto>().ReverseMap();
            


        }
    }
}
