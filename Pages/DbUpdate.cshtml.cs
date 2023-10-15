using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MSWebPROJ2.Models;
using System.Diagnostics.Eventing.Reader;

// Nicholas Woerner
// This page is behind the DbUpdate.cshtml page and it supports the inputs etc.

namespace MSWebPROJ2.Pages
{
    public class DbUpdateModel : PageModel
    {
        private readonly ProfileContext _context;

        public DbUpdateModel(ProfileContext context)
        {
            _context = context;
        }

        [BindProperty]
        public new User? User { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id.HasValue)
            {
                User = _context.Users.Find(id);
                if (User == null)
                {
                    return NotFound();
                }
            }
            else
            {
                User = new User();
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (User != null)
            {
                if (User.ID > 0)
                {
                    _context.Users.Update(User);
                }
                else
                {
                    _context.Users.Add(User);
                }
                _context.SaveChanges();
            }
            return RedirectToPage("/Index");
        }
    }
}
