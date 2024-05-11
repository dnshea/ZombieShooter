using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Flying;
    public GameObject Mortar;
    public GameObject Bomber;
    public GameObject Boss;
    public GameObject Health;

    //Level One Spawn Points
    public Transform spawnOne;
    public Transform spawnTwo;
    public Transform spawnThree;
    public Transform spawnFour;
    public Transform spawnFive;
    public Transform spawnAir11;
    public Transform spawnAir12;
    public Transform spawnAir13;
    public Transform spawnAir14;
    public Transform spawnAir15;
    public Transform healthSpawn1;
    //Level Two Spawn Points
    public Transform spawnOne2;
    public Transform spawnTwo2;
    public Transform spawnThree2;
    public Transform spawnFour2;
    public Transform spawnFive2;
    public Transform spawnAir21;
    public Transform spawnAir22;
    public Transform spawnAir23;
    public Transform spawnAir24;
    public Transform spawnAir25;
    public Transform healthSpawn2;

    public Transform bossSpawn;

    public int enemyCount;

    private int waveNum = 1;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        WaveOne();
    }
    private void SpawnEnemy(GameObject enemy, Transform spawnPoint)
    {
        Instantiate(enemy, transform.position, transform.rotation);
        enemyCount++;
    }

    private void WaveOne()
    {
        if(waveNum == 1)
        {
            StartCoroutine(spawnEnemies(3, Zombie, spawnOne, 3));
            StartCoroutine(spawnEnemies(4, Zombie, spawnTwo, 1));
            StartCoroutine(spawnEnemies(5, Zombie, spawnThree, 1));
            StartCoroutine(spawnEnemies(7, Mortar, spawnFour, 1));
            StartCoroutine(spawnEnemies(6, Flying, spawnAir11, 2));
            StartCoroutine(spawnEnemies(6, Flying, spawnAir12, 2));
            StartCoroutine(spawnEnemies(5, Health, healthSpawn1, 2));
            waveNum++;
        }
        else if(waveNum == 2 && enemyCount == 0)
        {
            WaveTwo();
        }

    }
    private void WaveTwo()
    {
        if (waveNum == 2)
        {
            StartCoroutine(spawnEnemies(3, Zombie, spawnOne, 5));
            StartCoroutine(spawnEnemies(4, Zombie, spawnTwo, 3));
            StartCoroutine(spawnEnemies(5, Zombie, spawnThree, 3));
            StartCoroutine(spawnEnemies(10, Mortar, spawnFour, 2));
            StartCoroutine(spawnEnemies(6, Flying, spawnAir11, 3));
            StartCoroutine(spawnEnemies(6, Flying, spawnAir12, 3));
            StartCoroutine(spawnEnemies(10, Mortar, spawnFive, 3));
            StartCoroutine(spawnEnemies(20, Flying, spawnAir13, 1));
            StartCoroutine(spawnEnemies(20, Flying, spawnAir14, 1));
            StartCoroutine(spawnEnemies(20, Flying, spawnAir15, 1));
            StartCoroutine(spawnEnemies(7, Health, healthSpawn1, 4));
            waveNum++;
        }
        else if (waveNum == 3 && enemyCount == 0)
        {
            WaveThree();
        }
    }
    private void WaveThree()
    {
        if (waveNum == 3)
        {
            StartCoroutine(spawnEnemies(3, Zombie, spawnOne2, 6));
            StartCoroutine(spawnEnemies(4, Bomber, spawnTwo2, 2));
            StartCoroutine(spawnEnemies(4, Bomber, spawnThree2, 3));
            StartCoroutine(spawnEnemies(10, Mortar, spawnFour2, 3));
            StartCoroutine(spawnEnemies(5, Flying, spawnAir21, 2));
            StartCoroutine(spawnEnemies(6, Flying, spawnAir22, 3));
            StartCoroutine(spawnEnemies(10, Bomber, spawnFive2, 2));
            StartCoroutine(spawnEnemies(15, Flying, spawnAir23, 2));
            StartCoroutine(spawnEnemies(15, Flying, spawnAir24, 2));
            StartCoroutine(spawnEnemies(20, Flying, spawnAir25, 1));
            StartCoroutine(spawnEnemies(7, Health, healthSpawn1, 4));
            waveNum++;
        }
        else if (waveNum == 4 && enemyCount == 0)
        {
            WaveFour();
        }
    }
    private void WaveFour()
    {
        if (waveNum == 1)
        {
            StartCoroutine(spawnEnemies(3, Zombie, spawnOne2, 8));
            StartCoroutine(spawnEnemies(4, Bomber, spawnTwo2, 4));
            StartCoroutine(spawnEnemies(4, Bomber, spawnThree2, 4));
            StartCoroutine(spawnEnemies(10, Mortar, spawnFour2, 4));
            StartCoroutine(spawnEnemies(5, Flying, spawnAir21, 5));
            StartCoroutine(spawnEnemies(6, Flying, spawnAir22, 3));
            StartCoroutine(spawnEnemies(10, Bomber, spawnFive2, 4));
            StartCoroutine(spawnEnemies(15, Flying, spawnAir23, 2));
            StartCoroutine(spawnEnemies(10, Flying, spawnAir24, 4));
            StartCoroutine(spawnEnemies(10, Flying, spawnAir25, 4));
            StartCoroutine(spawnEnemies(7, Health, healthSpawn1, 5));
            waveNum++;
        }
        else if (waveNum == 5 && enemyCount == 0)
        {
            WaveFive();
        }
    }
    private void WaveFive()
    {
        SpawnEnemy(Boss, bossSpawn);
        StartCoroutine(spawnEnemies(10, Health, healthSpawn1, 2));
    }
    private IEnumerator spawnEnemies(float time, GameObject enemy, Transform spawnPoint, int numEnemies)
    {
        for(int i = 0; i < numEnemies; i++)
        {
            yield return new WaitForSeconds(time);
            SpawnEnemy(enemy, spawnPoint);
        }
    }

}
