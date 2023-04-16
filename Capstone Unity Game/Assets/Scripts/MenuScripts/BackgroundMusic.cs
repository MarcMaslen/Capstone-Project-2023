using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
     
    void Start()
    {
        //if this game object already exists in the scene, destroy it so there is only 1.
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

        //if this game object is the only one in the scene, make it not destroy on load so it can be used in other scenes.
        DontDestroyOnLoad(this.gameObject);
    }
}
