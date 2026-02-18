using UnityEngine;

public class JumpState : State
{
    /// <summary>
    /// 这里为了方便，使用一个计时器模拟下落
    /// 一般实际项目中可以使用射线检测检测落地
    /// </summary>
    private float timer;

    public JumpState(Example06 player) : base(player)
    {
    }

    public override void Enter()
    {
        Debug.Log("Enter JumpState");
        timer = 2.0f;
    }

    public override void Exit()
    {
        Debug.Log("Exit JumpState");
    }

    public override void Update()
    {
        timer-= Time.deltaTime;
        if(timer <= 0)
        {
            player.stateMachine.ChangeState(StateSet.StandState);
        }
    }
}
