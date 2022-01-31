using MongoDB.Driver;

namespace MinApi
{
    public class AccountService
    {
        private readonly IMongoCollection<Account> _account;

        public AccountService(string connectionStrings)
        {
            var client = new MongoClient(connectionStrings);
            var database = client.GetDatabase("ExerciseMongo");

            _account = database.GetCollection<Account>("Account");
        }

        public string SayHello()
        {
            return "Test Api";
        }

        public List<Account> GetAccountAsync()
        {
            return _account.Find(p => true).ToList();
        }
    }
}