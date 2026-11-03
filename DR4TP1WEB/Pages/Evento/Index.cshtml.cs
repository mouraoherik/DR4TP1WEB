using DR4TP1WEB.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DR4TP1WEB.Pages.Evento;

public class Index : PageModel
{
    private readonly EventoDelegate.EventService _eventService;

    public Index(EventoDelegate.EventService eventService)
    {
        _eventService = eventService;
    }

    public IEnumerable<Model.Evento> Events { get; set; } = Enumerable.Empty<Model.Evento>();

    public void OnGet()
    {
        Events = _eventService.GetAllEvents();
    }
}