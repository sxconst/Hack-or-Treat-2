using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PickUpCandy : MonoBehaviour
{
    public GameObject[] candies;
    public Vector3 playerPosition;
    public float pickUpRange;
    public static int candiesCollected;

    private void Awake()
    {
        candies = GameObject.FindGameObjectsWithTag("candy");

    }

    private void Update()
    {
        playerPosition = GameObject.FindGameObjectWithTag("player").transform.position;
        Vector3 distanceToPlayer = playerPosition - transform.position ;
        if (distanceToPlayer.magnitude < pickUpRange && Input.GetKeyDown(KeyCode.E)) PickUp();
    }

    private void PickUp()
    {
        Destroy(this.gameObject);
        candiesCollected++;
    }
}
