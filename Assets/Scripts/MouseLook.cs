using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform player;
    float xRotate = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        if (!EndGame.end)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotate -= mouseY;
            xRotate = Mathf.Clamp(xRotate, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
            player.Rotate(Vector3.up * mouseX);
        }
    }
}
