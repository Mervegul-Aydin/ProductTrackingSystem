using MyJeweleryShop.Core;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using AutoMapper;
using MyJeweleryShop.Core.Models;

namespace MyJeweleryShop.Service.Services
{
    public class ProductBrandService : GenericService<ProductBrands>, IProductBrandsService
    {
        private readonly IProductBrandsRepository _productBrandsRepository;
        private readonly IMapper _mapper;


        public ProductBrandService(IGenericRepository<ProductBrands> repository, IGenericUnitOfWork unitOfWork, IProductBrandsRepository productBrandsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productBrandsRepository = productBrandsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductBrandsDto>> GetWebAllProductBrands()
        {
            var productBrands = await _productBrandsRepository.GetWebAllProductBrandsAsync();
            var productBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
            return productBrandsDtos;
        }

        public async Task<CustomResponseDto<List<ProductBrandsDto>>> GetApiAllProductBrands()
        {
            var productBrands = await _productBrandsRepository.GetApiAllProductBrandsAsync();
            var productBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
            return CustomResponseDto<List<ProductBrandsDto>>.Success(200, productBrandsDtos);
        }
        

        public async Task<List<ProductBrandsDto>> GetWebAllBrandsAsync()
        {
            var productBrands = await _productBrandsRepository.GetWebAllProductBrandsAsync();
            var productBrandsDtos = _mapper.Map<List<ProductBrandsDto>>(productBrands);
            return productBrandsDtos;
        }


    }

}

