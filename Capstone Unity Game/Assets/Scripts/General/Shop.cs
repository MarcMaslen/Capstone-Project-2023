using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    public TowerBP MagicMissileTower;
    public TowerBP FireballSniperTower;
    public TowerBP LazerDamageTower;

    BuildManager buildManager;

    void Start() {
        buildManager = BuildManager.instance;
    }

    //This will be where I manage all of the towers that can be built
    /* 
    TO-DO:
     - Add 2-3 more towers 
     - give them unique defenses
     - Add one passive denfence to boost those around it

    */

    //This will be where I manage all of the towers that can be built
    public void PurchaseAntivirusTower() {
        Debug.Log("Magic Missile Tower Selected");
        buildManager.PurchaseTowerToBuild(MagicMissileTower);
    }

     public void PurchaseFirewallTower() {
        Debug.Log("Fireball Sniper Tower Selected");
        buildManager.PurchaseTowerToBuild(FireballSniperTower);
    }

     public void PurchaseArcherTower() {
        Debug.Log("Lazer Tower Selected");
        buildManager.PurchaseTowerToBuild(LazerDamageTower);
    }
}

