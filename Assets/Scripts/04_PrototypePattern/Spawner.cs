using UnityEngine;
namespace _Example04
{
    public abstract class Monster
    {
        public abstract Monster Clone();
        public abstract void Attack();
    }

    public class Ghost : Monster
    {
        private int _health;
        private float _speed;

        public Ghost(int health, float speed)
        {
            _health = health;
            _speed = speed;
        }
        public override Monster Clone()
        {
            return new Ghost(_health, _speed);
        }

        public override void Attack() => Debug.Log("幽灵穿过身体，造成寒冷伤害");
    }

    public class Spawner
    {
        private Monster prototype;

        public Spawner(Monster prototype)
        {
            this.prototype = prototype;
        }

        public Monster SpawnMonster()
        {
            return prototype.Clone();
        }
    }
}