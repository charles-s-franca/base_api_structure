using System;
namespace Letsworkout.Api.Infrastructure.Mapping
{
    public class AutomapperSetup
    {
        public static void Config()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.CreateMap<Model.User, ViewModel.UserViewModel>();
                x.CreateMap<Model.User, ViewModel.CreateUserViewModel>();
            });
        }
    }
}
