using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
 * Nilo Miranda
 * 5/2/24
 * Focuses on UI manager and everything related towards it.
 */

public class UIManager : MonoBehaviour
{

    public PlayerController PlayerController;
   public TMP_Text Score;


    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + PlayerController.score;
    }
}
