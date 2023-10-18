using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gia : MonoBehaviour
{
    public GameObject giaCharacter;

    public int hp = 999;
    public int attack = 1;
    public int defense = 1;
    public int speed = 1;

    private void Start(){
        
    }

    private void Update(){

    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("Player"))
        {
            DialogueTrigger dialogueTrigger = GetComponent<DialogueTrigger>();
            if (dialogueTrigger != null)
            {
                dialogueTrigger.enabled = true;
            }
        }
    }
    
}