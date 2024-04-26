using UnityEngine;

public class EnemyPool : PoolObject
{
    [SerializeField] private EnemyWeapon _enemy;

    public static EnemyPool Pool;

    private void Awake()
    {
        Pool = this;
        Prefab = _enemy.gameObject;
    }
}
