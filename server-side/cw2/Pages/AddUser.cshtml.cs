using cw2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class AddUserModel : PageModel
    {
        [BindProperty]
        public User? MyUser { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
        }
    }
}
