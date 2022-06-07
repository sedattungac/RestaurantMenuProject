using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuProject.Controllers
{
    public class DefaultController : Controller
    {
        FoodManager foodManager = new FoodManager(new EfFoodDal());
        FoodCategoryManager foodCategoryManager = new FoodCategoryManager(new EfFoodCategoryDal());
        Context c = new Context();

        public IActionResult Index()
        {
            var values = foodCategoryManager.TGetList();
            return View(values);
        }
        public IActionResult Foods(int id)
        {
            ViewBag.categoryName = c.Foods.Include(x => x.FoodCategory).Where(x => x.FoodCategoryId == x.FoodCategory.FoodCategoryId).Select(x => x.FoodCategory.Title).FirstOrDefault();
            var values = c.Foods.Include(x => x.FoodCategory).Where(x => x.FoodCategoryId == id).ToList();
            return View(values);
        }

    }
}
