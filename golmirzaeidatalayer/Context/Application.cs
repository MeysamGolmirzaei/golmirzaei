using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using golmirzaeidatalayer.Entities.User;


namespace golmirzaeidatalayer.Context 
{
public class Application : DbContext
    {
        public Application(DbContextOptions<Application> options) : base(options)
        {
        }
        public DbSet<Tbl_User> tbl_Users {get;set;}
    }

    public class ToDoContextFactory : IDesignTimeDbContextFactory<Application>
    {
        public Application CreateDbContext(string[] args)
        {
            //نام جدول
            var builder = new DbContextOptionsBuilder<Application>();
            builder.UseSqlServer("Data Source=.;initial Catalog=golmirzaei;integrated Security=SSPI;MultipleActiveResultSets=true");
            return new Application(builder.Options);
        }
    }
}