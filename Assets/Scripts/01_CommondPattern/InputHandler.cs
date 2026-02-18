using UnityEngine;

public class InputHandler
{
    public Command HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
            return new MoveCommand(2, Vector3.forward);

        if (Input.GetKeyDown(KeyCode.S))
            return new MoveCommand(2, Vector3.back);

        if (Input.GetKeyDown(KeyCode.A))
            return new MoveCommand(2, Vector3.left);

        if (Input.GetKeyDown(KeyCode.D))
            return new MoveCommand(2, Vector3.right);

        return null;
    }
}
