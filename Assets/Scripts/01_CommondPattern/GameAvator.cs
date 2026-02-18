using UnityEngine;

/// <summary>
/// 角色行为逻辑，被具体的命令调用
/// </summary>
public class GameAvator : MonoBehaviour
{
    public void Move(Vector3 delta) => transform.Translate(delta);
}
