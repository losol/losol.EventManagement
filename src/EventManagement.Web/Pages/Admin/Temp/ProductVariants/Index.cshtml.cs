using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using losol.EventManagement.Domain;
using losol.EventManagement.Infrastructure;

namespace losol.EventManagement.Pages.Admin.Temp.ProductVariants
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ProductVariant> ProductVariant { get;set; }

        public async Task OnGetAsync()
        {
            ProductVariant = await _context.ProductVariants
                .Include(p => p.Product).ToListAsync();
        }
    }
}
