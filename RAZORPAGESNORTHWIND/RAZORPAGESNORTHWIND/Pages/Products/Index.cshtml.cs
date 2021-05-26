using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RAZORPAGESNORTHWIND.Models;

namespace RAZORPAGESNORTHWIND.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly NORTHWINDContext _context;

        public IndexModel(NORTHWINDContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
