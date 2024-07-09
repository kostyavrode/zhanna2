using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class CameraMover : MonoBehaviour
{
    public DesktopInput input;
    public Camera camera;
    public Transform heroTransform;

    private float xRotation;
    private float yRotation;

    //[Inject]
    //private void Construct(IInput iinput)
    //{
    //    Debug.Log(iinput.GetType());
    //    input = iinput;

    //}
    private void Update()
    {
        xRotation -= input.MouseY;
        yRotation += input.MouseX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        camera.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        if (heroTransform)
        {
            heroTransform.rotation = Quaternion.Euler(0, yRotation, 0);
            transform.position = heroTransform.position;
        }
    }
}
