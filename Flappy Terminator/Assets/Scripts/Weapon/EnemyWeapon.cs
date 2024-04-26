using System.Collections;
using UnityEngine;

public class EnemyWeapon : Weapon
{
    [SerializeField] private int _delayShoot = 5;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        StartCoroutine(ShootDelay());
    }

    private IEnumerator ShootDelay()
    {
        WaitForSeconds delay = new(_delayShoot);

        while (true)
        {
            EnemyShoot();

            yield return delay;
        }
    }
}
