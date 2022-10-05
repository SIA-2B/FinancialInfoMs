using Microsoft.AspNetCore.Mvc;
using Financial_ms.Services;
using Financial_ms.Models;

namespace Financial_ms.Controllers
{
    [Route("financialms/")]
    public class BillController : ControllerBase
    {
        private readonly IBillService billService;      

        public BillController(IBillService billService)
        {
            this.billService = billService;
        }

        //GET 
        [Route("bills/{userid}")]
        [HttpGet]
        public ActionResult<List<Bill>> Get(string userId )
        {
            var findbill = billService.GetList(userId);
            if (findbill == null | findbill!.Capacity < 1)
            {
                return BadRequest($"Error Bill With User Id = {userId} Not Found");
            }
            return findbill;
        }

        //GET 
        [Route("bills/{userid}/{year}")]
        [HttpGet]
        public ActionResult<List<Bill>> Get(string userId , string year)
        {
            var findbill = billService.GetListByYear(userId,year);
            if (findbill == null | findbill!.Capacity < 1)
            {
                return BadRequest($"Error Bill With User Id = {userId} Or Bill With Year = {year} Not Found");
            }
            return findbill;
        }

   /*     //POST
        [Route("bills/")]
        [HttpPost]
        public ActionResult<Bill> Post([FromBody] Bill? bill)
        {
            var findbill = billService.Get(bill!.Number!);

            if (findbill != null)
            {
                return BadRequest($"Error Bill with Number = {bill.Number} aready exists");
            }

            billService.Create(bill);

            return CreatedAtAction(nameof(Post), bill);
        }	

        //PUT
        [Route("bills/")]
        [HttpPut]
        public ActionResult Put([FromBody] Bill? bill)
        {
            var findbill = billService.Get(bill!.Number!);
            if (findbill == null)
            {
                return NotFound($"Bill with Number = {bill.Number} not found.");
            }

            billService.Update(bill);

            return Ok($"Bill with Number = {bill.Number} added");
        }

        //DELETE
        [Route("bills/{billnumber}")]
        [HttpDelete]
        public ActionResult Delete(string number)
        {
            var findbill = billService.Get(number);
            if (findbill == null)
            {
                return NotFound($"Bill with Number = {number} not found.");
            }
            billService.Remove(number);
            return Ok($"Bill with Number = {number} deleted");
        }*/
    }
}