using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2FinalExam.Models
{
    public class QuoteListDbContext : DbContext
    {
        public QuoteListDbContext(DbContextOptions<QuoteListDbContext> options) : base(options)
        {

        }

        public DbSet<QuoteInfo> QuoteInfo { get; set; }
    }
}
