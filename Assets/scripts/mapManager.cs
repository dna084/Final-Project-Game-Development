using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mapManager : MonoBehaviour
{
    public Button enemyButton;
    public Button eliteButton;
    public Button chestButton;
    public Button restButton;
    public Button homeButton;

    public void enemyButtonClick()
    {
            Debug.Log("Player chose enemy");
            //SceneManager.LoadScene("enemyScene");
    }

    // Method for handling the "No" button click
    public void eliteButtonClick(){
            Debug.Log("Player chose elite");
            //SceneManager.LoadScene("eliteScene");
    }

    public void chestButtonClick(){
            Debug.Log("Player chose chest");
            //SceneManager.LoadScene("chestScene");
    }

    public void restButtonClick(){
            Debug.Log("Player chose restButton");
            SceneManager.LoadScene("restScene");
    }

    public void homeButtonClick(){
            Debug.Log("Player chose restButton");
            SceneManager.LoadScene("SampleScene");
    }
}
