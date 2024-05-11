using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimateProjectile : MonoBehaviour
{
    public float speed;
    public float upTime = 2f;
    public int damage;

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
            transform.LookAt(boss.position);
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
        if(collision.gameObject.tag == "Cover")
        {
            reflected = true;
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.GetComponent<Boss>())
        {
            collision.gameObject.GetComponent<Boss>().hp -= damage;
            Destroy(gameObject);
        }
        else if (collision.gameObject.GetComponentInParent<Boss>() && collision.gameObject.tag != "Eye")
        {
            collision.gameObject.GetComponentInParent<Boss>().hp -= damage;
            Destroy(gameObject);
        }
    }

}
