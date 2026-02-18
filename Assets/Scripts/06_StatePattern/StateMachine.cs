/// <summary>
/// 状态机，用于管理所有状态对象
/// </summary>
public class StateMachine
{
    private State currentState = null;

    #region States
    private StandState standState;
    private MoveState moveState;
    private JumpState jumpState;
    #endregion

    public StateMachine(StateSet initState, Example06 player)
    {
        #region 初始化状态对象
        standState = new StandState(player);
        moveState = new MoveState(player);
        jumpState = new JumpState(player);
        #endregion

        currentState = GetState(initState);

        currentState.Enter();
    }
    public void ChangeState(StateSet state)
    {
        currentState.Exit();
        currentState = GetState(state);
        currentState.Enter();
    }
    public void Update()
    {
        currentState.Update();
    }

    private State GetState(StateSet stateSet)
    {
        switch (stateSet)
        {
            case StateSet.StandState:
                return standState;
            case StateSet.MoveState:
                return moveState;
            case StateSet.JumpState:
                return jumpState;
            default:
                return null;
        }
    }
}

public enum StateSet
{
    StandState,
    MoveState,
    JumpState,
}
