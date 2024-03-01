using Education.Api.Controllers.V1.Dtos.Account;
using Education.Application.UseCases.Account.SignIn;
using Education.Application.UseCases.User.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Education.Api.Controllers.V1;

[Route("v1")]
public class AccountController(IMediator mediator) : EducationBaseController
{
    [HttpGet("me")]
    public async Task<IActionResult> Me()
    {
        return Ok();
    }
    
    [HttpPost("signin")]
    public async Task<IActionResult> SignIn(SignInDto signInDto, CancellationToken cancellationToken)
    {
        var accessToken = await mediator.Send(new SignInInput
        {
            Email = signInDto.Email,
            Password = signInDto.Password
        }, cancellationToken);
        return Ok(accessToken);
    }
    
    [HttpPost("signup")]
    public async Task<IActionResult> SignUp(SignUpDto signUpDto, CancellationToken cancellationToken)
    {
        var user = await mediator.Send(new CreateUserInput
        {
            Name = signUpDto.Name,
            Email = signUpDto.Email,
            Password = signUpDto.Password
        }, cancellationToken);
        return Ok(user);
    }
}