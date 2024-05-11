using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortar : MonoBehaviour
{
    public GameObject laserballPrefab;
    public float spawnRate;
    public int hp;
    public GameObject player;
    public Transform mortarBase;
    private GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnLaserBall", 1, spawnRate);
        //spawner = FindObjectOfType<Spawner>().gameObject;

    }
    private void SpawnLaserBall()
    {
        GameObject newLaser = Instantiate(laserballPrefab, mortarBase.transform.position, mortarBase.transform.rotation);
    }
    private void Update()
    {
        if (hp <= 0)
        {
            player.GetComponent<PlayerController>().score += 100;
            spawner.GetComponent<Spawner>().enemyCount--;
            Destroy(this.gameObject);
        }
    }
}
