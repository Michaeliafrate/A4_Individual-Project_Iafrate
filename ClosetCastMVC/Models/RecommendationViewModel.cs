namespace ClosetCastMVC.Models
{
    public class RecommendationViewModel
    {
        // Weather information
        public WeatherData Weather { get; set; }

        // How warm the clothes should be (1 to 5)
        public int WarmthLevel { get; set; }

        // true when it is wet outside (rain, snow, storms)
        public bool NeedsWaterproof { get; set; }

        // List of clothing categories to wear today
        public List<string> RecommendedCategories { get; set; }

        // Tips about the weather (umbrella, sunglasses, etc.)
        public List<string> OutfitTips { get; set; }

        // One item from each category picked from the closet
        public List<ClothingItem> TodaysOutfit { get; set; }

        // Every other item in the closet that also works today
        public List<ClothingItem> OtherOptions { get; set; }

        // City selected by the user
        public string SelectedCity { get; set; }
    }
}
