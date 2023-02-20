using Microsoft.EntityFrameworkCore;

namespace Sisreq.Identity.Infra
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
            
        }
    }
}