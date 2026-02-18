using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace _Example12
{
    /// <summary>
    /// 物品类
    /// </summary>
    [System.Serializable]
    public class Item
    {
        public string itemName;
        public float weight;
    }

    /// <summary>
    /// 仓库
    /// 使用脏标识，仅在物品数量发生变化时重新计算总重量
    /// </summary>
    public class Inventory
    {
        [SerializeField] private List<Item> items = new List<Item>();
        public int inventoryCount => items.Count;

        private bool isDirty = true;
        private float cachedTotalWeight;

        /// <summary>
        /// 添加物品，标记总重量为脏
        /// </summary>
        public void AddItem(Item newItem)
        {
            if (newItem != null)
            {
                items.Add(newItem);
                isDirty = true;
                Debug.Log($"Added {newItem.itemName} (weight: {newItem.weight})");
            }
        }

        /// <summary>
        /// 移除指定物品，标记总重量为脏
        /// </summary>
        public void RemoveLastItem()
        {
            var itemToRemove = items.Last();

            if (items.Remove(itemToRemove))
            {
                isDirty = true;
                Debug.Log($"Removed {itemToRemove.itemName}");
            }
        }

        /// <summary>
        /// 获取总重量
        /// </summary>
        public float TotalWeight
        {
            get
            {
                if (isDirty)
                {
                    RecalculateTotalWeight();
                    isDirty = false;
                }
                return cachedTotalWeight;
            }
        }

        private void RecalculateTotalWeight()
        {
            float total = 0f;
            foreach (var item in items)
            {
                total += item.weight;
            }
            cachedTotalWeight = total;
            Debug.Log($"Recalculated total weight: {total}");
        }
    }
}