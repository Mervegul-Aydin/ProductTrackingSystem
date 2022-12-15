using MyJeweleryShop.Core;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.UnitOfWorks;
using AutoMapper;
using MyJeweleryShop.Core.Models;


namespace MyJeweleryShop.Service.Services
{
    public class ProductColorService : GenericService<ProductColors>, IProductColorsService
    {
        private readonly IProductColorsRepository _productColorRepository;
        private readonly IMapper _mapper;


        public ProductColorService(IGenericRepository<ProductColors> repository, IGenericUnitOfWork unitOfWork, IProductColorsRepository productColorRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productColorRepository = productColorRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductColorsDto>> GetWebAllProductColors()
        {
            var productColor = await _productColorRepository.GetWebAllProductColorsAsync();
            var productColorDtos = _mapper.Map<List<ProductColorsDto>>(productColor);
            return productColorDtos;
        }

        public async Task<CustomResponseDto<List<ProductColorsDto>>> GetApiAllProductColors()
        {
            var productColor = await _productColorRepository.GetApiAllProductColorsAsync();
            var productColorDtos = _mapper.Map<List<ProductColorsDto>>(productColor);
            return CustomResponseDto<List<ProductColorsDto>>.Success(200, productColorDtos);
        }


        public async Task<List<ProductColorsDto>> GetWebAllColorsAsync()
        {
            var productColor = await _productColorRepository.GetWebAllProductColorsAsync();
            var productColorDtos = _mapper.Map<List<ProductColorsDto>>(productColor);
            return productColorDtos;
        }

       


    }



}


