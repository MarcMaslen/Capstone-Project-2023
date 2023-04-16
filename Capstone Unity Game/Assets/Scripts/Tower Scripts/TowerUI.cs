using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerUI : MonoBehaviour
{

    [Header("Tower Details")]
    public GameObject UI;
    public Text SellAmount;
    public Text UpgradeCost;
    public Button upgradeBtn;
    private Node target;


    //Chooses tower to lock onto
    //when I click a tower it knows what to display for upgrade


    /* 
    TO-DO
    - Add more upgrade options
    - Add constant upgrade for the towers
    */

    public void setTarget(Node _target) {
        target = _target;

        transform.position = target.GetBuildPos();

        //If tower is not upgraded display upgrade amount
        if (!target.isUpgraded){
            UpgradeCost.text = target.towerBP.upgradeAmount.ToString();
            upgradeBtn.interactable = true;

        //if tower is upgrade display upgrade as max and make button not clickable
        } else {
            UpgradeCost.text = "MAX";
            upgradeBtn.interactable = false;
        }

        //displays sell amount on Button
        SellAmount.text = target.towerBP.sellAmount().ToString();
        
        //sets UI to active
        UI.SetActive(true);
    }

    //Hides Upgrade UI
    public void hideUI() {
        UI.SetActive(false);
    }

    //When tower is upgraded, deselect tower
    public void upgrade(){
        target.towerUpgrade();
        BuildManager.instance.DeselectTower();
    }

//Sell tower and deselect tower
    public void sell(){
        target.sellTower();
        BuildManager.instance.DeselectTower();
    }
}
