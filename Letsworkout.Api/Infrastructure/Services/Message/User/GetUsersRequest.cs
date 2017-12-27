using System;
using System.Linq;
using System.Linq.Expressions;

namespace Letsworkout.Api.Infrastructure.Services.Message
{
    public class GetUsersRequest
    {
        public Expression<Func<Model.User, bool>> filter { get; set; }
        public Func<IQueryable<Model.User>, IOrderedQueryable<Model.User>> orderBy { get; set; }
    }
}
