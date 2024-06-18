using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Public Method to Start the Game
    public void StartGame() {
        // Switch Scenes
        SceneManager.LoadScene("SampleScene");

        // User Feedback
        Debug.Log("Started Game!");
    }

    // Public Method to Quit the Game
    public void QuitButton() {
        // Quit Game
        Application.Quit();

        // User Feedback
        Debug.Log("Exited Game!");
    }
}