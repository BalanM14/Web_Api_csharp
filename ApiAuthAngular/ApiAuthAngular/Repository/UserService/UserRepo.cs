using ApiAuthAngular.Controllers;
using ApiAuthAngular.Data;
using ApiAuthAngular.Repository.Interface;
using APiAuthAngular.Models;
using System.Diagnostics;

namespace ApiAuthAngular.Repository.UserService
{
    public class UserRepo : IBaserepo<string, User>
    {
        private readonly AuthAngular _context;

        public UserRepo (AuthAngular context)
        {
            _context = context;
        }
        public User Add(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(item);
            }
            return null;
        }

        public User Get(string key)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == key);
            return user;
        }
    }
}
