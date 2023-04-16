using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMovement : MonoBehaviour
{
    //Enemy default stats
    [Header("Enemy Stats")]
    public float speed = 7f; //This is the enemy speed 
    public float startingHP = 100; // starting health for enemy
    public float health; // current health of enemy
    public int droppedLoot = 50; // dropped goal the enemy gives the player
    public int xpGained; // xp gained from the enemy
    private UserLevel userLevel; //user level script
    
    //Wave variables 
    private Transform target;
    private int wavepointIndex = 0;

    [Header("Health")]
    public Image healthBar; // health bar above enemy heads img

    

    //When the wave starts and enemies spawn they first go to waypoint 0 and enemy health is equal to the starting hp
    void Start(){
        target = Waypoints.points[0];
        health = startingHP;
        xpGained = 0;
        userLevel = GameObject.FindGameObjectWithTag("UserLevel").GetComponent<UserLevel>();
    }

    void Update(){

        //Sets the direction the enemy needs to look in
        Vector3 direction = target.position - transform.position;
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
      
        //When enemy is close to waypoint they are told to go to the next one
        if(Vector3.Distance(transform.position, target.position) <= 0.4f){
            getNextWaypoint();
        }

        //rotates the enemy towards the next waypoint
        transform.LookAt(target);

        //Take enemy to next waypoint going through the list of them. 
        void getNextWaypoint(){
            if(wavepointIndex >= Waypoints.points.Length - 1){
                EnemyReachesGoal();
                return;
            }

            wavepointIndex++;
            target = Waypoints.points[wavepointIndex];
        }

    }

    //If the enemy reaches its goal, which is your base it takes health off the player
    void EnemyReachesGoal(){
        PlayerInfo.Lives--;
        Destroy(gameObject);
        WaveSpawner.enemysOnMap--;
    }

    //When the enemy is damaged it takes that off the health bar, if this reaches 0 it is destroyed
    public void damageEnemy (float damageTaken) {
        health -= damageTaken;
        healthBar.fillAmount = health / startingHP;
        if (health <= 0) {
            Defeated();
        }
    }

    //Enemies are destroyed and loot is given to the player
    //TO-DO: add death animation for enemies and a loot animation
    //maybe gold is left on ground and player hovers mouse over gold to get it
    private void Defeated () {
        PlayerInfo.Gold += droppedLoot;
        userLevel.xp += 10;
        Debug.Log("Gold and 10xp gained Gained!");
        Destroy(gameObject);
        WaveSpawner.enemysOnMap--;
    }

}
