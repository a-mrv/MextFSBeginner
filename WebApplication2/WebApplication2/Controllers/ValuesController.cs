using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<string> summaries1 = new() ;
        static List<string> summaries2 = new() ;
       static List<string> summaries3 = new() ;
        static List<string> names = new() ;



        [HttpGet("[action]")]
        public string GetPrice()
        {
            Random random = new();
            int price = random.Next(0, 1000);
            string summary = "";
            if (price < 50)
               return summary = summaries1[random.Next(summaries1.Count)];
            else if (price < 500)
               return summary = summaries2[random.Next(summaries2.Count)];
            else if (price < 1000)
               return summary = summaries3[random.Next(summaries3.Count)];




            return $"price: {price} , Summary:{summary}";
        }
        [HttpPost]
         public void Addsummary (string name, int selection  )
        {
            if (selection==1)
                summaries1.Add(name);
            else if (selection==2)  
                summaries2.Add(name);
            else if (selection==3)
                summaries3.Add(name);
        }

    }
}
