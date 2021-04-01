using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Midterm2FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm2FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IQuoteRepository _repository;
        
        private QuoteListDbContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, IQuoteRepository repository, QuoteListDbContext context)
        {
            _logger = logger;
            _repository = repository;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult InputQuote()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InputQuote(QuoteInfo quoteInput)
        {
            if (ModelState.IsValid)
            {
                _context.QuoteInfo.Add(quoteInput);
                _context.SaveChanges();
                return View("Confirmation");
            }
            return View(quoteInput);
        }

        public IActionResult QuoteList ()
        {
            return View(_repository.QuoteInfo);
        }

        public IActionResult Delete (int id)
        {
            QuoteInfo itemRemove = _context.QuoteInfo.Where(x => x.QuoteID == id).FirstOrDefault();
            _context.QuoteInfo.Remove(itemRemove);
            _context.SaveChanges();
            return View("Confirmation");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            QuoteInfo itemUpdate = _context.QuoteInfo.Where(x => x.QuoteID == id).FirstOrDefault();
            return View(itemUpdate);
        }

        [HttpPost]
        public IActionResult Update (QuoteInfo updatedObj)
        {
            if (ModelState.IsValid)
            {
                QuoteInfo itemUpdate = _context.QuoteInfo.Where(x => x.QuoteID == updatedObj.QuoteID).FirstOrDefault();
                itemUpdate.Quote = updatedObj.Quote;
                itemUpdate.AuthorSpeaker = updatedObj.AuthorSpeaker;
                itemUpdate.Date = updatedObj.Date;
                itemUpdate.Subject = updatedObj.Subject;
                itemUpdate.Citation = updatedObj.Citation;
                _context.SaveChanges();
                return View("Confirmation");
            }

            return View(updatedObj);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
