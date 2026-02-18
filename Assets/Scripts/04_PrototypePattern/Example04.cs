using UnityEngine;
using _Example04;
/// <summary>
/// ≤‚ ‘¿‡
/// </summary>
public class Example04 : MonoBehaviour
{
    private Ghost ghost_prototype; //”ƒ¡È‘≠–Õ
    private Spawner spawner;
    void Start()
    {
        ghost_prototype = new Ghost(15,20);
        spawner = new Spawner(ghost_prototype);

        Monster ghost_1 = spawner.SpawnMonster();
    }
}
