using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    private AudioSource audio;

    //Effects
    public GameObject PlaceEffect;
    private TowerBP towerToBuild;
    private Node selectedTower;
    public TowerUI towerUI;
    

    //Awake method when the game turn on
    void Awake(){
        if (instance != null){
            Debug.LogError("More than one build manager instance!");
            return;
        }
        instance = this;
    }

    void Start(){
        audio = GetComponent<AudioSource>();
    }

    /*These are my bool checks (Yes or No) to check:
        1. Can the user build where there trying to place a tower
        2. Is there Gold available to buy a tower. 
    */

    public bool CanBuild {get { return towerToBuild != null;} }
    public bool GoldAvailable {get { return PlayerInfo.Gold >= towerToBuild.cost;} }

    //This checks the selected tower
    public void SelectTower (Node tower) {
        if (selectedTower == tower){
            DeselectTower();
            return;
        }
        selectedTower = tower;
        towerToBuild = null;
        towerUI.setTarget(tower);
    }

    //This deselects the tower after building it
    public void DeselectTower(){
        selectedTower = null;
        towerUI.hideUI();
    }

    //this builds the tower with the one selected
    public void PurchaseTowerToBuild(TowerBP tower){
        towerToBuild = tower;
        selectedTower = null;
        DeselectTower();
    }

    //This returns the tower to build and plays the audio
    public TowerBP getTowerToBuild(){
        if(CanBuild && GoldAvailable){
            audio.Play();
        }
        return towerToBuild;
    }
}
