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
                RamenName = "Budget Ramen",
                ImagePath = "ramen-budget.jpg",
                SoupBase = Models.Enums.SoupBaseEnum.Salt,
                ChaSiew2Pc = false,
                BeefChunks = false,
                OnsenEgg = true,
                EnokiMushrooms = true,
                BambooShoots = true,
                SpringOnion = true,
                FinalPrice = 4
            },

            new RamenModel()
            {
                RamenName = "Classic Ramen",
                ImagePath = "ramen-classic.jpg",
                SoupBase = Models.Enums.SoupBaseEnum.PorkBone,
                ChaSiew2Pc = true,
                BeefChunks = false,
                OnsenEgg = true,
                EnokiMushrooms = true,
                BambooShoots = true,
                SpringOnion = true,
                FinalPrice = 8
            },

            new RamenModel()
            {
                RamenName = "Budget Ramen",
                ImagePath = "ramen-budget.jpg",
                SoupBase = Models.Enums.SoupBaseEnum.Salt,
                ChaSiew2Pc = false,
                BeefChunks = false,
                OnsenEgg = true,
                EnokiMushrooms = true,
                BambooShoots = true,
                SpringOnion = true,
                FinalPrice = 4
            },

            new RamenModel()
            {
                RamenName = "Mushroom Ramen",
                ImagePath = "ramen-creamofmushroom.jpg",
                SoupBase = Models.Enums.SoupBaseEnum.CreamOfMushroom,
                ChaSiew2Pc = false,
                BeefChunks = true,
                OnsenEgg = true,
                EnokiMushrooms = true,
                BambooShoots = true,
                SpringOnion = true,
                FinalPrice = 10
            },

            new RamenModel()
            {
                RamenName = "Miso Ramen",
                ImagePath = "ramen-miso.jpg",
                SoupBase = Models.Enums.SoupBaseEnum.Miso,
                ChaSiew2Pc = true,
                BeefChunks = false,
                OnsenEgg = true,
                EnokiMushrooms = true,
                BambooShoots = true,
                SpringOnion = true,
                FinalPrice = 8
            },

            new RamenModel()
            {
                RamenName = "Spicy Beef Ramen",
                ImagePath = "ramen-spicybeef.jpg",
                SoupBase = Models.Enums.SoupBaseEnum.SpicySalt,
                ChaSiew2Pc = false,
                BeefChunks = true,
                OnsenEgg = true,
                EnokiMushrooms = true,
                BambooShoots = true,
                SpringOnion = true,
                FinalPrice = 9
            }
        };
    }
}
