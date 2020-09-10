using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BookListApp.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Book> Books { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Books = await _db.Book.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var Book = await _db.Book.FindAsync(id);
            _db.Book.Remove(Book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
