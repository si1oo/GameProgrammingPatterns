using UnityEngine;
/// <summary>
/// ≤‚ ‘¿‡
/// </summary>
public class Example05 : MonoBehaviour
{
    public NewSingleton newSingleton = null;
    private void Start()
    {
        MonoSingleton.Instance.WriteInfo("MonoSingleton: Hello World");

        newSingleton = new NewSingleton();
        newSingleton.WriteInfo("newSingleton: Hello World");

        MonoSingleton.Instance.ShowInfo();
        newSingleton.ShowInfo();
    }

}


