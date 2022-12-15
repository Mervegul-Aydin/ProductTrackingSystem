using MyJeweleryShop.Core;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using AutoMapper;
using MyJeweleryShop.Core.Models;


namespace MyJeweleryShop.Service.Services
{
    public class ProductMeasurementService : GenericService<ProductMeasurementUnits>, IProductMeasurementUnitsService
    {
        private readonly IProductMeasurementUnitsRepository _productMeasurementUnitsRepository;
        private readonly IMapper _mapper;

        public ProductMeasurementService(IGenericRepository<ProductMeasurementUnits> repository, IGenericUnitOfWork unitOfWork, IProductMeasurementUnitsRepository productMeasurementUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productMeasurementUnitsRepository = productMeasurementUnitsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductMeasurementUnitsDto>> GetWebAllProductMeasurement()
        {
            var productMeasurement = await _productMeasurementUnitsRepository.GetWebAllProductMeasurementUnitsAsync();
            var productMeasurementDtos = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurement);
            return productMeasurementDtos;
        }

 

        public async Task<CustomResponseDto<List<ProductMeasurementUnitsDto>>> GetApiAllProductMeasurement()
        {
            var productMeasurement = await _productMeasurementUnitsRepository.GetApiAllProductMeasurementUnitsAsync();
            var productMeasurementDtos = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurement);
            return CustomResponseDto<List<ProductMeasurementUnitsDto>>.Success(200, productMeasurementDtos);
        }


        public async Task<List<ProductMeasurementUnitsDto>> GetWebAllMeasurementAsync()
        {
            var productMeasurement = await _productMeasurementUnitsRepository.GetWebAllProductMeasurementUnitsAsync();
            var productMeasurementDtos = _mapper.Map<List<ProductMeasurementUnitsDto>>(productMeasurement);
            return productMeasurementDtos;
        }




    }

}

