namespace Financial_ms.Models
{
    public class UserDatabaseSettings : IUserDatabaseSettings
    {
        public string CollectionName {get; set;} = String.Empty;
        public string DatabaseName  {get; set;}	= String.Empty;
    }
}