using MinApi;
using MongoDB.Driver;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration.GetValue<string>("ConnectionStrings:MongoConn");

builder.Services.AddSingleton<AccountService>(new AccountService(conn));

var app = builder.Build();
app.MapGet("/", (AccountService accountService) =>
{
    var result = accountService.GetAccountAsync();

    return JsonConvert.SerializeObject(result);
});

app.Run();
