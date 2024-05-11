using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public bool phase2 = false;
    public int eyes = 4;
    public Transform body;
    public float speed;
    public int hp;

    private GameObject player;
    private bool notRotated = true;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        PhaseCheck();
        if(phase2)
        {
            RunPhaseTwo();
        }
    }

    public void RunPhaseTwo()
    {
        if(notRotated)
        {
            body.transform.Rotate(90, body.rotation.y, body.rotation.z);
            notRotated = false;
        }
        
        //body.SetLocalPositionAndRotation(body.position,  Quaternion.Euler(0f, body.rotation.y, body.rotation.z));
    }

    public void PhaseCheck()
    {
        if(eyes <= 0)
        {
            phase2 = true;
        }
    }
}
