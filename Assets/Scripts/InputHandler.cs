using System.Collections.Generic;
using UnityEngine;

public class InputHandler
{
    private CommandInvoker commandInvoker;

    private Dictionary<KeyCode, ICommand> commandMap = new();

    public void OnStart()
    {
        commandInvoker = new CommandInvoker();

        commandMap[KeyCode.Space] = new JumpCommand();
        commandMap[KeyCode.E] = new InteractCommand();
    }

    public void OnUpdate()
    {
        foreach(var key in commandMap)
        {
            if (Input.GetKeyDown(key.Key))
            {
                Debug.Log("Invoked " + key);
                commandInvoker.InvokeCommand(key.Value);
            }
        }
    }
}
