using UnityEngine;

public class BulletCatcher : MonoBehaviour
{
    [SerializeField] private BulletPoolPlayer _bulletPool;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.TryGetComponent(out Bullet bullet))
        {
            _bulletPool.ReturnInPool(bullet.gameObject);
        }
    }
}
