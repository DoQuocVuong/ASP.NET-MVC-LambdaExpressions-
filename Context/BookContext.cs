using ASP.NETMVCLambdaExpressions.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NETMVCLambdaExpressions.Context
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}