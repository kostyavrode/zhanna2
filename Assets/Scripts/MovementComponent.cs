using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MovementComponent : MonoBehaviour
{
    public DesktopInput input;
    public Rigidbody rb;

    public float speed=10;
    //[Inject]
    //private void Construct(IInput iinput)
    //{
    //    Debug.Log(iinput.GetType());
    //    input = iinput;
        
    //}
    private void Update()
    {
        Vector3 moveVector = transform.right * input.Horizontal + transform.forward * input.Vertical;
        rb.Move(transform.position+(moveVector*speed*Time.deltaTime),transform.rotation);
    }
}
