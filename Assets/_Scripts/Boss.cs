using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public bool phase2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(phase2)
        {
            RunPhaseTwo();
        }
    }

    public void RunPhaseTwo()
    {

    }
}
