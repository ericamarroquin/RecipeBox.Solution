using System.Threading.Tasks;
using RestSharp;

namespace RecipeBox.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("https://www.themealdb.com/api/json/v1");
      RestRequest request = new RestRequest("1/random.php", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}