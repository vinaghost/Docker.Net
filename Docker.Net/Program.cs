using Docker.Net;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
builder.BindConfiguration();
builder.Services.AddHostedService<StartUp>();

var host = builder.Build();
await host.RunAsync();