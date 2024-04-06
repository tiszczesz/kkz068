using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class UpdateModel : PageModel
    {
        public void OnGet(int id)
        {
            ViewData["id"] = id;
        }
    }
}
