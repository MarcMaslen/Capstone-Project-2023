using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToMenu : MonoBehaviour
{
     public Loading fader;
     

   //Scene for menu
   public string mainmenu = "Menu";

    //Takes the player back to the menu 
   public void Menu() {
        Debug.Log("Menu");
        Time.timeScale = 1f;
        fader.FadeTo(mainmenu);
   }

}
