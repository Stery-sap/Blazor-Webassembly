using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        private readonly List<EventModel> events = new();

        public void AddEvent(EventModel evnt)
        {
            events.Add(evnt);
        }

        public void DeleteEvent(string name)
        {
            var evnt = events.FirstOrDefault(e => e.Name == name);
            if (evnt != null)
            {
                events.Remove(evnt);
            }
        }

        public List<EventModel> SearchEvents(string keyword)
        {
            return events
                .Where(e => e.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            e.Location.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<EventModel> GetAllEvents() => events;
        public void MarkAttendance(string eventName, string attendeeName)
    {
        var ev = events.FirstOrDefault(e => e.Name == eventName);
        if (ev != null && !ev.Attendees.Contains(attendeeName))
        {
            ev.Attendees.Add(attendeeName);
        }
    }
    
    public List<string> GetAttendees(string eventName)
    {
        var ev = events.FirstOrDefault(e => e.Name == eventName);
        return ev?.Attendees ?? new();
    }
    }
}