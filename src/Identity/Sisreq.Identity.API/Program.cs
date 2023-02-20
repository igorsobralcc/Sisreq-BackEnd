using Sisreq.Identity.API;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
startup.Configure(app, builder.Environment);