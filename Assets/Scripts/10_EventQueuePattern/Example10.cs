using _Example10;
using UnityEngine;

/// <summary>
/// 测试类
/// </summary>
public class Example10 : MonoBehaviour
{
    void Start()
    {
        //输入播放事件
        AudioSystem.PlaySound(_Example10.SoundId.EnemyGroan, .7f);

        //播放音频
        AudioSystem.Update();
    }


    void Update()
    {

    }
}
