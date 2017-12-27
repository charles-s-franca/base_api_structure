using System;
namespace Letsworkout.Api.Infrastructure.Domain.Data
{
    public interface IBaseModel
    {
        DateTime createdAt { get; set; }
        DateTime updatedAt { get; set; }
    }
}
