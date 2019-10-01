using System;
using System.Collections.Generic;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete.Categories;

namespace Egitim_Backend_Service.CategoryService
{
    public class CategoryAppService:ICategoryAppService
    {
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoryAppService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public List<Category> GetAll()
        {
            var data=new List<Category>();

            var cat = new Category
            {
                Id = 1
            };
            
            data.Add(cat);
            
            return data;
        }
    }
}