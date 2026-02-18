using UnityEngine;

/// <summary>
/// GoF单例模式
/// 具有全局访问和单一实例两个功能
/// </summary>
public class MonoSingleton : MonoBehaviour
{
    // 静态实例，全局访问点
    public static MonoSingleton Instance { get; private set; }

    private string info;
    private void Awake()
    {
        // 常见的单例保证逻辑
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void WriteInfo(string message)
    {
        info = message;
    }
    public void ShowInfo()
    {
        Debug.Log(info);
    }
}
