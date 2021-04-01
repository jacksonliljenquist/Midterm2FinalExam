using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2FinalExam.Models
{
    public class EFQuoteListRepository : IQuoteRepository
    {
        private QuoteListDbContext _context;
        
        public EFQuoteListRepository (QuoteListDbContext context)
        {
            _context = context;
        }

        public IQueryable<QuoteInfo> QuoteInfo => _context.QuoteInfo;
    }
}
