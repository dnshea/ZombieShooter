using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateProjectile : MonoBehaviour
{
    public float speed;
    public float upTime = 2f;

    private bool follow = false;
    private Transform player;
    private Transform boss;
    private bool reflected = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Uptime(upTime));
        player = FindObjectOfType<PlayerController>().transform;
        boss = FindObjectOfType<Boss>().body;
    }

    // Update is called once per frame
    void Update()
    {
        if (follow && !reflected)
        {
            transform.LookAt(player.transform.position);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else if(reflected)
        {
            transform.LookAt(boss.GetComponent<Boss>().body.transform.position);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

    }
    private IEnumerator Uptime(float time)
    {
        yield return new WaitForSeconds(time);
        follow = true;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("COLLIDING!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        if(collision.gameObject.tag == "Cover")
        {
            reflected = true;
            Destroy(collision.gameObject);
        }
    }

}
