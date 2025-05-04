using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    public int score = 1;
    private bool isCollected = false;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collison detected. Score collected:  " + isCollected);
        if (!isCollected && collision != null && collision.gameObject.CompareTag("Player"))
        {
            isCollected = true;
            FindFirstObjectByType<GameManagerScript>().score += score;
        }
    }
}
