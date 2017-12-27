using System;
namespace Letsworkout.Api.Infrastructure.Repository.Implementation
{
    public class UserRepository : BaseRepository<Model.User, Guid>, Model.IUserRepository
    {
        public UserRepository(IUnitOfWork unit) : base(unit)
        {

        }
    }
}