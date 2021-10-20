using Microsoft.AspNetCore.Mvc;
using RecipeBox.Models;

namespace RecipeBox.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      public IActionResult RandomRecipe()
      {
        var randomRecipe = Meal.GetMeal();
        return View(randomRecipe);
      }
    }
}