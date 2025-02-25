using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Pagina2Model : PageModel
    {


        public void OnGet(string Mensaje)
        {
            ViewData["MSG"] = Mensaje;

        }
    }
}
