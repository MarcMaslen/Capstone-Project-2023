using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public Loading LevelFader;

    //Array to store all levels
    public Button[] ButtonLevels;

    void Start(){
        //This allows data to be saved such as levels completed
        //this also specifies only level 1 will be unlocked when first starting
        int levelsUnlocked = PlayerPrefs.GetInt("LevelsUnlocked", 1);

        //loops through level buttons in the array
        for (int i = 0; i < ButtonLevels.Length; i++ ){

            if( i + 1 > levelsUnlocked){
                //This makes any button after level 1 not interactable until unlocked
                ButtonLevels[i].interactable = false;        
            }
        }
    }

    //this is the level fader
    public void Select(string levelName){
        LevelFader.FadeTo(levelName);

    }
}
