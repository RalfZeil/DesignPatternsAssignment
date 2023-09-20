using System.Collections.Generic;

public class CommandInvoker
{
    private Stack<ICommand> executedCommands;

    public CommandInvoker()
    {
        executedCommands = new Stack<ICommand>();
    }

    public void InvokeCommand(ICommand command)
    {
        command.Execute();
        executedCommands.Push(command);
    }

    public void UndoCommand()
    {
        if(executedCommands.Count > 0) { executedCommands.Pop().Undo(); }  
    }
}
