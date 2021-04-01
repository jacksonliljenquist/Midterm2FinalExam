using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2FinalExam.Models
{
    public interface IQuoteRepository
    {
        public IQueryable<QuoteInfo> QuoteInfo { get; }
    }
}
