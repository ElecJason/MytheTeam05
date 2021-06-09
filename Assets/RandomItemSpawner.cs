using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemSpawner : MonoBehaviour
{

    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject key;
    void Start()
    {
        int index = Random.Range(0, spawnPoints.Length);
        Debug.LogWarning(index);
        GameObject clone = Instantiate(key, spawnPoints[index].transform.position, transform.rotation);
        //Debug.LogError("key spawned");
    }

}