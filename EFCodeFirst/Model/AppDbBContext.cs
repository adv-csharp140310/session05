using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Model;
public class AppDbBContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140310_ef;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EFCodeFirst");
        optionsBuilder.LogTo(msg => Debug.WriteLine(msg));
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Blog> Blogs { get; set; }

}
