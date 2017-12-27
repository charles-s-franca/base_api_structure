using System;
namespace Letsworkout.Api.Infrastructure.Model
{
    public class UserRules
    {
        public static BusinessRule Usernam_Should_Be_A_Valid_Email
        {
            get{
                return new BusinessRule("username", "E-mail digitado inválido.");
            }
        }

        public static BusinessRule Name_Should_Not_Be_Empty
        {
            get
            {
                return new BusinessRule("name", "Digite um node de usuário.");
            }
        }
    }
}
