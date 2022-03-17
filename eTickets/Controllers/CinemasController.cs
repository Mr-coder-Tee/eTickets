using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var allCinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
