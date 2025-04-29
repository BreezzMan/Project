using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGameOnTouch: MonoBehaviour
{
    // Прикрепите этот скрипт к объекту, который должен перезапускать игру при касании 

    void OnTriggerEnter(Collider other)
    {
        // Проверяем, коснулся ли игрок объекта с этим скриптом 
        if (other.CompareTag("Player"))
        {
            // Перезапускаем игру 
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Здесь можно добавить любую логику, которая должна быть выполнена перед перезапуском игры 
        // Например, сбросить счетчики, сбросить позицию игрока и т. д. 

        // Перезапускаем сцену 
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
