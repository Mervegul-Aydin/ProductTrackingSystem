using MyJeweleryShop.Core;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using AutoMapper;
using MyJeweleryShop.Core.Models;


namespace MyJeweleryShop.Service.Services
{
    public class ProductVatService : GenericService<ProductVatUnits>, IProductVatUnitsService
    {
        private readonly IProductVatUnitsRepository _productVatUnitsRepository;
  
        private readonly IMapper _mapper;

        public ProductVatService(IGenericRepository<ProductVatUnits> repository, IGenericUnitOfWork unitOfWork, IProductVatUnitsRepository productVatUnitsRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productVatUnitsRepository = productVatUnitsRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductVatUnitsDto>> GetWebAllProductVatUnits()
        {
            var productVat = await _productVatUnitsRepository.GetWebAllProductVatUnitsAsync();
            var productVatDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVat);
            return productVatDtos;
        }



        public async Task<CustomResponseDto<List<ProductVatUnitsDto>>> GetApiAllProductVatUnits()
        {
            var productVat = await _productVatUnitsRepository.GetApiAllProductVatUnitsAsync();
            var productVatDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVat);
            return CustomResponseDto<List<ProductVatUnitsDto>>.Success(200, productVatDtos);
        }


        public async Task<List<ProductVatUnitsDto>> GetWebAllVatAsync()
        {
            var productVat = await _productVatUnitsRepository.GetWebAllProductVatUnitsAsync();
            var productVatDtos = _mapper.Map<List<ProductVatUnitsDto>>(productVat);
            return productVatDtos;
        }




    }

}

