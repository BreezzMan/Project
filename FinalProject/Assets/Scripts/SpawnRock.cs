using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnRock : MonoBehaviour
{
    public Transform spawn;
    public GameObject rockPrefab; // Reference to the rock prefab
    private bool isSpawning = false; // Flag to check if spawning is in progress

    public float spawnInterval = 2f; // Time interval between spawns

    private void Update() {
        if (!isSpawning) 
            return;
        // Check if the spawn interval has passed
        if (Time.time % spawnInterval < Time.deltaTime)
        {
            SpawnRockAtInterval();
        }
    }

    private void SpawnRockAtInterval()
    {
        Debug.Log("Spawn Rock");
        var rock = Instantiate(rockPrefab, spawn.position, spawn.rotation); // Spawn the rock at the specified position and rotation
        Destroy(rock, 5f); // Destroy the rock after 5 seconds to prevent memory leaks
    }

    void OnTriggerEnter(Collider other)
    {
        isSpawning = true; // Start spawning when the player enters the trigger
    }
}
