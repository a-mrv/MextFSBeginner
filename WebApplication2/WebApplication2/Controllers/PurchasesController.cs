using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        List<string> summaries1 = new() { "ucuz" };
        List<string> summaries2 = new() { "orta" };
        List<string> summaries3 = new() { "pahalı" };
        


        [HttpGet]
        public string GetTempraure()
        {
            Random random = new();
            int price = random.Next(0, 1000);
            string summary = "";
            if (price < 50)
                summary = summaries1[random.Next(summaries1.Count)];
            else if (price < 500)
                summary = summaries2[random.Next(summaries2.Count)];
            else if (price < 1000)
                summary = summaries3[random.Next(summaries3.Count)];
            



            return $"price: {price} , Summary:{summary}";
        }



    }
}

