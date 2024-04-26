using UnityEngine;

public class BulletPoolEnemy : PoolObject
{
    [SerializeField] private Bullet _bullet;

    public static BulletPoolEnemy Pool;

    private void Awake()
    {
        Pool = this;
        Prefab = _bullet.gameObject;
    }
}
