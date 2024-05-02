using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float despawnTime;

    private Transform cam;
    private Vector3 forward;

    private void Start()
    {
        StartCoroutine(DespawnTimer(despawnTime));
        cam = GameObject.Find("Main Camera").transform;
        forward = cam.transform.forward;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(forward * speed * Time.deltaTime);
    }

    private IEnumerator DespawnTimer(float time)
    {
        yield return new WaitForSeconds(time);

        Destroy(gameObject);
    }
}
