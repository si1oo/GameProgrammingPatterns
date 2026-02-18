using UnityEngine;
public enum SoundId { Swoosh, FireBlast, Heal }
public enum ParticleType { Dust, Sparkles, Fire }

/// <summary>
/// 子类沙箱模式：基类
/// 这里模拟一个技能的创建
/// </summary>
public abstract class Skill
{
    private AudioManager audioManager;

    public Skill()
    {
        audioManager = new AudioManager();
    }
    /// <summary>
    /// 这里采用双段初始化的方法
    /// </summary>
    public void Init()
    {
        Debug.Log("初始化成功");
    }

    //基类提供的一些操作
    protected void PlaySound(SoundId sound, float volume = 1.0f)
    {
        //DoSometing...
        audioManager.PlaySound(sound, volume);
    }

    protected void SpawnParticles(ParticleType type, int count)
    {
        //DoSometing...
        Debug.Log($"生成粒子: {type}，数量: {count}");
    }

    protected void MoveCharacter(Vector3 delta)
    {
        Debug.Log("玩家移动");
    }

    /// <summary>
    /// 子类必须实现该方法来定义子类的具体行为
    /// </summary>
    protected abstract void Activate();

    /// <summary>
    /// 外部调用接口
    /// </summary>
    public void UseSkill()
    {
        Activate();
    }
}

/// <summary>
/// 一个音效管理器
/// </summary>
public class AudioManager
{
    //其他音效函数...

    public void PlaySound(SoundId sound, float volume = 1.0f)
    {
        Debug.Log($"播放声音: {sound}，音量: {volume}");
    }
}