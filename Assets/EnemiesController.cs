using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemyPrefab;
    public float respawnTime;

    public bool canSpwan;
    void Start()
    {
        canSpwan = true;
    }
    void Update()
    {
        if(canSpwan)
        {
            StartCoroutine(Spawn());
        }
        
    }
    IEnumerator Spawn()
    {
        canSpwan = false;
        for (int i = 0; i < 5; i++)
        {
            Instantiate(enemyPrefab, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);
        }
        yield return new WaitForSeconds(respawnTime);
        canSpwan = true;
    }
}
