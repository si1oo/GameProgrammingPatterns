using System.Collections.Generic;
using UnityEngine;

namespace _Example13
{
    /// <summary>
    /// 对象池
    /// 管理子弹对象
    /// </summary>
    public class BulletPool : MonoBehaviour
    {
        [Header("Pool Settings")]
        [SerializeField] private GameObject bulletPrefab;  
        [SerializeField] private int initialPoolSize = 20; 
        [SerializeField] private bool expandIfNeeded = true; 

        private Queue<Bullet> availableBullets = new Queue<Bullet>();

        /// <summary>
        /// 初始化对象池
        /// </summary>
        private void Awake()
        {
            for (int i = 0; i < initialPoolSize; i++)
            {
                Bullet bullet = CreateNewBullet();
                bullet.gameObject.SetActive(false);
                availableBullets.Enqueue(bullet);
            }
        }

        /// <summary>
        /// 创建一颗新子弹并设置其归属池
        /// </summary>
        private Bullet CreateNewBullet()
        {
            GameObject obj = Instantiate(bulletPrefab, transform);
            Bullet bullet = obj.GetComponent<Bullet>();

            return bullet;
        }

        /// <summary>
        /// 从对象池中取对象
        /// </summary>
        public Bullet GetBullet(Vector3 position, Quaternion rotation, float lifeTime)
        {
            Bullet bullet = null;

            if (availableBullets.Count > 0)
            {
                bullet = availableBullets.Dequeue();
            }
            else if (expandIfNeeded)
            {
                bullet = CreateNewBullet();
            }
            else
            {
                Debug.LogWarning("对象池已空，无法生成新子弹！");
                return null;
            }

            bullet.transform.position = position;
            bullet.transform.rotation = rotation;

            bullet.Initialize(this, lifeTime);

            return bullet;
        }

        /// <summary>
        /// 子弹归还池中
        /// </summary>
        public void ReturnBullet(Bullet bullet)
        {
            bullet.gameObject.SetActive(false);
            availableBullets.Enqueue(bullet);
        }
    }
}