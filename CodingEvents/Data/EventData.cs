using CodingEvents.Models;

namespace CodingEvents.Data;

public class EventData
{
    private static Dictionary<int, Event> Events = new Dictionary<int, Event>();
    
    //fetch all events
    public static IEnumerable<Event> GetAll()
    {
        return Events.Values;
    }
    
    // Add new event
    public static void Add(Event newEvent)
    {
        Events.Add(newEvent.Id, newEvent);
    }
    
    //remove event
    public static void Remove(int id)
    {
        Events.Remove(id);
    }
    
    //fetch specific event
    public static Event GetById(int id)
    {
        return Events[id];
    }
}