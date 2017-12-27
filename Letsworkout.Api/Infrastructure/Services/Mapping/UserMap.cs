using System;
using System.Collections.Generic;
using System.Linq;

namespace Letsworkout.Api.Infrastructure.Mapping
{
    public static class UserMap
    {
        public static ViewModel.UserViewModel ToUserViewModel(this Model.User entity)
        {
            return AutoMapper.Mapper.Map<Model.User, ViewModel.UserViewModel>(entity);
        }

        public static IEnumerable<ViewModel.UserViewModel> ToUserViewModel(this IEnumerable<Model.User> entity)
        {
            return AutoMapper.Mapper.Map<IEnumerable<Model.User>, IEnumerable<ViewModel.UserViewModel>>(entity.ToList());
        }
    }
}