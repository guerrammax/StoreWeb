using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base("DefaultConnection")
        {

        }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
     
}
