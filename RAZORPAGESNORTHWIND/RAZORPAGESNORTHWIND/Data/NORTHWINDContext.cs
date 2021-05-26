using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RAZORPAGESNORTHWIND.Models;

    public class NORTHWINDContext : DbContext
    {
        public NORTHWINDContext (DbContextOptions<NORTHWINDContext> options)
            : base(options)
        {
        }

        public DbSet<RAZORPAGESNORTHWIND.Models.Product> Product { get; set; }
    }
