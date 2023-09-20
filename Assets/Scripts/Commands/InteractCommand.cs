using UnityEngine;

public class InteractCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Interacted");
    }

    public void Undo()
    {
        Debug.Log("Uninteracted");
    }
}
