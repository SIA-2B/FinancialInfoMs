namespace Financial_ms.Models
{
    public interface IUserDatabaseSettings
    {
        string CollectionName {get; set;}
        //string ConnectionString {get; set;}
        string DatabaseName  {get; set;}
	
    }
}