using Microsoft.AspNetCore.Mvc;
using az_snappers_mock.Models;


namespace az_snappers_mock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanDetailsController : ControllerBase
    {
        
        [HttpGet]
        public string Get()
        {
            QuoteResponse response = new QuoteResponse() { HouseCost = 25000000, IsPreapproved = true, RateofInterest = "2.40" };
            var jsonresponse = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            return jsonresponse;
        }
    }
}
