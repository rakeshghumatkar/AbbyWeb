using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class BooksDbContext : DbContext 
    {
        public BooksDbContext(DbContextOptions<BooksDbContext> option ) : base(option)
        {  
        }
        public DbSet<Category> categories {get; set;}
        public DbSet<CoverType> coverTypes {get; set;}
    }
}