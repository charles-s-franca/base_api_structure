using System;
using System.Linq;
using Letsworkout.Api.Infrastructure.Mapping;
using Letsworkout.Api.Infrastructure.Model;
using Letsworkout.Api.Infrastructure.Services.Interfaces;
using Letsworkout.Api.Infrastructure.Services.Message;

namespace Letsworkout.Api.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public IUnitOfWork _unitOfWork { get; set; }
        public IUserRepository _userRepository { get; set; }

        public UserService(
            IUnitOfWork unitOfWork,
            IUserRepository userRepository
            )
        {
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
        }

        public GetUsersResponse getUsers(GetUsersRequest request)
        {
            var response = new GetUsersResponse();
            response.list = _userRepository.GetAll(request.filter, request.orderBy).ToUserViewModel();
            return response;
        }

        public AddUsersResponse addUsers(AddUsersRequest request)
        {
            var response = new AddUsersResponse();

            Model.User user = new User();
            user.Id = Guid.NewGuid();
            user.password = request.model.password;
            user.username = request.model.username;

            if (_userRepository.Exists(u => u.username == request.model.username))
                throw new BusinessRuleException("Nome de usário já esta sendo usado.");

            if(!user.validate())
                throw new BusinessRuleException("Ocorreram erros de preenchimento.", user.getBrokedRules());

            _userRepository.Insert(user);
            _unitOfWork.Commit();

            response.user = user.ToUserViewModel();
            return response;
        }

    }
}
