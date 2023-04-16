using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScreen : MonoBehaviour
{
    public GameObject controlsUI;

    // Start is called before the first frame update
    void Start()
    {
        controlsUI.SetActive(true);
        StartCoroutine(waiter());
    
    }

    IEnumerator waiter(){
        yield return new WaitForSeconds(1);
        Time.timeScale = 0f;
    }

    public void start_game(){
        controlsUI.SetActive(false);
        Time.timeScale = 1f;
    }
}
