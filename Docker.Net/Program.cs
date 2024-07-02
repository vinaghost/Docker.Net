using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

var configuration = builder.Build();

var greeting = configuration.GetValue(typeof(string), "AppSettings:Greeting")?.ToString();

var myConnectString = configuration.GetConnectionString("MyConnectionString");

Console.WriteLine(greeting);
Console.WriteLine(myConnectString);