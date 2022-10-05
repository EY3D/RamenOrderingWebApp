namespace RamenOrderingWebApp.Models
{
    public class RamenModel
    {
        public string RamenName { get; set; }
        public string ImagePath { get; set; }
        public float BasePrice { get; set; } = 3;
        public enum SoupBase { PorkBone, Garlic, Salt, SpicySalt, Miso }
        public bool ChaSiew2Pc { get; set; }
        public bool OnsenEgg { get; set; }
        public bool EnokiMushrooms { get; set; }
        public bool BambooShoots { get; set; }
        public bool SpringOnion { get; set; }
        public float FinalPrice { get; set; }
    }
}
