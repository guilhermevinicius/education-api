using Education.Application.UseCases.User.Common;
using MediatR;

namespace Education.Application.UseCases.User.GetProfile;

public class GetProfileInput : IRequest<UserOutputModel>
{
    public Guid UserId { get; set; }
}