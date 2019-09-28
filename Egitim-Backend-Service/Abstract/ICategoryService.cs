using System.Collections.Generic;
using Egitim_Backend.Entities.Concrete;

namespace Egitim_Backend_Service.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}