using UnityEngine;

public class BulletPoolPlayer : PoolObject
{
    [SerializeField] private Bullet _bullet;

    private void Awake()
    {
        Prefab = _bullet.gameObject;
    }
}
