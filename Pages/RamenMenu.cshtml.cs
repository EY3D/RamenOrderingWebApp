using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RamenOrderingWebApp.Models;

namespace RamenOrderingWebApp.Pages
{
    public class RamenMenuModel : PageModel
    {
        public List<RamenModel> fakeRamenDB = new()
        {
            new RamenModel()
            {

            }
        };
        public void OnGet()
        {
        }
    }
}
