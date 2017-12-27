using System;
using Letsworkout.Api.Infrastructure.Services.Message;

namespace Letsworkout.Api.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        GetUsersResponse getUsers(GetUsersRequest request);
        AddUsersResponse addUsers(AddUsersRequest request);
    }
}
