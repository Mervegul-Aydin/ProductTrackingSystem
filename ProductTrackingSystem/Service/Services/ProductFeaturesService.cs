using MyJeweleryShop.Core;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using AutoMapper;
using MyJeweleryShop.Core.Models;




namespace MyJeweleryShop.Service.Services
{
    public class ProductFeaturesService : GenericService<ProductFeatures>, IProductFeaturesService
    {
        private readonly IProductFeaturesRepository _productFeaturesRepository;
        private readonly IMapper _mapper;


        public ProductFeaturesService(IGenericRepository<ProductFeatures> repository, IGenericUnitOfWork unitOfWork, IProductFeaturesRepository productFeaturesRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productFeaturesRepository = productFeaturesRepository;
            _mapper = mapper;
        }


        public async Task<CustomResponseDto<List<ProductFeaturesDto>>> GetApiAllProductFeatures()
        {
            var productFeatures = await _productFeaturesRepository.GetApiAllProductFeaturesAsync();
            var productFeaturesDtos = _mapper.Map<List<ProductFeaturesDto>>(productFeatures);
            return CustomResponseDto<List<ProductFeaturesDto>>.Success(200, productFeaturesDtos);
        }


        public async Task<List<ProductFeaturesDto>> GetWebAllProductFeatures()
        {
            var productFeatures = await _productFeaturesRepository.GetWebAllProductFeaturesAsync();
            var productFeaturesDtos = _mapper.Map<List<ProductFeaturesDto>>(productFeatures);
            return productFeaturesDtos;
        }

       


    }



}


