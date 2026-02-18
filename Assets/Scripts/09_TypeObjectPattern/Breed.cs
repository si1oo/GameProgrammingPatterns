using _Example09;

/// <summary>
/// 类型对象模式：品种类
/// 专门用于外部设置游戏角色数据
/// </summary>
[System.Serializable]
public class Breed
{
    public string breedName;           // 品种名称
    public int baseHealth;              // 基础血量（若为0则继承父类）
    public string attackDescription;    // 攻击描述（若为null则继承父类）
    public Breed parentBreed;           // 父品种（用于继承）

    public Breed(string name, int health, string atkDescription, Breed parent = null)
    {
        breedName = name;
        parentBreed = parent;

        if (parent != null)
        {
            baseHealth = (health != 0) ? health : parent.baseHealth;
            attackDescription = (!string.IsNullOrEmpty(atkDescription)) ? atkDescription : parent.attackDescription;
        }
        else
        {
            baseHealth = health;
            attackDescription = atkDescription;
        }
    }

    public int GetBaseHealth() => baseHealth;
    public string GetAttackDescription() => attackDescription;

    /// <summary>
    /// 获取当前类型的实例对象
    /// </summary>
    /// <returns></returns>
    public Monster NewMonster()
    {
        return new Monster(this);
    }
}