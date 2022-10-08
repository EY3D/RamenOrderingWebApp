using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RamenOrderingWebApp.Models;

namespace RamenOrderingWebApp.Pages.Forms
{
    public class CustomiseModel : PageModel
    {
        [BindProperty]
        public RamenModel Ramen { get; set; }
        public float RamenPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            RamenPrice = Ramen.BasePrice;

            switch (Ramen.SoupBase)
            {
                case Models.Enums.SoupBaseEnum.PorkBone:
                    RamenPrice += 2;
                    break;

                case Models.Enums.SoupBaseEnum.Garlic:
                    RamenPrice += 1;
                    break;

                case Models.Enums.SoupBaseEnum.Salt:
                    RamenPrice += 1;
                    break;

                case Models.Enums.SoupBaseEnum.SpicySalt:
                    RamenPrice += 1;
                    break;

                case Models.Enums.SoupBaseEnum.Miso:
                    RamenPrice += 1;
                    break;

                case Models.Enums.SoupBaseEnum.CreamOfMushroom:
                    RamenPrice += 2;
                    break;
            }

            if (Ramen.ChaSiew2Pc) RamenPrice += 3;
            if (Ramen.BeefChunks) RamenPrice += 3;
            if (Ramen.OnsenEgg) RamenPrice += 1;
            if (Ramen.EnokiMushrooms) RamenPrice += 1;
            if (Ramen.BambooShoots) RamenPrice += 0;
            if (Ramen.SpringOnion) RamenPrice += 0;

            return RedirectToPage("../Checkout/Checkout", new { Ramen.RamenName, RamenPrice });
        }
    }
}
