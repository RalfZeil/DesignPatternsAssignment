using System.Collections.Generic;

public static class EventManager<T>
{
    private static Dictionary<EventKind, System.Action<T>> listeners = new();

    public static void Subscribe(EventKind _evt, System.Action<T> _func)
    {
        //Create new key in dict if it doesnt exist yet
        if (!listeners.ContainsKey(_evt))
        {
            listeners.Add(_evt, null);
        }

        listeners[_evt] += _func;
    }

    public static void Unsubscribe(EventKind _evt, System.Action<T> _func)
    {
        if(listeners.ContainsKey(_evt) && listeners[_evt] != null)
        {
            listeners[_evt] -= _func;
        }
    }

    public static void Invoke(EventKind _evt, T _arg1)
    {
        listeners[_evt]?.Invoke(_arg1);
    }
}
