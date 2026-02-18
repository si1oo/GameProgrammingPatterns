using UnityEngine;

public class MoveState : State
{
    public MoveState(Example06 player) : base(player)
    {
    }

    public override void Enter()
    {
        Debug.Log("Enter MoveState");
    }

    public override void Exit()
    {
        Debug.Log("Exit MoveState");
    }

    public override void Update()
    {
        //通过player对象实现位移逻辑

        if (Input.GetKeyUp(KeyCode.W))
        {
            player.stateMachine.ChangeState(StateSet.StandState);
        }
    }
}
