using DR4TP1WEB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP1WEB.Pages;

public class IndexModel : PageModel
{
    [BindProperty] public List<Produto> Produtos { get; set; } = new List<Produto>();

    public void OnGet()
    {
        Produtos.Add(new Produto("Coca",9.99m));
        Produtos.Add(new Produto("Pepsi",8.99m));
        Produtos.Add(new Produto("Fanta Laranja",8.45m));
    }
    
}