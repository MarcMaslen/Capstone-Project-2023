using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentWave : MonoBehaviour
{
    //Round text to display current round
   public Text roundsText;

    /*
    TO-DO:
    - Add current round / game timer for leaderboards
    - Add an enemys left count down on screen
    - Add a button to start next round instead of countdown
    */

    //This updates round text to display
   void Update() {
       roundsText.text = PlayerInfo.Rounds.ToString();
   }
}

