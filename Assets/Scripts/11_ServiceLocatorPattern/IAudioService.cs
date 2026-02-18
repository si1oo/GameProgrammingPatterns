namespace _Example11
{
    /// <summary>
    /// 服务接口
    /// 
    /// </summary>
    public interface IAudioService
    {
        void PlaySound(int soundId);
        void StopSound(int soundId);
        void StopAllSounds();
    }
}