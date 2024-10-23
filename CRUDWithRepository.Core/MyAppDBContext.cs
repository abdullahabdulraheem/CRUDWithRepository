using System;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithRepository.Core;

public class MyAppDBContext : DbContext
{
    public MyAppDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
