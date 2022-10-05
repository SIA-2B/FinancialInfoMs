namespace Financial_ms.Models
{
    public class BillDatabaseSettings : IBillDatabaseSettings
    {
	    public string CollectionName {get; set;} = String.Empty;
        public string DatabaseName  {get; set;} = String.Empty;
    }
}