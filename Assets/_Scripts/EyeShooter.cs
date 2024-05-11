using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeShooter : MonoBehaviour
{
    public GameObject laserballPrefab;
    public GameObject ultimateProjectilePrefab;
    public float spawnRate;
    public int hp;
    public GameObject player;
    public Transform eye;
    public GameObject boss;
    public bool isUltimate;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLaserBall", 3, spawnRate);
    }
    private void SpawnLaserBall()
    {
        if(!isUltimate)
        {
            GameObject newLaser = Instantiate(laserballPrefab, eye.transform.position, eye.transform.rotation);
        }
        else if (gameObject.activeSelf)
        {
            GameObject newLaser = Instantiate(ultimateProjectilePrefab, eye.transform.position, eye.transform.rotation);
        }
    }
    private void Update()
    {
        if (hp <= 0)
        {
            player.GetComponent<PlayerController>().score += 100;
            boss.GetComponent<Boss>().eyes--;
            Destroy(this.gameObject);
        }
    }
}
