using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleGenerator : MonoBehaviour
{
    public GameObject hurdle;
    Vector3 positionToSpawn = Vector3.zero;

    private void Start()
    {
        for(int i = 0;i < 5;i++)
        {
            spawnHurdle();
        }
    }

    public void spawnHurdle()
    {
        Instantiate(hurdle, positionToSpawn, Quaternion.identity);
        positionToSpawn.Set(0, positionToSpawn.y + 3, 0);
    }
    
}
