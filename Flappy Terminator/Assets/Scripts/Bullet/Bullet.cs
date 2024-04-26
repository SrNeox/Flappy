using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed = 5;

    private void FixedUpdate()
    {
        _rigidbody2D.velocity = transform.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out PlayerMover player))
        {
            Time.timeScale = 0;
        }

        if (collider.GetComponent<Enemy>())
        {
            EnemyPool.Pool.ReturnInPool(collider.gameObject);
        }
    }
}
