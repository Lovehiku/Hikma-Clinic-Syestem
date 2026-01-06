using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args: args ?? new string[0]);
var app = builder.Build();

// API project placeholder - no controllers or endpoints added per instructions

app.Run();
