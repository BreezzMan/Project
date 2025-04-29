using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGameOnTouch: MonoBehaviour
{
    // ���������� ���� ������ � �������, ������� ������ ������������� ���� ��� ������� 

    void OnTriggerEnter(Collider other)
    {
        // ���������, �������� �� ����� ������� � ���� �������� 
        if (other.CompareTag("Player"))
        {
            // ������������� ���� 
            RestartGame();
        }
    }

    void RestartGame()
    {
        // ����� ����� �������� ����� ������, ������� ������ ���� ��������� ����� ������������ ���� 
        // ��������, �������� ��������, �������� ������� ������ � �. �. 

        // ������������� ����� 
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
