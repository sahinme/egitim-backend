using System.Collections.Generic;
using Egitim_Backend.Entities.Concrete;

namespace Egitim_Backend_Service.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        
        List<Product> GetByCategory(int categoryId);
        
        void Add(Product product);
        
        void Update(Product product);
        
        void Delete(int productId);
    }
}