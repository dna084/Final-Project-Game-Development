using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 vel){

        transform.position += vel * Time.deltaTime;
    
    }

    public void Jump(float jumpForce){
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}   
