using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //anything with this script will not be destroyed when a new scene is loaded
        DontDestroyOnLoad(this.gameObject);
    }

}
