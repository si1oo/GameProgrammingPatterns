namespace _Example10
{
    using System.Collections.Generic;
    using UnityEngine;

    public static class AudioSystem
    {
        /// <summary>
        /// 事件队列数据结构
        /// </summary>
        private static readonly Queue<PlayMessage> pending = new Queue<PlayMessage>();

        private const int MAX_PENDING = 64;

        /// <summary>
        /// 输入音效事件
        /// </summary>
        /// <param name="id"></param>
        /// <param name="volume"></param>
        public static void PlaySound(SoundId id, float volume)
        {
            if (pending.Count >= MAX_PENDING)
            {
                Debug.LogWarning($"AudioSystem queue overload! Dropping sound: {id}");
                return;
            }

            pending.Enqueue(new PlayMessage { id = id, volume = Mathf.Clamp01(volume) });
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        public static void Update()
        {
            int processCount = Mathf.Min(pending.Count, 5);

            for (int i = 0; i < processCount; i++)
            {
                PlayMessage msg = pending.Dequeue();
                ActuallyPlaySound(msg.id, msg.volume);
            }
        }

        /// <summary>
        /// 真正的播放逻辑
        /// </summary>
        private static void ActuallyPlaySound(SoundId id, float volume)
        {
            Debug.Log($"Playing sound: {id} at volume {volume}");
        }
    }
}