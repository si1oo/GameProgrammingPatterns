using UnityEngine;
/// <summary>
/// 测试类，模拟玩家行为
/// </summary>
public class Example06 : MonoBehaviour
{
    public StateMachine stateMachine = null;
    void Start()
    {
        stateMachine = new StateMachine(StateSet.StandState,this);
    }

    void Update()
    {
        stateMachine.Update();
    }
}
