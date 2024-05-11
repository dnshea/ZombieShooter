using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Nilo Miranda
 * 5/10/24
 * Makes an overlay of a controlmenu that can be accessed in game while puasing the game
 */

public class ControlMenu : MonoBehaviour
{
    public GameObject controlMenu;
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        controlMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        controlMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        controlMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
