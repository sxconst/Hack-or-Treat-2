using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpawnCandy : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject candy;
    public static int numberOfCandies = 0;
    public static bool spawnCandy;

    private void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("spawnpoint");
    }

    private void Start()
    {
        spawnCandy = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCandy)
        {
            PlaceCandy();
            spawnCandy = false;
        }
    }

    private void PlaceCandy()
    {
        while (numberOfCandies < 3)
        {
            int spawn = UnityEngine.Random.Range(0, spawnLocations.Length);
            GameObject a = Instantiate(candy) as GameObject;
            a.transform.position = new Vector3(spawnLocations[spawn].transform.position.x, spawnLocations[spawn].transform.position.y, spawnLocations[spawn].transform.position.z);
            RemoveElement(ref spawnLocations, spawn);
            numberOfCandies++;
        }
    }

    private void RemoveElement<spawnLocations>(ref spawnLocations[] arr, int index)
    {
        for (int i = index; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }

        Array.Resize(ref arr, arr.Length - 1);
    }
}
