using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Button yesButton;
    public Button noButton;
    public float transitionTime = 0.5f;
    private bool isDialogueActive = false;

    private void Start()
    {
        EndDialogue();
    }

    public void StartDialogue()
    {
        isDialogueActive = true;
        yesButton.onClick.AddListener(OnYesButtonClick);
        noButton.onClick.AddListener(OnNoButtonClick);

        // Show the UI components
        dialogueText.gameObject.SetActive(true);
        yesButton.gameObject.SetActive(true);
        noButton.gameObject.SetActive(true);
    }

    public void EndDialogue()
    {
        isDialogueActive = false;

        // Hide the UI components
        dialogueText.gameObject.SetActive(false);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
    }

    // Method for handling the "Yes" button click
    public void OnYesButtonClick()
    {
        if (isDialogueActive)
        {
            Debug.Log("Player chose Yes");
            // Handle the "Yes" choice here
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
        }
    }

    // Method for handling the "No" button click
    public void OnNoButtonClick(){
        if (isDialogueActive)
        {
            Debug.Log("Player chose No");
            // Handle the "No" choice here
            EndDialogue(); // Close the dialogue
        }
    }

    IEnumerator LoadLevel(int levelIndex){
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
