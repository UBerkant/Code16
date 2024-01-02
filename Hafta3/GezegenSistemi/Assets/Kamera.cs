using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Vector2 turn;
    public float dpi = 2000f;
    public new Transform camera;
    public float speed = 50f;
    public float smoothness = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed *= 4;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 50f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }
        if (Input.GetMouseButton(1))
        {
            turn.x += Input.GetAxis("Mouse X") * dpi;
            turn.y += Input.GetAxis("Mouse Y") * dpi;

            transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
            /*Vector3 newPosition = new Vector3(-mouseY, mouseX, 0f) * dpi * Time.deltaTime;

            Vector3 targetRotation = camera.eulerAngles + newPosition;
            camera.eulerAngles = Vector3.Lerp(camera.eulerAngles, targetRotation, smoothness);*/

        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
