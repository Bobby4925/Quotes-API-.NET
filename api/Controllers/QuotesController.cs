using System.Diagnostics;
using System.Globalization;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Controller : ControllerBase
    {
        public Controller(){
            DotNetEnv.Env.Load(); 
        }
        // GET: api/My
        [HttpGet]
        public IActionResult Get()
        {
            // Replace this with your actual logic
            using(var reader = new StreamReader(Environment.GetEnvironmentVariable("QUOTES_PATH")))
            using(var csv = new CsvReader(reader, CultureInfo.InvariantCulture)){
                var data = csv.GetRecords<QuotesData>();  
                int length = 0; 
                Random r = new Random(); 
                List<string> quote = new List<string>();  
                List<string> author = new List<string>();  
                foreach(var d in data){
                    //Console.WriteLine(d.quote);
                    quote.Add(d.quote); 
                    author.Add(d.author);
                    length++; 
                    //Console.WriteLine(d.author); 
                }
                int num = r.Next(1,length); 
                return Ok(new QuotesData(){quote = quote[num],author = author[num]}); 
            }
            //return Ok("Heres a Quote!");
        }
    }
}
