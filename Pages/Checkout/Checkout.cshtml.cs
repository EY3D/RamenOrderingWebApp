using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RamenOrderingWebApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string RamenName { get; set; }
        public float RamenPrice { get; set; }
        public string ImagePath { get; set; }
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
        }
    }
}
