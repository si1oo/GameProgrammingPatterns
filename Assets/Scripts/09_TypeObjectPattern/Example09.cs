using _Example09;
using UnityEngine;
public class Example09 : MonoBehaviour
{
    private Breed archerBreed = null;
    private Monster archer = null;
    private void Start()
    {
        archerBreed = new Breed("弓箭手", 20, "发射弓箭");
        archer = archerBreed.NewMonster();

        Debug.Log(archer.Attack());

        archer.TakeDamage(5);
    }
}