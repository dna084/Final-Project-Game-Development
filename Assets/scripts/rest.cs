using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rest : MonoBehaviour
{   

    public Button healButton; // Reference to the UI Heal button
    public Button homeButton;

    public void healButtonOnClick()
    {
        // Calculate 45% of hpLost
        player playerScript = GetComponent<player>();
        if (playerScript != null){
            Debug.Log("player script not null");
        }
        else{
            Debug.Log("player script IS null");
        }
        int healingAmount = (int)(playerScript.hpTotal*0.45f);

        // Subtract the healingAmount from the player's hp
        playerScript.hpLost -= healingAmount;
        if(playerScript.hpLost < 0){
            playerScript.hpLost = 0;
        }
        Debug.Log("Healed for: " + healingAmount + "Lost Hp Amount Now: " + playerScript.hpLost);
        SceneManager.LoadScene("MapScene");
    }

    public void homeButtonClick(){
        SceneManager.LoadScene("SampleScene");
    }
}
