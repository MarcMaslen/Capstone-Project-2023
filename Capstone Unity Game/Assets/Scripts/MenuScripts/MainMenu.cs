using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour, DataSaveLoad
{

    [Header("Scene Names")]
    public string NextScene;
    public string settings;
    public string skills;

    public Loading fader;

    [Header("Saved Settings")]
    private float musicLevel; //holds music level value
    public float brightness; //brightness level
    public Image background; //background image
    public int level; //level for account 
    public Text levelText; //level text

    //When the scene is loaded we will put the slider value to the music level
    void Update(){
        AudioListener.volume = musicLevel;
        levelText.text = "Level: " + level.ToString();
        ChangeAlpha(brightness); //change alpha
    }

    //allows the user to change the brightness by changing the alpha of the overlay. 
    public void ChangeAlpha(float alpha){
        background.color = new Color(background.color.r, background.color.g, background.color.b, alpha);
    }

    //Play sends them to the level select screen
    public void Play(){
        Debug.Log("Play");
        fader.FadeTo(NextScene);
    }

    //Setting will allow them to change resolution and sounds
    public void Settings(){
        Debug.Log("Settings");
        fader.FadeTo(settings);
    }

    //Skills will allow them to change resolution and sounds
    public void Skills(){
        Debug.Log("Skills");
        fader.FadeTo(skills);
    }

    //Exit exits the game
    public void Exit(){
        Debug.Log("Exit");
        Application.Quit();
    }

    //here we load the data in from player data and set it to the music level
     public void loadData(PlayerData gameData){
        this.musicLevel = gameData.musicLevel;
        this.level = gameData.permLevel;
        this.brightness = gameData.brightness;
    }

    //here we save the data in from music level and save it to player data for next save
    //NOTE: This is not used in this script but is needed for the interface
    public void saveData(PlayerData gameData){
         //gameData.permLevel = this.level;
    }
}
