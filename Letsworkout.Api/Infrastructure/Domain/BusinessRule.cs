using System;
namespace Letsworkout.Api.Infrastructure
{
    public class BusinessRule
    {
        public BusinessRule(string field, string message)
        {
            this.field = field;
            this.message = message;
        }
        public string field { get; set; }
        public string message { get; set; }
    }
}