using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelSelectMenu : MonoBehaviour, DataSaveLoad
{

    public int level; //level of account
    public Text levelText; //level text




    //When the user changes the slider value we will change the music level and the audio listen volume
    void Update(){
        levelText.text = "Level: " + level.ToString();
    }


    //here we load the data
    public void loadData(PlayerData gameData){
        this.level = gameData.permLevel;
    }

    //here we save the data 
    public void saveData(PlayerData gameData){

    }

}