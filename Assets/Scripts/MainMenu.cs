using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool colorblindMode = false;
    public Material trapMat;
    public Material goalMat;
    


    // Load the maze scene when the play button is pressed 
    public void PlayMaze()
    {
        if (colorblindMode)        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}