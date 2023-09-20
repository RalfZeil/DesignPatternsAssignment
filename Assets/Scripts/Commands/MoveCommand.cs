using UnityEngine;

public class MoveCommand : ICommand
{
    private GameObject gameObject;
    private Vector3 direction;
    private float speed;

    public MoveCommand(GameObject _gameObject, Vector3 _direction, float _speed)
    {
        gameObject = _gameObject;
        direction = _direction;
        speed = _speed;
    }

    public void Execute()
    {
        gameObject.transform.Translate(direction * speed * Time.deltaTime);
    }

    public void Undo()
    {
        gameObject.transform.Translate(-direction * speed * Time.deltaTime);
    }
}
