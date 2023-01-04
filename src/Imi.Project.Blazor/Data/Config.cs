namespace Imi.Project.Blazor.Data
{
    public static class Config
    {
        private const string baseUrl = "https://localhost:5001/api";
        public static string Url
        {
            get
            {
                return baseUrl;
            }
        }
    }
}
