using UnityEngine;

public class SprintCommand : ICommand
{
    public void Execute()
    {
        Debug.Log("Sprint");
    }

    public void Undo()
    {
        Debug.Log("Moonwalk");
    }

}
