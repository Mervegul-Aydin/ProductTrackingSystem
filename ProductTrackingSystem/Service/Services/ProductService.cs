using MyJeweleryShop.Core;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using AutoMapper;
using MyJeweleryShop.Core.Models;


namespace MyJeweleryShop.Service.Services
{
    public class ProductService : GenericService<Products>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Products> repository, IGenericUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductCategoryDto>> GetWebAllProductsCategorys()
        {
            var products = await _productRepository.GetWebAllProductsCategorysAsync();
            var productsDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return productsDtos;
        }

        public async Task<CustomResponseDto<List<ProductCategoryDto>>> GetApiAllProductsCategorys()
        {
            var products = await _productRepository.GetApiAllProductsCategorysAsync();
            var productsDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return CustomResponseDto<List<ProductCategoryDto>>.Success(200, productsDtos);
        }


        public async Task<List<ProductCategoryDto>> GetWebAllProductsAsync()
        {
            var products = await _productRepository.GetWebAllProductsAsync();
            var productDtos = _mapper.Map<List<ProductCategoryDto>>(products);
            return productDtos;
        }





    }



}


