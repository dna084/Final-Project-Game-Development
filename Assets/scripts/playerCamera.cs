using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamera : MonoBehaviour
{
    public Transform player;
    public float followThreshold = 18.0f;
    public float position1 = 9.0f;
    public float position2 = 54.0f;
    private bool isFollowingPlayer = false;

    // Update is called once per frame
    void Update()
    {
        float playerX = player.position.x;

        if (playerX < 9.0f){
            // Follow the player along the X-axis
            
            transform.position = new Vector3(0.0f, 0.0f, transform.position.z);
            isFollowingPlayer = false;
        }
        else if(playerX >= position1 && playerX < followThreshold){
            transform.position = new Vector3(followThreshold, 0.0f, transform.position.z);
            isFollowingPlayer = false;
        }
        else if(playerX >= position1 && playerX < position2){
            Vector3 targetPosition = new Vector3(playerX, transform.position.y, transform.position.z);
            transform.position = targetPosition;
            isFollowingPlayer = true;
        }
        else{
            isFollowingPlayer = false;
        }
    }
}
