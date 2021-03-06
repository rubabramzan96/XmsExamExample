﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace XmsExam.Models
{
    public class LibraryContext: DbContext
    {
        public LibraryContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Book> books { get; set; }

        public DbSet<Course> Courses { get; set; }
    }

}
