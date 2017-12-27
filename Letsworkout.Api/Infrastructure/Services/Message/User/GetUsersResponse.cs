using System;
using System.Collections.Generic;
using Letsworkout.Api.Infrastructure.ViewModel;

namespace Letsworkout.Api.Infrastructure.Services.Message
{
    public class GetUsersResponse
    {
        public IEnumerable<UserViewModel> list { get; internal set; }
    }
}