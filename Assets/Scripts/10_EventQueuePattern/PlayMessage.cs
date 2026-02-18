namespace _Example10
{
    /// <summary>
    /// 声音类型
    /// 用于确定播放的音效资源
    /// </summary>
    public enum SoundId
    {
        Bloop,
        EnemyGroan,
        BossRoar
    }

    /// <summary>
    /// 音效消息，存储在事件队列中
    /// </summary>
    public struct PlayMessage
    {
        public SoundId id;
        public float volume; // 0~1
    }
}