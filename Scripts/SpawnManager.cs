using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawnpoint1;
    public GameObject spawnpoint2;
    public GameObject spawnpoint3;
    public GameObject prefab;
    private GameObject randomspawnpoint;
    private int number;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RandomSpawnPoint", 2f, 4f);
    }
    public void RandomSpawnPoint()
    { // spawn obstacles randomly
        number = Random.Range(1, 4);
        if(number == 1)
        {
            randomspawnpoint = spawnpoint1;
        }

        if (number == 2)
        {
            randomspawnpoint = spawnpoint2;
        }

        if (number == 3)
        {
            randomspawnpoint = spawnpoint3;
        }

        Instantiate(prefab, randomspawnpoint.transform.position, Quaternion.identity);

    }

}
