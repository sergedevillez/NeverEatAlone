using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeverEatAlone.Api.Infrastructure.Attributes;
using NeverEatAlone.Api.Infrastructure.Security;
using NeverEatAlone.Api.Models;
using NeverEatAlone.Models.Client.Entities;
using NeverEatAlone.Models.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeverEatAlone.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {

        
        private readonly IAuthRepository<User> _repository;
        private readonly ITokenService _tokenService;

        public AuthController(ITokenService tokenService, IAuthRepository<User> repository)
        {
            _repository = repository;
            _tokenService = tokenService;
        }

        //TODO : add the get one user for admin to acces one 
        //TODO : Add the get all for admin to get a list of current user (maybe ?)

        //Post api/auth/login
        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginForm form)
        {
            if (ModelState.IsValid)
            {
                User user = _repository.Login(form.Email, form.Password);

                if (User is null)
                    return NoContent();

                ApiUser apiUser = new ApiUser(user);
                apiUser.Token = _tokenService.GenerateToken(user);

                return Ok(apiUser);
            }

            return BadRequest();
        }

        //Post api/Auth/Register
        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterForm form)
        {
            if (ModelState.IsValid)
            {
                _repository.Register(new User(form.FirstName, form.LastName, form.Email, form.Password, form.IdPhoto));
                return Ok();
            }

            return BadRequest();
        }

        //Todo : allow update user WITH userId without adding public constructor with userId
        //Post api/Auth/Update
        //[AuthRequired]
        //[HttpPost("Update")]
        //public IActionResult Update([FromBody] UpdateUserForm form, [FromRoute] int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _repository.Update(new User(id, form.FirstName, form.LastName, form.Email, form.Password, form.IdPhoto));
        //        return Ok();
        //    }

        //    return BadRequest();
        //}


        //Post api/Auth/FreezeUnfreeze
        [AuthRequired]
        [HttpPost("FreezeUnfreeze/{id}")]
        public IActionResult FreezeUnfreeze(int id)
        {
            _repository.FreezeUnfreeze(id);
            return Ok();
        }

    }
}
