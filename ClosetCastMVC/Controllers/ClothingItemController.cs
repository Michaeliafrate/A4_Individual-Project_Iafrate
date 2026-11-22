using ClosetCastMVC.Data;
using ClosetCastMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClosetCastMVC.Controllers
{
    public class ClothingItemController : Controller
    {
        private ClosetCastDbContext _context;


        public ClothingItemController(ClosetCastDbContext context ) //dependency injection
        {
            _context = context;//context exists only within the body of this method

        }




        public IActionResult Index(string? searchTerm, string? categoryName, decimal? minPrice, decimal? maxPrice, DateTime? purchasedAfter, DateTime? purchasedBefore)//displays all the clothing items
        {
           // var clothingList = _context.ClothingItems.ToList();//fetches a list of clothing items from the clothing items table

            //return View(clothingList);//passes the clothing list to the view

            var items = _context.ClothingItems.AsQueryable();


            if(!string.IsNullOrWhiteSpace(searchTerm))
            {
                items = items.Where(
                    c => c.Name.Contains(searchTerm) ||
                    c.Description.Contains(searchTerm));

            }

            if(!string.IsNullOrWhiteSpace(categoryName))
            {
                items = items.Where(c => c.Category.Contains(categoryName));

            }


            if(minPrice.HasValue)
            {

                items = items.Where(c => c.Price >= minPrice);
            }

            if (maxPrice.HasValue)
            {

                items = items.Where(c => c.Price <= maxPrice);
            }

            if(purchasedAfter.HasValue)
            {

                items = items.Where(c => c.DatePurchased >= purchasedAfter);
            }

            if (purchasedBefore.HasValue)
            {

                items = items.Where(c => c.DatePurchased <= purchasedBefore);
            }

            //keep the user input values to be displayed on the page
            ViewData["searchTerm"] = searchTerm;
            ViewData["category"] = categoryName;
            ViewData["minPrice"] = minPrice;
            ViewData["maxPrice"] = maxPrice;
            ViewData["PurchasedAfterSearch"] = purchasedAfter?.ToString("yyyy-MM-dd");
            ViewData["PurchasedBeforeSearch"] = purchasedBefore?.ToString("yyyy-MM-dd");



            return View(items.ToList());
        }


        [HttpGet]
        public IActionResult Create()//create a new clothing item record
        {
            return View();//returns a blank form to the user
        }


        [HttpPost]
        public IActionResult Create(ClothingItem itemObj)
        {
            _context.ClothingItems.Add(itemObj);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult Details(int id)
        {
            var retrievedItem = _context.ClothingItems.Find(id);//find the clothing item which has the id that was passed in and save it in the retrievedItem var


            return View(retrievedItem);
        }


        public IActionResult Edit(int id)
        {
            //talk to the database and fetch the clothing item that the user would like to edit
            var retrievedItem = _context.ClothingItems.Find(id);

            return View(retrievedItem);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ClothingItemId, Name, Description, Category, WarmthLevel, IsWaterproof, DatePurchased, Price")] ClothingItem updatedItem)
        {
            //talk to the database and save the data that the user has provided
            if (ModelState.IsValid)
            {
                _context.ClothingItems.Update(updatedItem);

                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            //talk to the database and fetch the clothing item that the user has requested to be deleted
            ClothingItem retrievedItem = _context.ClothingItems.Find(id);

            return View(retrievedItem);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(ClothingItem item)
        {
            // var item = _context.ClothingItems.Find(id);

            _context.ClothingItems.Remove(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
