using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private void Start() {
        InvokeRepeating("SpawnRandomAnimal", 5, 2);
    }

    private void Update()
    {
        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     SpawnRandomAnimal();
        // }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-15, 15), 0, 20), animalPrefabs[animalIndex].transform.rotation);
    }
}
