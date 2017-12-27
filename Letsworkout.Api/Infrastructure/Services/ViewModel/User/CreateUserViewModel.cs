using System;
namespace Letsworkout.Api.Infrastructure.ViewModel
{
    public class CreateUserViewModel
    {
        public Guid Id {get;set;}
        public String username { get; set; }
        public String password { get; set; }
    }
}