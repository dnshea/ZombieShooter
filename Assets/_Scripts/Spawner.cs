using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Prefabs that spawn through the spawner
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
    //Boss Spawning
    public Transform bossSpawn;
    public Transform healthSpawn3;
    //Count of Enemy that are alive
    public int enemyCount;
    //Wave Number
    public int waveNum = 1;

    private bool startWave; 
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        WaveOne();
    }
    /// <summary>
    /// Script to spawn enemy used on coroutine
    /// </summary>
    /// <param name="enemy"></param>enemy
    /// <param name="spawnPoint"></param>where is spawns
    private void SpawnEnemy(GameObject enemy, Transform spawnPoint)
    {
        Instantiate(enemy, spawnPoint.transform);
        enemyCount++;
    }
    private void health(GameObject health, Transform spawnPoint)
    {
        Instantiate(health, spawnPoint.transform);
    }
    /// <summary>
    /// Wave One
    /// </summary>
    private void WaveOne()
    {
        if(waveNum == 1)
        {
            //Ground Spawn
            StartCoroutine(spawn(3, Zombie, spawnOne, 3));
            StartCoroutine(spawn(4, Zombie, spawnTwo, 1));
            StartCoroutine(spawn(5, Zombie, spawnThree, 1));
            StartCoroutine(spawn(7, Mortar, spawnFour, 1));
            //Air Spawn
            StartCoroutine(spawn(6, Flying, spawnAir11, 2));
            StartCoroutine(spawn(6, Flying, spawnAir12, 2));
            //Health Spawn
            StartCoroutine(spawnHealth(5, Health, healthSpawn1, 2));
            waveNum++;
        }
        else if(waveNum == 2 && enemyCount == 0)
        {
            startWave = false;
            StartCoroutine(waitWave());
            if (startWave == true)
            {
                WaveTwo();
            }
        }

    }
    /// <summary>
    /// Wave Two
    /// </summary>
    private void WaveTwo()
    {
        if (waveNum == 2)
        {
            //Ground Spawn
            StartCoroutine(spawn(3, Zombie, spawnOne, 5));
            StartCoroutine(spawn(4, Zombie, spawnTwo, 3));
            StartCoroutine(spawn(5, Zombie, spawnThree, 3));
            StartCoroutine(spawn(10, Mortar, spawnFour, 2));
            StartCoroutine(spawn(10, Mortar, spawnFive, 3));
            //Air Spawn
            StartCoroutine(spawn(6, Flying, spawnAir11, 3));
            StartCoroutine(spawn(6, Flying, spawnAir12, 3));
            StartCoroutine(spawn(20, Flying, spawnAir13, 1));
            StartCoroutine(spawn(20, Flying, spawnAir14, 1));
            StartCoroutine(spawn(20, Flying, spawnAir15, 1));
            //Health Spawn
            StartCoroutine(spawnHealth(7, Health, healthSpawn1, 4));
            waveNum++;
        }
        else if (waveNum == 3 && enemyCount == 0)
        {
            startWave = false;
            StartCoroutine(waitWave());
            if (startWave == true)
            {
                WaveThree();
            }
        }
    }
    /// <summary>
    /// Wave Three
    /// </summary>
    private void WaveThree()
    {
        if (waveNum == 3)
        {
            //Ground Spawn
            StartCoroutine(spawn(3, Zombie, spawnOne2, 6));
            StartCoroutine(spawn(4, Bomber, spawnTwo2, 2));
            StartCoroutine(spawn(4, Bomber, spawnThree2, 3));
            StartCoroutine(spawn(10, Mortar, spawnFour2, 3));
            StartCoroutine(spawn(10, Bomber, spawnFive2, 2));
            //Air Spawn
            StartCoroutine(spawn(5, Flying, spawnAir21, 2));
            StartCoroutine(spawn(6, Flying, spawnAir22, 3));
            StartCoroutine(spawn(15, Flying, spawnAir23, 2));
            StartCoroutine(spawn(15, Flying, spawnAir24, 2));
            StartCoroutine(spawn(20, Flying, spawnAir25, 1));
            //Health Spawn
            StartCoroutine(spawnHealth(7, Health, healthSpawn2, 4));
            waveNum++;
        }
        else if (waveNum == 4 && enemyCount == 0)
        {
            startWave = false;
            StartCoroutine(waitWave());
            if (startWave == true)
            {
                WaveFour();
            }
        }
    }
    /// <summary>
    /// Wave Four
    /// </summary>
    private void WaveFour()
    {
        if (waveNum == 1)
        {
            //Ground Spawn
            StartCoroutine(spawn(3, Zombie, spawnOne2, 8));
            StartCoroutine(spawn(4, Bomber, spawnTwo2, 4));
            StartCoroutine(spawn(4, Bomber, spawnThree2, 4));
            StartCoroutine(spawn(10, Mortar, spawnFour2, 4));
            StartCoroutine(spawn(10, Bomber, spawnFive2, 4));
            //Air Spawn
            StartCoroutine(spawn(5, Flying, spawnAir21, 5));
            StartCoroutine(spawn(6, Flying, spawnAir22, 3));
            StartCoroutine(spawn(15, Flying, spawnAir23, 2));
            StartCoroutine(spawn(10, Flying, spawnAir24, 4));
            StartCoroutine(spawn(10, Flying, spawnAir25, 4));
            //Health Spawn
            StartCoroutine(spawnHealth(7, Health, healthSpawn2, 5));
            waveNum++;
        }
        else if (waveNum == 5 && enemyCount == 0)
        {
            startWave = false;
            StartCoroutine(waitWave());
            if (startWave == true)
            {
                WaveFive();
            }
        }
    }
    /// <summary>
    /// Boss Wave
    /// </summary>
    private void WaveFive()
    {
        //Boss and Health spawn in Boss arena
        SpawnEnemy(Boss, bossSpawn);
        StartCoroutine(spawnHealth(10, Health, healthSpawn3, 2));
    }
    /// <summary>
    /// Coroutine to Spawn Enemies
    /// </summary>
    /// <param name="time"></param> the time between each spawn
    /// <param name="enemy"></param> what enemy spawns here
    /// <param name="spawnPoint"></param> where it spawns
    /// <param name="numEnemies"></param> the number it spawns
    /// <returns></returns>
    private IEnumerator spawn(float time, GameObject enemy, Transform spawnPoint, int numEnemies)
    {
        for(int i = 0; i < numEnemies; i++)
        {
            yield return new WaitForSeconds(time);
            SpawnEnemy(enemy, spawnPoint.transform);
        }
    }
    private IEnumerator spawnHealth(float time, GameObject heal, Transform spawnPoint, int numEnemies)
    {
        for (int i = 0; i < numEnemies; i++)
        {
            yield return new WaitForSeconds(time);
            health(heal, spawnPoint.transform);
        }
    }
    private IEnumerator waitWave()
    {
            yield return new WaitForSeconds(5);
        startWave = true;
    }
}
