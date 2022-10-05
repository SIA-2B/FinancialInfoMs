using Financial_ms.Models;
using MongoDB.Driver;

namespace Financial_ms.Services
{
    public interface IBillService
    {
        Bill Get(string billnumber);
        List<Bill> GetList(string userId);      
        List<Bill> GetListByYear(string userId, string year);
        Bill Create(Bill bill);
        void Update(Bill bill);
        void Remove(string billNumber);
    }
}