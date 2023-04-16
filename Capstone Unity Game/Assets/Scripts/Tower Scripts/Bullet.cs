using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, DataSaveLoad
{

    //Bullets attributes
    [Header("Bullet Attributes")]
    private Transform target; //target = enemy 
    public float speed = 70f; //speed of the bullet
    public int damage = 20; // damage the bullet does
    public GameObject impactEffect; //when the bullet collides it has this impact effect
    public int extraDamage; //extra damage added onto the base damage
    
    //Here we can set speed, effects, dmg amount ect when the bullet spawns
    public void chase(Transform _target) {
        target = _target;
    }

    void Start() {
        damage += extraDamage;
    }

    // Update is called once per frame
    void Update()
    {
        //If the enemy dies then it will destroy the game object
        if ( target == null ) {
            Destroy(gameObject);
            return;
        }

        Vector3 pos = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (pos.magnitude <= distanceThisFrame) {
            HitTarget();
            return;
        }

        transform.Translate (pos.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);
        
    }

    //This is trigged when the target is hit with the bullet
    void HitTarget() {
        GameObject effectIns= (GameObject)Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(effectIns, 2f);
        DamageTaken(target);
        Destroy(gameObject);
    }

    //adds the damage done to the enemy 
    void DamageTaken( Transform enemy) {
        EnemyMovement e = enemy.GetComponent<EnemyMovement>();
        if ( e != null ) {
            e.damageEnemy(damage);
        }
    
    }

    //here we load the data
    public void loadData(PlayerData gameData){
        this.extraDamage = gameData.extraDamage;
    }

    //here we save the data 
    public void saveData(PlayerData gameData){

    }
}
