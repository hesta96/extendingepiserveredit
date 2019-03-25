namespace ExtendingEpiserverEdit.Business.Repositories
{
    using System.Configuration;

    public class ConfigRepository : IConfigRepository
    {
        public string GetConnectionString(string key)
        {
            var conString = ConfigurationManager.ConnectionStrings[key];
            if (conString != null)
            {
                return conString.ConnectionString;
            }

            return string.Empty;
        }
    }
}