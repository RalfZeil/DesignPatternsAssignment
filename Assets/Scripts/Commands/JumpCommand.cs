using UnityEngine;

public class JumpCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Jumped");
    }

    public void Undo()
    {
        Debug.Log("Unjumped");
    }
}
