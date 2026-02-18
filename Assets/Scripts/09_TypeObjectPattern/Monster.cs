namespace _Example09
{
    using UnityEngine;
    /// <summary>
    /// 类型对象模式：怪物类
    /// 数据通过Breed配置
    /// </summary>
    public class Monster
    {
        private int currentHealth;
        private Breed breed;    

        public Monster(Breed breed)
        {
            this.breed = breed;
            this.currentHealth = breed.GetBaseHealth();
        }

        public string Attack()
        {
            return breed.GetAttackDescription();
        }

        public void TakeDamage(int damage)
        {
            currentHealth -= damage;
            Debug.Log($"怪物受到 {damage} 点伤害，剩余血量 {currentHealth}");
        }

        public bool IsAlive => currentHealth > 0;
    }
}