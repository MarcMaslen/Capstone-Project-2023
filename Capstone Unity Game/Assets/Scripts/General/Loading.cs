using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Image loadingScene;
    public AnimationCurve animCurve;
    public int loadingTime;

    //When any scene starts it fades in like a loading screen
    void Start(){
        StartCoroutine(FadeIn());
    }


    //Loading scene fade in animation
    IEnumerator FadeIn(){
        float imageTime = 1f;

        //slowly fades in like loading a new scene
        while(imageTime > 0f){
            imageTime -= Time.deltaTime * loadingTime;
            float alphaValue = animCurve.Evaluate(imageTime);
            loadingScene.color = new Color(0f, 0f, 0f, alphaValue);
            yield return 0;
        }
    }


    //loading scene fade out animation
    IEnumerator FadeOut(string scene){
        float imageTime = 0f;

        //slowly fades in like loading a new scene
        while(imageTime < 1f){
            imageTime += Time.deltaTime * loadingTime;
            float alphaValue = animCurve.Evaluate(imageTime);
            loadingScene.color = new Color(0f, 0f, 0f, alphaValue);
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }


      public void FadeTo(string scene){
           StartCoroutine(FadeOut(scene));
      }
}
