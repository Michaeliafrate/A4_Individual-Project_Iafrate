using ClosetCastMVC.Models;

namespace ClosetCastMVC.Services
{
    public interface IOutfitRecommendationService
    {
        List<string> GetRecommendedCategories(WeatherData weather);

        int GetWarmthLevel(WeatherData weather);

        bool NeedsWaterproof(WeatherData weather);

        List<string> GetOutfitTips(WeatherData weather);

        List<ClothingItem> PickOutfit(List<ClothingItem> items, List<string> categories, int warmthLevel);
    }
}
