using AutoMapper;
using MyJeweleryShop.Core;
using MyJeweleryShop.Core.Repositories;
using MyJeweleryShop.Core.Services;
using MyJeweleryShop.Core.DTOs;
using MyJeweleryShop.Core.UnitOfWorks;
using MyJeweleryShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyJeweleryShop.Service.Services
{
    public class CategoryService : GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IGenericUnitOfWork unitOfWork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        public async Task<CustomResponseDto<CategoryProductDto>> GetApiCategoryIdProductsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetApiCategoryIdProductsAsync(categoryId);
            var categoryDto = _mapper.Map<CategoryProductDto>(category);
            return CustomResponseDto<CategoryProductDto>.Success(200, categoryDto);
        }

        public Task<CustomResponseDto<CategoryProductDto>> GetApiAllCategoryProductsAsync()
        {
            throw new NotImplementedException();
        }


        public Task<List<CategoryProductDto>> GetWebAllCategoryProductsAsync()
        {
            throw new NotImplementedException();
        }
        public Task<List<CategoryProductDto>> GetAllCategoryProductsAsync()
        {
            throw new NotImplementedException();
        }


        public Task<List<CategoryProductDto>> GetWebCategoryIdProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CategoryDto>> GetWebAllCategoriesAsync()
        {
            var categorys = await _categoryRepository.GetWebAllCategoriesAsync();
            var categoryDtos = _mapper.Map<List<CategoryDto>>(categorys);
            return categoryDtos;
        }
    }



}

