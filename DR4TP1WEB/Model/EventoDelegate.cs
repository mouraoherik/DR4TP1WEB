namespace DR4TP1WEB.Model;

public class EventoDelegate
{
    public class EventService
    {
        private readonly List<Evento> _events = new();
        
        public Action<Evento>? OnEventCreated { get; set; }

        public EventService()
        {
            OnEventCreated = (ev) =>
            {
                Console.WriteLine($"[LOG DE EVENTO] Criado: '{ev.Titulo}' | Data: {ev.Data:dd/MM/yyyy HH:mm} | Local: {ev.Local}");
            };
        }

        public void AddEvent(Evento ev)
        {
            ev.Id = _events.Count + 1;
            _events.Add(ev);
            
            OnEventCreated?.Invoke(ev);
        }

        public IEnumerable<Evento> GetAllEvents() => _events;
    }
}