using System;
namespace Letsworkout.Api.Infrastructure.Repository.Implementation
{
    public class PersonRepository : BaseRepository<Model.Person, Guid>, Model.IPersonRepository
    {
        public PersonRepository(IUnitOfWork unit) : base(unit)
        {

        }
    }
}