using Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Contexts
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options): base(options)
        {

        }
    }
}
