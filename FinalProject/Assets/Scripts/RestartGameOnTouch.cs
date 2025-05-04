using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameOnTouch: MonoBehaviour
{

    public GameManagerScript gm;
    [SerializeField] private PlayerMovement player;    
    


    private void Start()
    {
        gm = FindFirstObjectByType<GameManagerScript>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            RespawnPlayer();
        }
    }


    void RespawnPlayer()
    {
        gm.lives -= 1;
        player.respawn();
    }
}
