namespace Shared.RequestFeatures
{
    public class UserParameters : RequestParameters
    {
        public UserParameters() =>
            OrderBy = "userName";

        public string? SearchTerm { get; set; }
    }
}
