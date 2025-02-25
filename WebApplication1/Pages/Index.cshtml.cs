using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Mensaje {get; set;}
    
    public void OnGet()
    {
        ViewData["Mensaje"] = "Hola mundo";
        Mensaje = "Hola Mundo 2";
        
       
    }

    public void OnPost()
    {
        
        Response.Redirect("Pagina2?Mensaje="+Mensaje); 

    }

}
