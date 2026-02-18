using System.Collections.Generic;
using UnityEngine;
public class CommandManager : MonoBehaviour
{
    private InputHandler inputHandler = null;
    private Stack<Command> commandsStack = new Stack<Command>();
    private GameAvator avator = null;

    private void Start()
    {
        inputHandler = new InputHandler();
        avator = GetComponent<GameAvator>();
    }

    /// <summary>
    /// ≤‚ ‘
    /// </summary>
    private void Update()
    {
        ApplyInput();
    }

    private void ApplyInput()
    {
        Command command = inputHandler.HandleInput();
        if (command != null)
        {
            commandsStack.Push(command);
            command.Execute(avator);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            if (commandsStack.Count > 0)
                commandsStack.Pop().Undo(avator);
        }
    }
}
