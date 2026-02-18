using UnityEngine;
/// <summary>
/// 沙箱模式：子类
/// 简单的治疗效果
/// </summary>
public class HealSkill : Skill
{
    public float healAmount = 50f;
    protected override void Activate()
    {
        PlaySound(SoundId.Heal);
        SpawnParticles(ParticleType.Sparkles, 15);

        Debug.Log($"治疗 {healAmount} 点生命值");
    }
}