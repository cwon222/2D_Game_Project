using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    Transform spawnPointOne;
    Transform spawnPointTwo;
    Transform spawnPointThree;

    public GameObject unitOne;
    public GameObject unitTwo;
    public GameObject unitThree;

    public float spawnDelay = 2.0f;


    private void Awake()
    {
        spawnPointOne = transform.GetChild(0);
        spawnPointTwo = transform.GetChild(1);
        spawnPointThree = transform.GetChild(2);
    }

    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    void Spawn()
    {
        float rand = Random.value;
        if(rand < 0.5f)
        {
            Instantiate(unitOne, spawnPointOne.position, spawnPointOne.rotation, transform);
        }
        else if(rand < 0.8f)
        {
            Instantiate(unitTwo, spawnPointTwo.position, spawnPointTwo.rotation, transform);
        }
        else
        {
            Instantiate(unitThree, spawnPointThree.position, spawnPointThree.rotation, transform);
        }
    }

    IEnumerator SpawnCoroutine()
    {
        while(true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
