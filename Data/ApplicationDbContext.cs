using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFood.Models;
using MyFood.Models.ViewModels;

namespace MyFood.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<MainCourse> MainCourses { get; set; }

        public DbSet<Soup> Soups { get; set; }
        
        public DbSet<Cake> Cakes { get; set; }

        public DbSet<Dessert> Desserts { get; set; }

        public DbSet<IceCream> IceCreams { get; set; }

        public DbSet<Drinks> Drinks { get; set; }

        public DbSet<Alcohols> Alcohols { get; set; }

        public DbSet<Appetizer> Appetizers { get; set; }

        public DbSet<Salads> Salads { get; set; }

        public DbSet<Snacks> Snacks { get; set; }

    }
}
