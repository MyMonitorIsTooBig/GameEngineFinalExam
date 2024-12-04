using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : Singleton<ObjectPool>
{
    [SerializeField]
    private List<GameObject> poolObjects;
    [SerializeField]
    private Queue<GameObject> pool;
    [SerializeField] private int size;
    [SerializeField] private Controller _player;
    // Start is called before the first frame update
    void Start()
    {
        pool = new Queue<GameObject>();
        for(int i = 0; i < size; i++)
        {
            int r = Random.Range(0, poolObjects.Count);
            GameObject obj = Instantiate(poolObjects[r]);
            pool.Enqueue(obj);
            obj.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            pullFromPool();
        }
    }

    public void pullFromPool()
    {
        GameObject obj = pool.Dequeue();
        obj.SetActive(true);
        _player.currentPiece = obj;
    }

    public void returnToPool(GameObject obj)
    {
        pool.Enqueue(obj);
        obj.SetActive(false);
    }
}
