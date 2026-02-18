using UnityEngine;

public class StandState : State
{
    public StandState(Example06 player) : base(player)
    {
        //在这里初始化站立状态的一些参数
    }

    public override void Enter()
    {
        Debug.Log("Enter StandState");
    }

    public override void Exit()
    {
        Debug.Log("Exit StandState");
    }

    public override void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.stateMachine.ChangeState(StateSet.JumpState);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.stateMachine.ChangeState(StateSet.MoveState);
        }
    }
}
