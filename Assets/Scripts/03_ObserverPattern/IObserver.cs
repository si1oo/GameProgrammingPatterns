/// <summary>
/// 观察者接口
/// </summary>
public interface IObserver
{
    public void OnNotify(string entityEvent);
}