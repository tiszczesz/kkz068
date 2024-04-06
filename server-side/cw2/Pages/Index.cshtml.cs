using cw2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public List<User> Users { get; set; }
        private UsersRepo _repo;
        
        public void OnGet()
        {
            _repo = new UsersRepo();
            Users = _repo.Users;
        }
    }
}
