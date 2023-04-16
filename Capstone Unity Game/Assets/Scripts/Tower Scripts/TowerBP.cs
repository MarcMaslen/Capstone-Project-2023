using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TowerBP
{
    public GameObject prefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeAmount;

    //When tower is sold player gets back half its value. Will update this too also include half of upgrade value
    public int sellAmount(){
        return cost/2;
    }
}
