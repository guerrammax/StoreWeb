﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext(): base("DefaultConnection")
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
