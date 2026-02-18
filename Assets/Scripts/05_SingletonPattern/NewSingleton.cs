using System;
using UnityEngine;

/// <summary>
/// 仅保证单一实例
/// </summary>
public class NewSingleton : IDisposable
{
    // 静态标记，用于检测多实例
    private static bool isInstantiated = false;

    private string info;
    public NewSingleton()
    {
        //断言保证唯一性
        if (isInstantiated)
        {
            throw new InvalidOperationException("NewSingleton 已被实例化，不允许创建第二个实例！");
        }
        isInstantiated = true;
    }
    public void WriteInfo(string message)
    {
        info = message;
    }
    public void ShowInfo()
    {
        Debug.Log(info);
    }

    public void Dispose()
    {
        // 清理标记，支持重建（例如场景卸载时）
        isInstantiated = false;
    }
}