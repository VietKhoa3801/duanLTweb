using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PizzaPlace_2022.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//using PizzaPlace_2022.Client.Services;
using PizzaPlace_2022.Shared;
using Syncfusion.Blazor.Charts;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient 
    { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services
//    .AddTransient<IMenuService, MenuService>();
builder.Services
    .AddTransient<IMenuService, HardCodedMenuService>();
builder.Services
    .AddTransient<IOrderService, ConsoleOrderService>();

await builder.Build().RunAsync();

