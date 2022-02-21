using Microsoft.AspNetCore.Mvc;
using az_snappers_mock.Models;


namespace az_snappers_mock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanDetailsController : ControllerBase
    {
        
        [HttpGet]
        public string Get(decimal HouseCost = 5000000)
        {
            QuoteResponse response = new QuoteResponse() { HouseCost = 25000000, IsPreapproved = true, APR = "4.60" , DisplayName = "Morgan Stanley Private Bank, National Association - Fixed Rate, 30 Years" };
            var jsonresponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return jsonresponse;
        }
    }
}
