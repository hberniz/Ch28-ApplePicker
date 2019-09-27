﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AppleTree : MonoBehaviour
{
    // Prefab for instantiating apples
    public GameObject applePrefab;
    // Speed at which the AppleTree moves in meters/second
    public float speed = 1f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;
    // Chance that the AppleTree will change directions
    public float chanceToChangeDirections = 0.1f;
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrops = 1f;
    void Start()
    {
        // Dropping apples every second
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrops);
    }
    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }

void Update()
    {
        // Basic Movement
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        //pos.x += 1.0f * 0.04f;
        //pos.x += 0.04f;
        transform.position = pos;
        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }
        


    }
    void FixedUpdate()
    {
        // Changing Direction Randomly
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1; // Change direction
        }
    }

}
