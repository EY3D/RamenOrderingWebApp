using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RamenOrderingWebApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string RamenName { get; set; }
        public float RamenPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if(string.IsNullOrEmpty(RamenName))
            {
                RamenName = "My ramen";
            }
            if(string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }
        }
    }
}
