using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    public Transform target;

    //Header is great for organising scripts 
    //General Settings is for all types of towers, they all need a range.
    [Header("General Settings")] 
    public float range = 15f;
    private AudioSource audio;


    //Bullet settings for the towers that shoot bullets
    [Header("Bullet Settings")]
    public bool useBullet = true;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public GameObject bulletPrefab;

    //Lazer settings for the towers that shoot a lazerBeam
    [Header("Lazer Settings")]
    public bool useLazer = false;
    public LineRenderer lazerBeam;
    public ParticleSystem hitEffect;

    //Setup settings for all towers
    [Header("Setup Settings")]
    public Transform firePoint;
    public Transform partToRotate;
    public float turnSpeed = 10f;
    public string enemyTag = "enemy";



    // Start is called before the first frame update
    void Start(){
        try
        {
            InvokeRepeating("UpdateTarget", 0f, 0.5f);
            audio = GetComponent<AudioSource>();
        }
        catch (System.Exception)
        {
            
            throw;
        }

    }

    //this updates so that the towers are constandly scanning for enemies nearby
    void UpdateTarget(){
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach(GameObject enemy in enemies){
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance) {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }

        }

        if (nearestEnemy != null && shortestDistance <= range) {
            target = nearestEnemy.transform;
        } else {
            target = null;
        }
    }



    // Update is called once per frame
    void Update(){
        if(target == null){
            if(useLazer) {
                if(lazerBeam.enabled) {
                    lazerBeam.enabled = false;
                    hitEffect.Stop();
                }
            }
            return;
        }
        FocusToTarget();
    
       if (useLazer) {
           Lazer();
           
       }

        if (useBullet){
            if(fireCountdown <= 0f) {
            shoot();
            audio.Play();
            fireCountdown = 1f/fireRate;
            }
        } 

        fireCountdown -= Time.deltaTime;
    }
    

    //Bullet settings for shooting. 
    void shoot(){
        //Debug.Log("Shoot");
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet Bullet = bulletGO.GetComponent<Bullet>();

        if(Bullet != null)
            Bullet.chase(target);
    }

    //Draws a sphere around the selected turret to display the range it has
    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

    //This is the method that makes the towers lock onto the enemies
    void FocusToTarget(){
        //Points Friendly tower to enemy and locks on
        Vector3 dir = target.position - transform.position;
         // This deals with rotation
        Quaternion towerRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, towerRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);
        
    }
 
    //Lazer Method
    void Lazer() {
        if(!lazerBeam.enabled)  {
            lazerBeam.enabled = true;
            //plays the partical effect for lazer hit.
            hitEffect.Play();
        }
            
        
        lazerBeam.SetPosition(0, firePoint.position);
        lazerBeam.SetPosition(1, target.position);

        Vector3 dir = firePoint.position - target.position;
        hitEffect.transform.position = target.position + dir.normalized;
        hitEffect.transform.rotation = Quaternion.LookRotation(dir);
    }
}
