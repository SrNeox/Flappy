using UnityEngine;

public class EnemyCatcher : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.TryGetComponent(out Enemy _))
        {
            EnemyPool.Pool.ReturnInPool(collider.gameObject);
        }
    }
}

