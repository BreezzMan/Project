using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotaton;
    float yRotaton;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //получение мыши
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotaton += mouseX;

        xRotaton -= mouseY;
        xRotaton = Mathf.Clamp(xRotaton, -90f, 90f);

        //поворот камеры
        transform.rotation = Quaternion.Euler(xRotaton, yRotaton, 0);
        orientation.rotation = Quaternion.Euler(0, yRotaton, 0);
    }

}
