using _Example12;
using UnityEngine;
public class Example12 : MonoBehaviour
{
    private Inventory inventory;
    private void Start()
    {
        inventory = new Inventory();
    }

    private void OnGUI()
    {
        GUILayout.Label($"Inventory - Total Weight: {inventory.TotalWeight:F2}");

        if (GUILayout.Button("Add Random Item (1-5 weight)"))
        {
            Item randItem = new Item
            {
                itemName = "RandomItem",
                weight = Random.Range(1f, 5f)
            };
            inventory.AddItem(randItem);
        }

        if (GUILayout.Button("Remove Last Item") && inventory.inventoryCount > 0)
        {
            inventory.RemoveLastItem();
        }

        GUILayout.Label($"Item Count: {inventory.inventoryCount}");
    }
}

