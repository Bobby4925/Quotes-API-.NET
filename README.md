# Quotes API 
This project provides a simple C# Web API that delivers a random quote and its author upon request.

# Project Structure 
- `api` directory is the main directory for the C# Web API
- `api/Controllers/QuotesController.cs` is the file getting the quotes
- `api/quotes.csv` is the csv file including all the quotes which are read by the controller
- `scraper` is the main directory for the C# Scraping Program
- `scraper/Program.cs` is the main program running the scraper and `scraper/QuotesData` is the data model

# Running the Program 
1. Clone the github repo
2. Ensure you have the .NET SDK Installed (https://dotnet.microsoft.com/en-us/download)
3. First do `cd scraper` and run `dotnet run`
4. Next do `cd api` and run `dotnet watch` (`dotnet watch` allows for hot reload)
5. Now you are able to test the api with a window that pops up
6. Once all the steps are completed your done!
7. Now all you need to do is make a frontend app to send requests to this API to visualize the quotes!

# NOTE: 
Please only use the code included in this scraper on websites which explicitly allow for scraping to be done on their sites
