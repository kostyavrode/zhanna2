using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopInput : MonoBehaviour,IInput
{
    public float sens;

    public float mouseX;
    public float mouseY;

    public float horizontal;
    public float vertical;

    //private float xRotation;
    //private float yRotation;

    public float MouseX { get { return mouseX; } set { mouseX = value; } }
    public float MouseY { get { return mouseY; } set { mouseY = value; } }
    public float Horizontal { get { return horizontal; } set { horizontal = value; } }
    public float Vertical { get { return vertical; } set { vertical = value; } }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sens;
        mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sens;

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        //yRotation += mouseX;
        //xRotation -= mouseY;
        //yRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //camera.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        //orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
