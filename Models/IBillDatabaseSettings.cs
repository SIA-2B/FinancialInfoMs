namespace Financial_ms.Models
{
    public interface IBillDatabaseSettings
    {
        string CollectionName {get; set;}
        string DatabaseName  {get; set;}
    }
}