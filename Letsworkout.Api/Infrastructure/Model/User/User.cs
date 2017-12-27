using System;
using Letsworkout.Api.Infrastructure.Domain.Data;

namespace Letsworkout.Api.Infrastructure.Model
{
    public class User : BaseModel<Guid>
    {
        public String username { get; set; }
        public String password { get; set; }

        public override bool validate()
        {
            if (string.IsNullOrEmpty(this.username))
                this.addBrokedRules(UserRules.Name_Should_Not_Be_Empty);

            if(!Util.InputValidation.isValidEmail(this.username))
                this.addBrokedRules(UserRules.Usernam_Should_Be_A_Valid_Email);
            
            return this.isValid();
        }
    }
}