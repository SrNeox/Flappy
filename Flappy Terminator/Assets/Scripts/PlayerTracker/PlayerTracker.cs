using UnityEngine;

public class PlayerTracker : MonoBehaviour
{
    [SerializeField] private PlayerMover _player;
    [SerializeField] private float _offSetX;

    private Vector2 _position;

    private void Start()
    {
        _position = transform.position;
    }

    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        _position.x = _player.transform.position.x + _offSetX;
        transform.position = _position;
    }
}
