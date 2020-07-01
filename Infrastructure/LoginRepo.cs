using Core.Interfaces;
using System;
using System.Linq;

namespace Infrastructure
{
    public class LoginRepo : ILogin
    {

        public bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (BlogDbContext db = new BlogDbContext())
                {
                    return db.users.Any(u => u.userame.Equals(username) && u.password == password);                  
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
