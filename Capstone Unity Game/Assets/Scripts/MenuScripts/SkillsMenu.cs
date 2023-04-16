using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillsMenu : MonoBehaviour, DataSaveLoad
{

   [Header("Skills Settings")]
    public float musicLevel; //music level
    public float brightness; //Brightness level
    public Image background; //background image
    public int level; //level of account
    public Text levelText; //level text
    public int SP; //skill points
    public Text spText; //skill points text

    [Header("Skills")]
    public int bonusHP; //bonus hp
    public int BonusGold; 
    public int extraDamage; //bonus lazer damage




    //When the user changes the slider value we will change the music level and the audio listen volume
    void Update(){
        AudioListener.volume = musicLevel;
        levelText.text = "Level: " + level.ToString();
        spText.text = "SP: " + SP.ToString();
        ChangeAlpha(brightness); //change alpha
    }

    //this sets the alpha of the background image to act as a brightness overlay
    public void ChangeAlpha(float alpha){
        background.color = new Color(background.color.r, background.color.g, background.color.b, alpha);
    }

    public void healthUpgrade(){
        //this is where we will upgrade the lives for each game
        if (SP > 0){
            SP -= 1;
            bonusHP += 5;
        }
    }

    public void startingGold(){
        //this is where we will upgrade the starting gold for each game
        if (SP > 0){
            SP -= 1;
            BonusGold += 10;
        }
    }

    public void damageUpgrade(){
        //this is where we will upgrade the damage for the lazer
        if (SP > 0){
            SP -= 1;
            extraDamage += 1;
        }
    }

    //here we load the data
    public void loadData(PlayerData gameData){
        this.musicLevel = gameData.musicLevel;
        this.level = gameData.permLevel;
        this.brightness = gameData.brightness;
        this.SP = gameData.skillPoints;
    }

    //here we save the data 
    public void saveData(PlayerData gameData){
        gameData.skillPoints = this.SP;
        gameData.extraInGameHP += this.bonusHP;
        gameData.extraInGameGold += this.BonusGold;
        gameData.extraDamage += this.extraDamage;

    }

}