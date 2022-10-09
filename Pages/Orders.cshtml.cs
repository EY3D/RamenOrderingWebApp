using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RamenOrderingWebApp.Models;
using RamenOrderingWebApp.Data;

namespace RamenOrderingWebApp.Pages
{
    public class OrdersModel : PageModel
    {
        public List<RamenOrder> RamenOrders = new List<RamenOrder>();
        readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            RamenOrders = _context.RamenOrders.ToList();
        }
    }
}
