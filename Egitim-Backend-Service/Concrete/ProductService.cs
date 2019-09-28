using System.Collections.Generic;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete;
using Egitim_Backend_Service.Abstract;

namespace Egitim_Backend_Service.Concrete
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        
        public List<Product> GetAll()
        {
            var product = new Product
            {
                Id = 1,
                CategoryId = 2
            };
            var numbers = new List<Product>();
             numbers.Add(product);
             return numbers;
             //return _productRepository.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
           return _productRepository.GetList(p => p.CategoryId == categoryId);
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(int productId)
        {
            //_productRepository.Delete(productId);
        }
    }
}