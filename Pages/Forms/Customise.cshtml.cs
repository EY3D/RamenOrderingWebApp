using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RamenOrderingWebApp.Models;

namespace RamenOrderingWebApp.Pages.Forms
{
    public class CustomiseModel : PageModel
    {
        [BindProperty]
        public RamenModel Ramen { get; set; }
        public void OnGet()
        {
        }
    }
}
