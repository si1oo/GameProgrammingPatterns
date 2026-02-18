using UnityEngine;
/// <summary>
/// 移动命令类，传入移动方向和距离
/// </summary>
public class MoveCommand : Command
{
    private float distance;
    private Vector3 direction;
    public MoveCommand(float distance,Vector3 direction)
    {
        this.distance = distance;
        this.direction = direction;
    }
    public override void Execute(GameAvator avator)
    {
        Vector3 targetPostion = distance * direction;
        avator.Move(targetPostion);
    }

    public override void Undo(GameAvator avator)
    {
        Vector3 targetPosition = distance * -direction;
        avator.Move(targetPosition);
    }
}
