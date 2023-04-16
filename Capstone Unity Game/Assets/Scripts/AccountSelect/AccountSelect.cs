using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AccountSelect : MonoBehaviour
{
    public string Menu; //Sets menu as the next scene
    public Loading fader; //adds the fader to transition between scenes 

    //new game button which would wipe the previous save and start new
    public void OnNewGame(){
        Debug.Log("New Game");
        DataManager.dataManager.newGame(); //create a new game save
        fader.FadeTo(Menu); //fades to menu with new game save
    }
    
    //load game button which loads the current save.
    public void OnLoadGame(){
        Debug.Log("Load Game");
        fader.FadeTo(Menu); //load into the game with the saved game data


    }
}
