using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryGameObject : MonoBehaviour
{
    void Start()
    {
        //Because I have a do not destroy script on the menu music, we use this in the level
        //so that it destroys the menu music when the level starts.
        Destroy(GameObject.Find("BackgroundMusic"));
    }
}
