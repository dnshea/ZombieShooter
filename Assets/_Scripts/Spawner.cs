using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            
            StartCoroutine(spawnDelay(3, Zombie, spawnOne, 3));
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
            SpawnEnemy(Zombie, spawnOne);
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
            SpawnEnemy(Zombie, spawnOne);
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
            SpawnEnemy(Zombie, spawnOne);
            waveNum++;
        }
        else if (waveNum == 5 && enemyCount == 0)
        {
            WaveFive();
        }
    }
    private void WaveFive()
    {

    }
    private IEnumerator spawnDelay(float time, GameObject enemy, Transform spawnPoint, int numEnemies)
    {
        for(int i = 0; i < numEnemies; i++)
        {
            SpawnEnemy(enemy, spawnPoint);
            yield return new WaitForSeconds(time);
        }
        
        waveNum++;
    }

}
