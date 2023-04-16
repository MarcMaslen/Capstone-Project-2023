using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //we can save it in a file with this
public class PlayerData {

    public float musicLevel; //music level
    public int permLevel; //permanent player level
    public int skillPoints; //permanent skill points
    public float brightness; //brightness level

    [Header("Skills")]
    public int levelXP; //level xp
    public int xpForLevel; //xp needed for level
    public int extraDamage; //extra tower damage added onto the base damage
    public int extraInGameGold; //extra in game gold added onto the base gold
    public int extraInGameHP;  //extra in game hp added onto the base hp

 

    //TO-DO:
    // - Add brightness settings - Done
    // - Add global player level - Done

    //These are the default values for the player data when starting a new game
    //when new values are saved they are overridden.
    public PlayerData (){
         musicLevel = .5f;
         permLevel = 0;
         brightness = 0;
         xpForLevel = 200;
         skillPoints = 0;
         extraDamage = 0;
         extraInGameHP = 0;
         extraInGameGold = 0;
         levelXP = 0;
    }
    
}
