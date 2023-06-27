using APiAuthAngular.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ApiAuthAngular.Data
{
    public class AuthAngular : DbContext
    {
        public AuthAngular(DbContextOptions<AuthAngular> options) : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}
