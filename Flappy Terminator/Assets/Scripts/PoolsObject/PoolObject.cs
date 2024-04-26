using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    [SerializeField] private int _countPreload;

    protected GameObject Prefab;

    private Queue<GameObject> _items = new();

    private void Start()
    {
        for (int i = 0; i < _countPreload; i++)
        {
            _items.Enqueue(CreateItem());
        }
    }

    public GameObject GetFromPool()
    {
        if(_items.Count == 0)
        {
            _items.Enqueue(CreateItem());
        }

        GameObject item = _items.Dequeue();

        item.SetActive(true);

        return item;
    }

    public void ReturnInPool(GameObject item)
    {
        item.SetActive(false);
        _items.Enqueue(item);
    }

    private GameObject CreateItem()
    {
        GameObject bullet = Instantiate(Prefab);
        bullet.SetActive(false);

        return bullet;
    }
}
