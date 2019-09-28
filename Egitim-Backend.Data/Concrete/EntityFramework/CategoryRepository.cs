using Egitim_Backend.Core.DataAccess.EntityFramework;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete.Categories;

namespace Egitim_Backend.Data.Concrete.EntityFramework
{
    public class CategoryRepository:EfEntityRepositoryBase<Category,NorthwindContext>,ICategoryRepository
    {
        
        
    }
}