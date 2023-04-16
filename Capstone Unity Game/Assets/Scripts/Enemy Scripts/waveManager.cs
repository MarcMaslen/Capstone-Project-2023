using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class waveManager
{
    //Managed the waves so I can choose the eenmy, enemy amount and spawn rate.

    /* 
    TO-DO
    - Change enemy prefab to an array so different prefabs can be used within one round
    - When an endless mode is added, evey round slowly increase enemy amount or difficulty
    */
    
    public GameObject enemyPrefab;
    public int enemyAmount;
    public float spawnRate;
}
