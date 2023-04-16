using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    
   public Text roundsText;
   public Loading fader;

   //Scene for menu
   public string mainmenu = "Menu";

    //Displays the round the player got too
   void OnEnable() {
       roundsText.text = PlayerInfo.Rounds.ToString();
   }

    //Resets the scene so they can play again
   public void goAgain() {
       fader.FadeTo(SceneManager.GetActiveScene().name);
        
   }

    //Takes the player back to the menu 
   public void Menu() {
        Debug.Log("Menu");
        Time.timeScale = 1f;
        fader.FadeTo(mainmenu);

   }


}
