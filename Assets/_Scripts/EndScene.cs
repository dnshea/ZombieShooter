using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Nilo Miranda
 * 5/10/24
 * Ends the scene and also switches scene
 */

public class EndScene : MonoBehaviour
{
    public void QuitGame()
    {
        print("Quit Game");
        Application.Quit();
    }

    public void SwitchScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}

