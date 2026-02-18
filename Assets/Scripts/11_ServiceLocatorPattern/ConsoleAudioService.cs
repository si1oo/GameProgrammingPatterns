namespace _Example11
{
    using UnityEngine;

    /// <summary>
    /// 服务提供者
    /// 实现具体的功能
    /// </summary>
    public class ConsoleAudioService : IAudioService
    {
        public void PlaySound(int soundId)
        {
            Debug.Log($"[ConsoleAudio] Playing sound {soundId}");
        }
        public void StopSound(int soundId)
        {
            Debug.Log($"[ConsoleAudio] Stopping sound {soundId}");
        }
        public void StopAllSounds()
        {
            Debug.Log("[ConsoleAudio] Stopping all sounds");
        }
    }

    /// <summary>
    /// 空服务实现
    /// </summary>
    public class NullAudioService : IAudioService
    {
        public void PlaySound(int soundId) { }
        public void StopSound(int soundId) { }
        public void StopAllSounds() { }
    }
}