using DR4TP1WEB.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP1WEB.Pages.Evento;

public class CriarEvento : PageModel
{
    public EventoDelegate.EventService _eventService;

    public CriarEvento(EventoDelegate.EventService eventService)
    {
        _eventService = eventService;
    }

    [BindProperty] public Model.Evento Event { get; set; } = new();

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }


        _eventService.AddEvent(Event);

        return RedirectToPage("./Index");
    }
}