using LibraryPenalty.BLL.Abstract;
using LibraryPenalty.DAL.Entity;
using LibraryPenalty.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPenalty.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPenaltyService penaltyService;
        private readonly IBookService bookService;

        public HomeController(IPenaltyService penaltyService, IBookService bookService)
        {
            this.penaltyService = penaltyService;
            this.bookService = bookService;
        }
        public IActionResult Index()
        {
            return View(bookService.GetActive());

        }

        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book book )
        {
            bookService.Add(book);
            return RedirectToAction("Index");

        }

        public IActionResult AddPenalty( )
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult AddPenalty(Penalty penalty )
        {
            
             penaltyService.Add(penalty);
            
            return RedirectToAction("Index");

        }
        public IActionResult Order(Book book)
        {
            BookVM bookVM = new BookVM();
            bookVM.Book = bookService.GetById(book.ID);
            bookVM.Penalties = penaltyService.GetActive();
            return View(bookVM);

        }


    }
}
