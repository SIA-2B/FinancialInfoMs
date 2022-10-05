using Financial_ms.Models;
using MongoDB.Driver;

namespace Financial_ms.Services
{
    public class BillService : IBillService
    {
        private readonly IMongoCollection<Bill> _bill;

        public BillService( IBillDatabaseSettings settings, IMongoClient mongoClient )
        {
            var billdatabase = mongoClient.GetDatabase(settings.DatabaseName);
            _bill = billdatabase.GetCollection<Bill>(settings.CollectionName);
        }

        public Bill Get(string billnumber)
        {
            return _bill.Find(bill => bill.Number == billnumber).FirstOrDefault();
        }

        public List<Bill> GetList(string userId)
        {
            return _bill.Find(bill => bill.Info!.UserId == userId ).ToList();
        }

        public List<Bill> GetListByYear(string userId, string year)
        {
            return _bill.Find(bill => bill.Info!.UserId == userId && bill.Info!.Year == year ).ToList();
        }

        public Bill Create(Bill bill)
        {
            _bill.InsertOne(bill);
            return bill;
        }

        public void Update(Bill bill)
        {
            _bill.ReplaceOne(x => x.Number == bill.Number, bill);
        }

        public void Remove(string number)
        {
            _bill.DeleteOne(x => x.Number == number);
        }
    }
}