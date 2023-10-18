using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starSprite : MonoBehaviour
{
    public GameObject star;
    private Rigidbody2D rb;

    private void Awake(){
        star = gameObject;
        rb = star.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border Ground" || collision.tag == "Character")
        {
            Destroy(gameObject);
        }
    }

}
