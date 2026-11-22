using ClosetCastMVC.Data;
using ClosetCastMVC.Models;
using ClosetCastMVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClosetCastMVC.Controllers
{
    public class RecommendationController : Controller
    {
        private readonly ClosetCastDbContext _context;
        private readonly INOAAWeatherService _weatherService;
        private readonly IOutfitRecommendationService _outfitService;

        public RecommendationController(
            ClosetCastDbContext context,
            INOAAWeatherService weatherService,
            IOutfitRecommendationService outfitService)
        {
            _context = context;
            _weatherService = weatherService;
            _outfitService = outfitService;
        }

        // GET: Recommendation/Index
        public IActionResult Index()
        {
            return View();
        }

        // POST: Recommendation/Results
        [HttpPost]
        public async Task<IActionResult> Results(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                ModelState.AddModelError(
                    "city",
                    "Please enter a city.");

                return View("Index");
            }

            try
            {
                // Step 1: Retrieve weather information
                WeatherData weather =
                    await _weatherService.GetWeatherAsync(city);

                // Step 2: Determine what to wear based on the weather
                List<string> categories =
                    _outfitService.GetRecommendedCategories(weather);

                int warmthLevel =
                    _outfitService.GetWarmthLevel(weather);

                bool needsWaterproof =
                    _outfitService.NeedsWaterproof(weather);

                List<string> tips =
                    _outfitService.GetOutfitTips(weather);

                // Step 3: Retrieve matching clothes from the database
                // (right category and within 1 warmth level of today)
                List<ClothingItem> items = await _context.ClothingItems
                    .Where(c => categories.Contains(c.Category))
                    .Where(c => c.WarmthLevel >= warmthLevel - 1 &&
                                c.WarmthLevel <= warmthLevel + 1)
                    .ToListAsync();

                // if it is wet outside, jackets and shoes must be waterproof
                if (needsWaterproof)
                {
                    items = items
                        .Where(c => c.IsWaterproof ||
                                    (c.Category != "Outerwear" && c.Category != "Shoes"))
                        .ToList();
                }
                // if it is dry outside, skip rain gear (rain boots, umbrella, etc.)
                // warm waterproof items (level 4-5) are winter gear, so keep those
                else
                {
                    items = items
                        .Where(c => !c.IsWaterproof || c.WarmthLevel >= 4)
                        .ToList();
                }

                // Step 4: Pick today's outfit and build the ViewModel
                List<ClothingItem> outfit =
                    _outfitService.PickOutfit(items, categories, warmthLevel);

                var viewModel = new RecommendationViewModel
                {
                    Weather = weather,
                    SelectedCity = city,
                    WarmthLevel = warmthLevel,
                    NeedsWaterproof = needsWaterproof,
                    RecommendedCategories = categories,
                    OutfitTips = tips,
                    TodaysOutfit = outfit,
                    OtherOptions = items.Except(outfit).ToList()
                };

                // Step 5: Display results
                return View(viewModel);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(
                    "city",
                    $"Unable to retrieve recommendations: {ex.Message}");

                return View("Index");
            }
        }
    }
}
