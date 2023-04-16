using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // this is the max and min zoom values, look speed, maop border and scroll speed
    [Header("Camera Values")]
    public float LookSpeed = 27f;
    public float MapBorder = 10f;
    private float YRotation;
    private float ZRotation;
    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float MaxY = 50f;
 
    //These are the camera limits when moving around the map
    [Header("Camera Limits")]
    public float leftLimit = -30f;
    public float rightLimit = 30f;
    public float upLimit = 50f;
    public float downLimit = -4f;

 
    //The camera starts at the poisition in Unity
    void Start() {
        YRotation = transform.rotation.y;
        ZRotation = transform.rotation.z;
    }
 
 
    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.mousePosition.y;
        float mouseX = Input.mousePosition.x;

        //If the gameOver overly is enabled then it disables the camera controls
        if(GameHandler.gameOver) {
            this.enabled = false;
            return;
        }
 
        
        //This just checks the mouse is within the bounds of the game
        if (mouseX >= 0 && mouseX <= Screen.width &&
            mouseY >= 0 && mouseY <= Screen.height)
        {
 
            //These are the controls with moving using the WSAD keys
            //this allows movement within all directions while being restricted to the screen
            // up 
            if ((Input.GetKey("w") || mouseY >= Screen.height - MapBorder) &&
                transform.position.z < upLimit) {
                transform.Translate(Vector3.forward * LookSpeed * Time.deltaTime,
                                    Space.World);
            }

            // down 
            if ((Input.GetKey("s") || mouseY <= MapBorder) &&
                transform.position.z > downLimit) {
                transform.Translate(Vector3.back * LookSpeed * Time.deltaTime,
                                    Space.World);
            }
 
            // left
            if ((Input.GetKey("a") || mouseX <= MapBorder) &&
                transform.position.x > leftLimit) {
                transform.Translate(Vector3.left * LookSpeed * Time.deltaTime,
                                    Space.World);
            }
       
            // right
            if ((Input.GetKey("d") || mouseX >= Screen.width - MapBorder) &&
                transform.position.x < rightLimit) {
                transform.Translate(Vector3.right * LookSpeed * Time.deltaTime,
                                    Space.World);
            }

        //Scroll in and out of the map
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        Vector3 pos = transform.position;
        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;   

        //boundries to the screen so you can zoom in or out continuously
        pos.y = Mathf.Clamp(pos.y, minY, MaxY);
        transform.position = pos;
     
        }
    }
}
