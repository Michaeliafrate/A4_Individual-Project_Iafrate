using ClosetCastMVC.Models;
using ClosetCastMVC.Services;

namespace ClosetCastMVC.Services
{
    public class OutfitRecommendationService : IOutfitRecommendationService
    {
        public List<string> GetRecommendedCategories(WeatherData weather)
        {
            var categories = new List<string>();

            // Everyone needs a top, bottom and shoes
            categories.AddRange(new[]
            {
                "Top",
                "Bottom",
                "Shoes"
            });

            // Add a jacket when it is cool, wet or windy
            if (weather.Temperature < 65 ||
                NeedsWaterproof(weather) ||
                weather.WindSpeed >= 15)
            {
                categories.Add("Outerwear");
            }

            // Accessories (sunglasses, umbrella, gloves, etc.)
            categories.Add("Accessory");

            return categories;
        }


        public int GetWarmthLevel(WeatherData weather)
        {
            // Hot weather
            if (weather.Temperature >= 80)
            {
                return 1;
            }
            // Warm weather
            else if (weather.Temperature >= 65)
            {
                return 2;
            }
            // Cool weather
            else if (weather.Temperature >= 50)
            {
                return 3;
            }
            // Cold weather
            else if (weather.Temperature >= 35)
            {
                return 4;
            }
            // Freezing weather
            else
            {
                return 5;
            }
        }


        public bool NeedsWaterproof(WeatherData weather)
        {
            string condition = (weather.WeatherCondition ?? "").ToLowerInvariant();

            // Wet weather
            if (condition.Contains("rain") ||
                condition.Contains("shower") ||
                condition.Contains("drizzle") ||
                condition.Contains("storm") ||
                condition.Contains("thunder") ||
                condition.Contains("snow") ||
                condition.Contains("sleet"))
            {
                return true;
            }

            // High chance of precipitation
            if (weather.PrecipitationProbability >= 50)
            {
                return true;
            }

            return false;
        }


        public List<string> GetOutfitTips(WeatherData weather)
        {
            var tips = new List<string>();

            string condition = (weather.WeatherCondition ?? "").ToLowerInvariant();

            // Stormy weather
            if (condition.Contains("storm") ||
                condition.Contains("thunder"))
            {
                tips.Add("Thunderstorms are possible. Wear a waterproof jacket and stay indoors if you can.");
            }

            // Snowy weather
            if (condition.Contains("snow") ||
                condition.Contains("sleet"))
            {
                tips.Add("Snow is in the forecast. Wear boots with good grip.");
            }

            // Rainy weather
            if (NeedsWaterproof(weather))
            {
                tips.Add("It may be wet outside. Grab an umbrella and waterproof shoes.");
            }

            // Windy weather
            if (weather.WindSpeed >= 15)
            {
                tips.Add("It is windy. Wear a jacket that blocks the wind.");
            }

            // Sunny and warm weather
            if ((condition.Contains("sun") || condition.Contains("clear")) &&
                weather.Temperature >= 70)
            {
                tips.Add("Sunny and warm. Bring sunglasses and wear sunscreen.");
            }

            // Freezing weather
            if (weather.Temperature <= 32)
            {
                tips.Add("Below freezing. Wear layers, gloves and a hat.");
            }

            // No tips
            if (tips.Count == 0)
            {
                tips.Add("Nice weather. Wear whatever you like!");
            }

            return tips;
        }


        public List<ClothingItem> PickOutfit(List<ClothingItem> items, List<string> categories, int warmthLevel)
        {
            var outfit = new List<ClothingItem>();

            // pick one item from each category
            foreach (string category in categories)
            {
                // the item with the warmth level closest to today's warmth level
                var bestItem = items
                    .Where(i => i.Category == category)
                    .OrderBy(i => Math.Abs(i.WarmthLevel - warmthLevel))
                    .FirstOrDefault();

                if (bestItem != null)
                {
                    outfit.Add(bestItem);
                }
            }

            return outfit;
        }
    }
}
