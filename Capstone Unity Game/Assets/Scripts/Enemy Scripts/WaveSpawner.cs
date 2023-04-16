using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{

    //Enemy data
    public static int enemysOnMap = 0;
    public Transform enemy;
    public Transform spawnPoint;

    //Wave data
    public float timeBetweenWaves = 5f;
    private float countdown = 5f;
    public waveManager[] waves;
    public GameHandler GameHandler;
    public Text waveCountdown;
    private int waveIndex = 0;

    void Start(){
        enemysOnMap = 0;
    }
    

    void Update() {

        //When no more enemies on map, start countdown
        if(enemysOnMap > 0) {
            return;
        }

        //waits to spawn more enemys until all are dead
        if (countdown <= 0f) {
            //check if enemys are alive
            StartCoroutine(waveSpawn());
            countdown = timeBetweenWaves; 
            return;
        } 

        //Displays countdown on screen
        countdown -= Time.deltaTime;
        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
        waveCountdown.text = string.Format("{0:00}", countdown);
        
    }
  

    //Wave Spawning 
    IEnumerator waveSpawn(){
        PlayerInfo.Rounds++;

        waveManager wave = waves[waveIndex];

        for (int i = 0; i < wave.enemyAmount; i++) {
            SpawnEnemy(wave.enemyPrefab);
            enemysOnMap++;
            yield return new WaitForSeconds(1f / wave.spawnRate);
        }

        waveIndex++;

        //edit here to add the level complete screen
        if (waveIndex == waves.Length){
            Debug.Log("Level Won!");
            GameHandler.levelCompleted();
            this.enabled = false;
        }
    } 



    //Enemy Spawning
    void SpawnEnemy(GameObject enemy) {
        //Debug.Log("Spawning Enemy" + _enemy.name);
        Instantiate (enemy, spawnPoint.position, spawnPoint.rotation);

    }


}