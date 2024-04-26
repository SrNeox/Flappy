using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private Transform _firePoin;
    [SerializeField] private BulletPoolPlayer poolBulletPlayer;
    public void PlayerShoot()
    {
        GameObject bullet = poolBulletPlayer.GetFromPool();

        bullet.transform.position = _firePoin.position;
    }

    public void EnemyShoot()
    {
        GameObject bullet = BulletPoolEnemy.Pool.GetFromPool();

        bullet.transform.position = _firePoin.position;
    }
}
