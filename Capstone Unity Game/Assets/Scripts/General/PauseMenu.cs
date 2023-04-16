using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour, DataSaveLoad
{

    public GameObject UI;
    public Loading fader;

    public string mainmenu = "Menu";

    [Header("Saved Settings")]
    private float musicLevel; //holds music level value
    public float brightness; //music level
    public Image background; //background image
    public int level;
    

    //allows the user to change the brightness by changing the alpha of the overlay. 
    public void ChangeAlpha(float alpha){
        background.color = new Color(background.color.r, background.color.g, background.color.b, alpha);
    }

    //When the escape key is pressed it opens the menu or closed the menu
    void Update(){
        AudioListener.volume = musicLevel;
        //levelText.text = "Level: " + level.ToString();
        ChangeAlpha(brightness); //change alpha

        if (Input.GetKeyDown(KeyCode.Escape)) {
            ToggleMenu();
        }
    }

    //When menu is toggled it changes the timescale in game. If pause menu is up then game is frozen
    public void ToggleMenu(){
        UI.SetActive( !UI.activeSelf );
        if (UI.activeSelf){
            Time.timeScale = 0f;
        } else {
            Time.timeScale = 1f;
        }
    }

    //resets level
    public void retry() {
        ToggleMenu();
        fader.FadeTo(SceneManager.GetActiveScene().name);
    }

    //takes player to menu
    public void Menu(){
        Debug.Log("Menu");
        ToggleMenu();
        fader.FadeTo(mainmenu);
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
         gameData.permLevel = this.level;
    }
    
}
