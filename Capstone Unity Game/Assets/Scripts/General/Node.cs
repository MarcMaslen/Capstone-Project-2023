using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour{

    //This is the build manager and its properties
    BuildManager buildManager;
    public Color hoverColor;
    public Color InsufficentGoldWarning;
    public Vector3 positionOffset;


    [HideInInspector]
    public GameObject tower;
    [HideInInspector]
    public TowerBP towerBP;
    [HideInInspector]
    public bool isUpgraded = false;

    private Renderer rend;
    private Color startColor;



    //When the Game Starts
    void Start() {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }


    // This gets the build position
    public Vector3 GetBuildPos () {
        return transform.position + positionOffset;
    }



    //When the left mouse button is pressed down 
    void OnMouseDown() {

        //Checks to see if we are hovering over a UI element
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        //If a tower is already built 
        if (tower != null) {
            buildManager.SelectTower(this);
            return;
        }

        if (!buildManager.CanBuild) 
            return;

       BuildTower(buildManager.getTowerToBuild());

    }



    //Handles building the towers by checking the gold and if you have enough
    //subtract it away and play tower
    void BuildTower (TowerBP blueprint){

         // Check to see if the player has enough gold
        if (PlayerInfo.Gold < blueprint.cost) { 
            Debug.Log("Need more gold!");
            return;
        }

        //Subtracts tower cost from gold
        PlayerInfo.Gold -= blueprint.cost; 

         //Build Turret
         GameObject _tower = (GameObject)Instantiate(blueprint.prefab, GetBuildPos(), Quaternion.identity);
         tower = _tower;

         towerBP = blueprint;

         //makes the tower place effect
         GameObject effect = (GameObject)Instantiate(buildManager.PlaceEffect, GetBuildPos(), Quaternion.identity);
         Destroy(effect, 5f);
         Debug.Log("Tower Built Successfully!");
    }



    //Wehn the mouse enters a certain area it will render the color
    void OnMouseEnter() {

        //Checks to see if we are hovering over a UI element
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        //If the mouse button is pressed when no tower selected return
        if (!buildManager.CanBuild) 
            return;

        if (buildManager.GoldAvailable) {
            rend.material.color = hoverColor;
        } else {
            rend.material.color = InsufficentGoldWarning;
        }

        
    }

    //after letting go of mouse it will render a color for the node. red for no or grey for yes place
    void OnMouseExit() {
        rend.material.color = startColor;
    }


    //Handles upgrading the tower
    public void towerUpgrade(){
       
       //Checks if player needs more gold for upgrade
        if (PlayerInfo.Gold < towerBP.upgradeAmount) { 
            Debug.Log("Need more gold to upgrade!");
            return;
        }

        //subtracts gold from gold reserve
        PlayerInfo.Gold -= towerBP.upgradeAmount; 

        //destory old tower
        Destroy(tower);
    
        //build new tower
         GameObject _tower = (GameObject)Instantiate(towerBP.upgradedPrefab, GetBuildPos(), Quaternion.identity);
         tower = _tower;

         isUpgraded = true;

         GameObject effect = (GameObject)Instantiate(buildManager.PlaceEffect, GetBuildPos(), Quaternion.identity);
         Destroy(effect, 5f);
         Debug.Log("Tower upgrade Successful!");
    }

    public void sellTower(){
        PlayerInfo.Gold += towerBP.sellAmount();

        Destroy(tower);
        towerBP = null;

        //resets upgrade for node
        isUpgraded = false;
    }
    
}
