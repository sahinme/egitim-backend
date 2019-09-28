using System.Collections.Generic;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete;
using Egitim_Backend_Service.Abstract;

namespace Egitim_Backend_Service.Concrete
{
    public class CategoryService:ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        
        public List<Category> GetAll()
        {
            return _categoryRepository.GetList();
        }
    }
}