using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantMenuProject.ViewComponents.Food
{
    public class FoodCategoryList : ViewComponent
    {
        FoodCategoryManager foodCategoryManager = new FoodCategoryManager(new EfFoodCategoryDal());

        public IViewComponentResult Invoke()
        {
            var values = foodCategoryManager.TGetList().ToList();
            return View(values);
        }

    }
}
