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
        public IActionResult OnPost()
        {
            if(ModelState.IsValid){
                //dodawanie do pliku MyUser
                UsersRepo repo = new UsersRepo();
                if(MyUser != null){
                     repo.AddToFile(MyUser);
                }               
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
