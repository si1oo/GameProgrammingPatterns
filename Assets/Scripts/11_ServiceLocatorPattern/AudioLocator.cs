namespace _Example11
{
    /// <summary>
    /// 服务定位器
    /// 使用静态类提供全局访问
    /// </summary>
    public static class AudioLocator
    {
        private static IAudioService _service;
        private static readonly NullAudioService _nullService = new NullAudioService();

        static AudioLocator()
        {
            // 默认初始化为空服务
            _service = _nullService;
        }

        public static IAudioService GetAudio()
        {
            return _service;
        }

        public static void Provide(IAudioService service)
        {
            _service = service ?? _nullService; 
        }
    }
}