public abstract class Command
{
    public abstract void Execute(GameAvator avator);
    public abstract void Undo(GameAvator avator);
}
