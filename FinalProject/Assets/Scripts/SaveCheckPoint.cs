using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveCheckPoint : MonoBehaviour
{
    private bool isSaved = false;
    public int index;

    private void OnTriggerEnter(Collider other)
    {
        if (!isSaved && other.CompareTag("Player"))
        {
            isSaved = true;
            FindFirstObjectByType<PlayerMovement>().SetCheckpoint(index);
        }
    }
}
