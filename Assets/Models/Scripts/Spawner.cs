using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject pumpkin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3.5f));    // Wait for spawning pumpkins
        Instantiate(pumpkin, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity); // Instantiate at a random position
        StartCoroutine(StartSpawning()); // Call itself again - Infinite loop
    }
}
