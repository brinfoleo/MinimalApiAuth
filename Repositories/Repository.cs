using MinimalApiAuth.Models;

namespace MinimalApiAuth.Repositories
{
    public static class Repository
    {
        public static User Get(string userName, string password)
        {
            var users = new List<User>
            {
            new User {Id=1,UserName="batman", Password="batman", Role="manager"},
            new User {Id=1,UserName="robin", Password="robin", Role="employee"}
            };
            return (User)users.Where(x => x.UserName.ToLower() == userName.ToLower() && x.Password.ToLower() == password.ToLower());
        }
    }
}