using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    float currentTime = 0.0f;
    float timeUntilNextSpawn = 5.0f;
    bool canSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime == 0.0f)
        {
            ObjectPool.Instance.pullFromPool();
            canSpawn = false;
        }
        if (!canSpawn)
        {
            if(currentTime <= timeUntilNextSpawn)
            {
                currentTime += Time.deltaTime;
            }
            else
            {
                currentTime = 0.0f;
                canSpawn = true;
            }
        }
    }
}
