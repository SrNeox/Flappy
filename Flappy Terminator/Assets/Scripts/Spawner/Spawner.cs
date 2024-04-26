using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _spawnDelay = 7;


    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        WaitForSeconds delay = new(5);

        while (true)
        {
            var enemy = EnemyPool.Pool.GetFromPool();

            enemy.transform.position = _spawnPoints[Random.RandomRange(0, _spawnPoints.Length)].position;

            yield return delay;
        }
    }
}
