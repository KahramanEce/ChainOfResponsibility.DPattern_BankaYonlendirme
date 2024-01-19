using Microsoft.EntityFrameworkCore;

namespace Chain_of__Responsibility.DesignPattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ECE\\SQLSV;initial catalog=DesigP.ChainOfR.;integrated security=true;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}
