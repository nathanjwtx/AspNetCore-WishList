using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET
        public IActionResult Index()
        {
            var items = _context.Items;
            return View("Index", items.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        // [HttpPost]
        // public IActionResult Create(Item item)
        // {
        //     _context.Items.Add(item);
        //     _context.SaveChanges();
        //
        //     RedirectToAction(Index());
        // }
    }
}
