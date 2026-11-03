using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP1WEB.Pages;

public class AdicionarProduto : PageModel
{
    
    [BindProperty]
    public string? Nome { get; set; }

    [BindProperty]
    public decimal? Preco { get; set; }
    
    public bool Enviado { get; private set; }
    
    
    public void OnGet()
    {
    }

    public void OnPost()
    {
        Enviado = true;

    }
}