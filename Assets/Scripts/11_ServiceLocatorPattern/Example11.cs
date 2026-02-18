using _Example11;
using UnityEngine;
/// <summary>
/// 测试类
/// </summary>
public class Example11 : MonoBehaviour
{

    void Start()
    {
        IAudioService audioService = new ConsoleAudioService();
        AudioLocator.Provide(audioService);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioLocator.GetAudio().PlaySound(2);
        }
    }
}
