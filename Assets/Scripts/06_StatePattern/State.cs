public abstract class State
{
    /// <summary>
    /// 这里使用Example06表示玩家类
    /// </summary>
    protected Example06 player;
    public State(Example06 player)
    {
        this.player = player; 
    }
    public abstract void Update();
    public abstract void Enter();
    public abstract void Exit();
}
