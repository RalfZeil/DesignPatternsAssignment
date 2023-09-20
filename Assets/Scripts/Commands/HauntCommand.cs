using UnityEngine;

public class HauntCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Haunted");
    }

    public void Undo()
    {
        Debug.Log("Blessed");
    }
}