using CsvHelper; 
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic; 
using System.Globalization; 

//Class Scraped is span.text and small.author
HtmlWeb web = new HtmlWeb(); 
DotNetEnv.Env.Load();
HtmlDocument doc = web.Load("https://quotes.toscrape.com/"); 
var QuoteHeader = doc.DocumentNode.SelectNodes("//span[@class='text']");
var AuthorHeader = doc.DocumentNode.SelectNodes("//small[@class='author']");
var quotes = new List<QuotesData>();
foreach(var quote in QuoteHeader){
    quotes.Add(new QuotesData{quote = quote.InnerText});
}
int i = 0; 
foreach(var author in AuthorHeader){
    quotes[i].author = author.InnerText;
    i++;
}
foreach(var quote in quotes){
    Console.WriteLine(quote.quote);
    Console.WriteLine(quote.author); 
}

using(var writer = new StreamWriter(Environment.GetEnvironmentVariable("PATH")))
using(var csv = new CsvWriter(writer, CultureInfo.InvariantCulture)){
    csv.WriteRecords(quotes);
}
