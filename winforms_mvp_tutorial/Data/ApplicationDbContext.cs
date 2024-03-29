﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winforms_mvp_tutorial.Models;

namespace winforms_mvp_tutorial.Data
{
    class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {

        }

        // Categories
        public virtual DbSet<Category> Categories { get; set; }

        // Products
        public virtual DbSet<Product> Products { get; set; }

        // Customers
        public virtual DbSet<Customer> Customers { get; set; }

        // Orders
        public virtual DbSet<Order> Orders { get; set; }

        // Profiles
        public virtual DbSet<Profile> Profiles { get; set; }

        // Users
        public virtual DbSet<User> Users { get; set; }
    }
}
