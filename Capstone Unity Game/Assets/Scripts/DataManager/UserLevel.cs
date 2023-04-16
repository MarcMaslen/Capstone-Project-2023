using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserLevel : MonoBehaviour, DataSaveLoad
{
    public int level; //level of account
    public int xp; //xp of account
    public int xpForLevel; //xp needed for level
    public int SP; //skill points
    public int levelForSP; //level needed for skill points

    // Start is called before the first frame update
    void Start()
    {
        xp = 0; //just sets the xp gained in the level to zero when starting
    }

    // Update is called once per frame
    void Update()
    {
        //When the amount of xp reaches the xp for level up, level the user up and increase max xp needed + reset xp
        if (xp >= xpForLevel){
            level += 1; //add level
            levelForSP += 1; //add sp for skill points
            xpForLevel += 200; //add 200xp for next level
            xp = 0;
            if (levelForSP >= 3){ //if sp reaches 3 then add skill point and reset sp
                SP += 1;
                levelForSP = 0;
            }
        }
    }

     //here we load the data for the player
    public void loadData(PlayerData gameData){
        this.level = gameData.permLevel;
        this.xp = gameData.levelXP;
        this.xpForLevel = gameData.xpForLevel;
        this.SP = gameData.skillPoints;
    }

    //here we save the data for the player
    public void saveData(PlayerData gameData){
       gameData.permLevel += this.level;
       gameData.skillPoints += this.SP;
       gameData.levelXP += this.xp;
       gameData.xpForLevel = this.xpForLevel;
    }
}
