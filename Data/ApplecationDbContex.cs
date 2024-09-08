using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity1.Data
{
    public class ApplecationDbContex :IdentityDbContext 
    {
        public ApplecationDbContex(DbContextOptions <ApplecationDbContex> options) : base(options) { }
    }
}
