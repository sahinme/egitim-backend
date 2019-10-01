using System.Collections.Generic;
using Egitim_Backend.Entities.Concrete;
using Egitim_Backend.Entities.Concrete.Categories;

namespace Egitim_Backend_Service.CategoryService
{
    public interface ICategoryAppService
    {
        List<Category> GetAll();
    }
}