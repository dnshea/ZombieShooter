using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool levelOne;
    public GameObject Zombie;
    public GameObject Flying;
    public GameObject Range;
    public GameObject Bomber;
    public GameObject Boss;
    public GameObject Health;

    public Transform spawnOne;
    public Transform spawnTwo;
    public Transform spawnThree;
    public Transform spawnFour;
    public Transform spawnFive;
    public Transform spawnAir1;
    public Transform spawnAir2;
    public Transform spawnAir3;
    public Transform spawnAir4;
    public Transform spawnAir5;

    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
     if (levelOne)
        {
            WaveOne();
        }
     else
        {
            WaveFour();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
        enemyCount++;
    }
    private void SpawnEnemyAir(GameObject enemy)
    {
        Instantiate(enemy, transform.position, transform.rotation);
        enemyCount++;
    }

    private void WaveOne()
    {
        SpawnEnemy(Zombie);
    }
    private void WaveTwo()
    {

    }
    private void WaveThree()
    {

    }
    private void WaveFour()
    {

    }

}
