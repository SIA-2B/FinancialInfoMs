using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Financial_ms.Models
{
    [BsonIgnoreExtraElements] 
    public class Bill
    { 
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id{ get; set;}

        [BsonElement("Number")]
        public string? Number {get; set;} = String.Empty;

        [BsonElement("Info")]
        public BillInfo? Info {get; set;}

        [BsonElement("Dates")]
        public BillDates? Dates {get; set;}

        [BsonElement("PaymentMethod")]
        public string? PaymentMethod {get; set;} = String.Empty;

        [BsonElement("EnrolmentConcepts")]
        public string? EnrolmentConcepts {get; set;} = String.Empty;

        [BsonElement("Value")]
        public BillValue? Value {get; set;}

        [BsonElement("Remarks")]
        public string? Remarks {get; set;} = String.Empty;

        [BsonElement("Status")]
        public string? Status {get; set;} = String.Empty;
	
    }

    public class BillInfo
    {
        [BsonElement("UserId")]
        public string? UserId {get; set; } = String.Empty;

        [BsonElement("Period")]
        public string? Period {get; set;} = String.Empty;

        [BsonElement("Year")]
        public string? Year {get; set;} = String.Empty;
    }

    public class BillDates
    {
        [BsonElement("DateOfIssue")]
        public string? DateOfIssue {get; set;} = String.Empty;

        [BsonElement("DateTimely")]
        public string? DateTimely {get; set;} = String.Empty;

        [BsonElement("LateDate")]
        public string? LateDate {get; set;} = String.Empty;
    }

    public class BillValue
    {
        [BsonElement("Value")]
        public string? Value {get; set;} = String.Empty;

        [BsonElement("Discount")]
        public string? Discount {get; set;} = String.Empty;

        [BsonElement("TotalValue")]
        public string? TotalValue {get; set;} = String.Empty;
    }
}