using UnityEngine;
/// <summary>
/// 测试类
/// </summary>
public class Example03 : MonoBehaviour
{
    MyPhysicsSystem physicsSystem = null;
    AchievementSystem achievementSystem = null;
    private void Start()
    {
        physicsSystem = new MyPhysicsSystem();
        achievementSystem = new AchievementSystem();

        physicsSystem.entityFall.AddObserver(achievementSystem);
    }

    private void Update()
    {
        //手动执行玩家衰落逻辑
        if (Input.GetKeyDown(KeyCode.Space))
        {
            physicsSystem.FallLogic();
        }
    }
}
public class MyPhysicsSystem
{
    public Subject entityFall = new Subject();

    public void FallLogic()
    {
        //进行一些复杂数学计算...
        entityFall.Notify("FALL");
    }
}

public class AchievementSystem : IObserver
{
    public void OnNotify(string entityEvent)
    {
        if (entityEvent.Equals("FALL"))
        {
            UnlockAchievement();
        }
    }

    private void UnlockAchievement()
    {
        //doSometing...
        Debug.Log("解锁xxx成就！");
    }
}
