using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;

    private IGhostFactory demonFactory = new DemonFactory();

    private void Awake()
    {
        inputHandler = new InputHandler();
    }

    void Start()
    {
        inputHandler.OnStart();

        Ghost ghost = demonFactory.CreateGhost();
        ghost.Haunt();
    }

    void Update()
    {
        inputHandler.OnUpdate();
    }
}
