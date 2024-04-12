using ClashOfClansApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace ClashOfClansApi.Data
{
    public class IssueDbContext : DbContext {
        
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options)
        {

        }
    public DbSet<Issue> Issues
    {
        get;
        set;
    }

    }

    

}
