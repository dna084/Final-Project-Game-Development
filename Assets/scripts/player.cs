using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Movement movement;
    public GameObject character;
    public float jumpForce = 5.0f;
    private bool isJumping = false;

    public int hp = 10;
    public int hpTotal = 10;
    public int curHpLost = 0;
    public int hpLost = 0;
    public int attack = 1;
    public int defense = 1;
    public int speed = 1;

    private void Start(){
        movement = GetComponent<Movement>();
    }

    private void Update(){
        if (Input.GetKeyDown(KeyCode.W)&& !isJumping){
            Jump();
        }

        if (curHpLost != 0){
            hpLost += curHpLost;
            curHpLost = 0;
        }
        else if (hp < hpLost || hp < curHpLost){
            Debug.Log("Death");
        }

    }

    private void Jump(){
        isJumping = true;
        movement.Jump(jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Border Ground")){
            isJumping = false;
        }
    }

    private void Damage(){
        hp = hp-hpLost;
    }
    
}
