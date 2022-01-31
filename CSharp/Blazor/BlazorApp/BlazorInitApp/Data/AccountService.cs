using BlazorInitApp.Models.Views;
using MongoDB.Driver;

namespace BlazorInitApp.Data
{
    public class AccountService
    {
        private readonly IMongoCollection<Account> _account;

        public AccountService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("ConnectionStrings:MongoDbConnect").ToString());
            var database = client.GetDatabase("ExerciseMongo");

            _account = database.GetCollection<Account>("Account");
        }
 
        public async Task<List<AccountViewModel>> GetAccountsAsync()
        {
            var data = await _account.Find(p => true).ToListAsync();
            return data.Select(p => new AccountViewModel
            {
                Id = p._id.ToString(),
                Username = p.username,
                Fullname = p.fullname,
                Gender = p.gender
            }).ToList();
        }
    }
}