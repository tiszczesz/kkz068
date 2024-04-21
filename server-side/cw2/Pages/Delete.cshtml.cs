using cw2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class DeleteModel : PageModel
    {
        private UsersRepo _repo;
        public DeleteModel()
        {
            _repo = new UsersRepo();//utworzenie obiektu 
        }
        public IActionResult OnGet(int? id)
        {
            //wczytac z pliku  do listy
            _repo.DeleteUser(id);

            
            //znalezc user do usuniecia
            //usunac z listy
            //zapisac calosc do pliku
            return RedirectToPage("Index");
        }
    }
}
