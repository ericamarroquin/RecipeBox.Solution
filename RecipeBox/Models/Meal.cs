using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RecipeBox.Models
{
  public class Meal
  {
    public string StrMeal { get; set; }
    public string StrCategory { get; set; }
    public string StrInstructions { get; set; }
    public string StrSource { get; set; }

    public static Meal GetMeal()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Meal meal = JsonConvert.DeserializeObject<Meal>(jsonResponse["meals"][0].ToString());
      return meal;
    }
  }
}