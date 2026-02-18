using UnityEngine;
using System.Collections.Generic;
/// <summary>
/// ±ªπ€≤Ï’ﬂ
/// </summary>
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    public void AddObserver(IObserver observer) => observers.Add(observer);
    public void RemoveObserver(IObserver observer) => observers.Remove(observer);
    public void Notify(string entityEvent)
    {
        foreach(var observer in observers)
        {
            observer.OnNotify(entityEvent);
        }
    }
    public void Clear() => observers.Clear();   
}

