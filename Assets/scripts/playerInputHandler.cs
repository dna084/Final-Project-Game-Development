using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputHandler : MonoBehaviour
{
    private Movement movement;
    public float moveSpeed = 2.0f;

    private void Start(){
        movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 vel = Vector3.zero;
        if(Input.GetKey(KeyCode.A)){
            vel.x = (-1)*(moveSpeed);
        }
        else if(Input.GetKey(KeyCode.D)){
            vel.x = moveSpeed;
        }
        movement.Move(vel);

    }

}
