using UnityEngine;

public class TestGUI : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 140, 200), "Debug Menu");

        GUI.Label(new Rect(40, 30, 100, 20), "Create Ghost");

        //Ghost creation buttons
        if (GUI.Button(new Rect(20, 50, 120, 20), "Create Spirit"))
        {
            gameManager.CreateNewGhost(GhostType.spirit);
        }

        if (GUI.Button(new Rect(20, 70, 120, 20), "Create Poltergeist"))
        {
            gameManager.CreateNewGhost(GhostType.poltergeist);
        }

        if (GUI.Button(new Rect(20, 90, 120, 20), "Create banshee"))
        {
            gameManager.CreateNewGhost(GhostType.banshee);
        }

        if (GUI.Button(new Rect(20, 110, 120, 20), "Create demon"))
        {
            gameManager.CreateNewGhost(GhostType.demon);
        }

        if (GUI.Button(new Rect(20, 130, 120, 20), "Create shade"))
        {
            gameManager.CreateNewGhost(GhostType.shade);
        }


        //Current ghost and haunt menu
        GUI.Box(new Rect(Screen.width - 200, 0, 200, 80), "Current Ghost: " + gameManager.ghostType);

        if (GUI.Button(new Rect(Screen.width - 150, 30, 100, 50), "Haunt"))
        {
            gameManager.MakeGhostInteract();
        }
    }
}
