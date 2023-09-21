using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public IState currentState;

    public void OnStart()
    {

    }

    public void OnUpdate()
    {
        currentState.OnUpdate();
    }
}
