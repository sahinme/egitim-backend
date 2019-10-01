using Egitim_Backend.Core.DataAccess.EntityFramework;
using Egitim_Backend.Data.Abstract;
using Egitim_Backend.Entities.Concrete.Users;

namespace Egitim_Backend.Data.Concrete.EntityFramework
{
    public class UserRepository:EfEntityRepositoryBase<User,NorthwindContext>,IUserRepository
    {
        
    }
}