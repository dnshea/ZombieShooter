using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBall : MonoBehaviour
{
    public int speed = 10;
    public float upTime = 3f;
    private bool follow = false;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Uptime(upTime));
        player = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (follow)
        {
            transform.LookAt(player.transform.position);
            transform.position += transform.forward * speed * Time.deltaTime;
        } else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        
    }
    private IEnumerator Uptime(float time)
    {
        yield return new WaitForSeconds(time);
        follow = true;
    }
    
}
