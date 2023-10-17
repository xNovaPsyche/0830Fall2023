using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); //scene to load
        Debug.Log("New Scene Loaded!");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game!");
    }
}
