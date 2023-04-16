using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInfo : MonoBehaviour, DataSaveLoad
{
    //Any Info for the player goes into here

    //Gold / Currency 
    public static int Gold;
    public int startingGold = 400; 
    public int BonusGold;

    //Base Health
    public static int Lives;
    public int startLives = 50;
    public int bonusHP;
    
    //Waves
    public static int Rounds;

    void Start() {
        //these varibles are to make sure we start with the correct health, gold ect.
        Gold = startingGold + BonusGold;
        Lives = startLives + bonusHP;
        Rounds = 0; // resets rounds back to zero on start

    }

    //here we load the data
    public void loadData(PlayerData gameData){
       this.bonusHP = gameData.extraInGameHP;
       this.BonusGold = gameData.extraInGameGold;
    }

    //here we save the data 
    public void saveData(PlayerData gameData){

    }
    
}
