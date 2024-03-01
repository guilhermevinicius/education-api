using Education.Application.UseCases.User.Common;
using MediatR;

namespace Education.Application.UseCases.User.GetProfile;

public interface IGetProfile : IRequestHandler<GetProfileInput, UserOutputModel>
{
}