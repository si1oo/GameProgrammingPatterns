using UnityEngine;

namespace _Example13
{
    /// <summary>
    /// 子弹脚本
    /// 使用对象池管理
    /// </summary>
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float lifetime = 3f;
        private float timer;

        //对象池，这里采用对象与池耦合模式
        private BulletPool pool;

        /// <summary>
        /// 由对象池调用，初始化子弹并设置归属池
        /// </summary>
        public void Initialize(BulletPool ownerPool, float lifeTime)
        {
            pool = ownerPool;
            lifetime = lifeTime;
            timer = lifetime;
            gameObject.SetActive(true);
        }

        private void Update()
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                ReturnToPool();
            }
        }

        /// <summary>
        /// 将子弹归还给对象池
        /// </summary>
        private void ReturnToPool()
        {
            if (pool != null)
            {
                pool.ReturnBullet(this);
            }
            else
            {
                Destroy(gameObject); //处理外部使用"Instantiate"创建的情况
            }
        }
    }
}