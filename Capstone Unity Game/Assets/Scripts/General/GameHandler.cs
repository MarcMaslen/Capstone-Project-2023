using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{

    //Varibles for the different level scenes and transistions
    public static bool gameOver;
    public static bool levelComplete;
    public GameObject GameOverUI;
    public GameObject LevelCompleteUI;
    public int numberOfWaves;
    public Loading LevelFader;

    //When the game starts the gameover / level complete is false until conditions are met
    void Start() {
        gameOver = false;
        levelComplete = false;
    }


    // Update is called once per frame
    void Update()
    {
        //For testing purposes, DELETE BEFORE RELEASE
        // if (Input.GetKey("e")){
        //     EndGame();
        // }
        
        //For testing purposes, DELETE BEFORE RELEASE
        // if (Input.GetKey("t")){
        //     levelCompleted();
        // }

        if(gameOver)
            return;

        //If player lives hit 0 then game over UI appears 
        if(PlayerInfo.Lives <= 0) {
            EndGame();
        }

        //Level completed it displayed the level completed UI after 10 rounds
        if(PlayerInfo.Rounds >= numberOfWaves) {
            levelCompleted();
        }
    }

    //end game function, sets it to true and displays the game over UI
    void EndGame() {
        gameOver = true;
        Debug.Log("Game Over!");
        GameOverUI.SetActive(true);
    }

    //level completed function, sets it to true and displays the level complete UI
    public void levelCompleted(){
        levelComplete = true;
        Debug.Log("Level Completed!");
        PlayerPrefs.SetInt("LevelsUnlocked", 2);
        LevelCompleteUI.SetActive(true);
    }

}
