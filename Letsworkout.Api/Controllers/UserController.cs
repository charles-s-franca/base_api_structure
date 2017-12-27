using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Letsworkout.Api.Infrastructure;
using Letsworkout.Api.Infrastructure.Model;
using Letsworkout.Api.Infrastructure.Services.Interfaces;
using Letsworkout.Api.Infrastructure.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Letsworkout.Api.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        public IUserService _userService { get; set; }

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        // [Bind("username, password")]
        [HttpPost("")]
        public ApiResponse<UserViewModel> Post([FromBody] CreateUserViewModel model)
        {
            ApiResponse<UserViewModel> response;
            try
            {
                var newUser = _userService.addUsers(
                    new Infrastructure.Services.Message.AddUsersRequest() { model = model }
                ).user;

                response = ApiResponse<UserViewModel>.CreateResponse(
                    true, 
                    "Dados cadastrados com sucesso.", 
                    newUser, 
                    System.Net.HttpStatusCode.Accepted, 
                    null
                );
            }
            catch (BusinessRuleException bex)
            {
                response = ApiResponse<UserViewModel>.CreateResponse(
                    true, 
                    bex.Message, 
                    null, 
                    System.Net.HttpStatusCode.BadRequest, 
                    bex.brokenRules);
            }
            catch (Exception ex)
            {
                response = ApiResponse<UserViewModel>.CreateResponse(
                    true, 
                    "Ocorreu um erro ao processar sua solicitação.", 
                    null, 
                    System.Net.HttpStatusCode.InternalServerError, 
                    null);
            }

            return response;
        }

        [HttpGet("")]
        public ApiResponse<IEnumerable<UserViewModel>> Get()
        {
            ApiResponse<IEnumerable<UserViewModel>> response;
            try
            {
                var users = _userService.getUsers(
                    new Infrastructure.Services.Message.GetUsersRequest()
                ).list;

                response = ApiResponse<IEnumerable<UserViewModel>>.CreateResponse(
                    true,
                    "",
                    users,
                    System.Net.HttpStatusCode.Accepted,
                    null
                );
            }
            catch (Exception)
            {
                response = ApiResponse<IEnumerable<UserViewModel>>.CreateResponse(
                    true,
                    "Ocorreu um erro ao processar sua solicitação.",
                    null,
                    System.Net.HttpStatusCode.InternalServerError,
                    null);
            }
            return response;
        }
    }
}