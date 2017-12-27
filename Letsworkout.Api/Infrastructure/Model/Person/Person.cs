using System;
namespace Letsworkout.Api.Infrastructure.Model
{
    public class Person : BaseModel<Guid>
    {
        public String name { get; set; }
        public String lastname { get; set; }
        public DateTime birthday { get; set; }

        public override bool validate()
        {
            return true;
        }
    }
}
