using System;
using System.Net.Mail;

namespace Letsworkout.Api.Util
{
    public class InputValidation
    {
        public static bool isValidEmail(string emailaddress){
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
