using UnityEngine;

public class GameManager : MonoBehaviour
{
    private InputHandler inputHandler;
    private GhostCreator creator;

    public Ghost ghost { get; private set; }
    public GhostType ghostType { get; private set; }

    private void Awake()
    {
        inputHandler = new InputHandler();
        creator = new GhostCreator();
    }

    private void Start()
    {
        inputHandler.OnStart();
    }

    private void Update()
    {
        inputHandler.OnUpdate();
    }

    public void CreateNewGhost(GhostType _ghostType)
    {
        ghost = creator.OrderGhost(_ghostType);
        ghostType = _ghostType;
    }

    public void MakeGhostInteract()
    {
        ghost?.Haunt();
    }
}
