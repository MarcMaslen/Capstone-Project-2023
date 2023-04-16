using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GoldUI : MonoBehaviour
{
    
    public Text GoldText;

    //Displs the current gold amount on screen
    void Update() {
        GoldText.text = PlayerInfo.Gold.ToString();
    }
}
