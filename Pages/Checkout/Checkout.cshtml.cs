using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RamenOrderingWebApp.Data;
using RamenOrderingWebApp.Models;

namespace RamenOrderingWebApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string RamenName { get; set; }
        public float RamenPrice { get; set; }
        public string ImagePath { get; set; }

        readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if(string.IsNullOrEmpty(RamenName))
            {
                RamenName = "My Ramen";
            }
            if(string.IsNullOrEmpty(ImagePath))
            {
                ImagePath = "~/images/BOWL_unsplash.com_sl_akariya.jpg";
            }
            else
            {
                ImagePath = "~/images/ramen/" + ImagePath;
            }

            RamenOrder ramenOrder = new RamenOrder();
            ramenOrder.RamenName = RamenName;
            ramenOrder.Price = RamenPrice;

            _context.RamenOrders.Add(ramenOrder);
            _context.SaveChanges();
        }
    }
}
