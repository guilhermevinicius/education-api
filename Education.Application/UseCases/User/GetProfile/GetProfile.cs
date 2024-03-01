using Education.Application.Repositories;
using Education.Application.UseCases.User.Common;

namespace Education.Application.UseCases.User.GetProfile;

public class GetProfile(IUserRepository userRepository) : IGetProfile
{
    public async Task<UserOutputModel> Handle(GetProfileInput request, CancellationToken cancellationToken)
    {
        var user = userRepository.ById(request.UserId);
        if (user == null)
            throw new Exception("User not found");

        return UserOutputModel.FromEntity(user);
    }
}