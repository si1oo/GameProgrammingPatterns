using UnityEngine;

/// <summary>
/// 测试类
/// </summary>
public class Example08 : MonoBehaviour
{
    HealSkill healSkill;
    void Start()
    {
        healSkill = new HealSkill();
        healSkill.Init();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            healSkill.UseSkill();
        }
    }
}
