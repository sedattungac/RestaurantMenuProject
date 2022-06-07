using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuProject.ViewComponents.Food
{
    public class FoodList : ViewComponent
    {
        FoodManager foodManager = new FoodManager(new EfFoodDal());


        public IViewComponentResult Ignore()
        {
            var values = foodManager.GetFoodWithFoodCategory();
            return View(values);
        }
    }
}
