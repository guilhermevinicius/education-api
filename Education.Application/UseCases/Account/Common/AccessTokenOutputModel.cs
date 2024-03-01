namespace Education.Application.UseCases.Account.Common;

public class AccessTokenOutputModel(string accessToken)
{
    public string AccessToken { get; set; } = accessToken;
}