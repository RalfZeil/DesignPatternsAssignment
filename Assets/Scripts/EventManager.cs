using System.Collections.Generic;

public enum EventKind
{
    OnHuntStart = 0,
    OnHuntEnd = 1,
    OnPlayerDeath = 2,
    OnPlayerEnterBuilding = 3,
}

public static class EventManager<T>
{
    private static Dictionary<EventKind, System.Action<T>> listeners = new();

    public static void Subscribe(EventKind evt, System.Action<T> func)
    {
        //Create new key in dict if it doesnt exist yet
        if (!listeners.ContainsKey(evt))
        {
            listeners.Add(evt, null);
        }

        listeners[evt] += func;
    }

    public static void Unsubscribe(EventKind evt, System.Action<T> func)
    {
        if(listeners.ContainsKey(evt) && listeners[evt] != null)
        {
            listeners[evt] -= func;
        }
    }

    public static void Invoke(EventKind evt, T arg1)
    {
        listeners[evt]?.Invoke(arg1);
    }
}
