using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Casgem_IdentityRole.DAL
{
    public class Context:IdentityDbContext<AppUser , AppRole , int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-1DJS186I;initial catalog=CasgemDbRole;integrated Security=true");
        }
    }
}
