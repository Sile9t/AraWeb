namespace Shared.Dtos
{
    public record TokenDto
    {
        public TokenDto(string accessToken, string refreshToke)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToke;
        }

        public string AccessToken { get; init; }
        public string RefreshToken { get; init; }
    }
}
