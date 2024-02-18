using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    //These floats determine your X and Y sensitivity
    public float sensX;
    public float sensY;

    //These floats determine your X and Y sensitivity
    public Transform orientation;
    float xRotation;
    float yRotation;

    private void Start()
    {
        //This locks your cursor, and makes it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        //This code gets mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        //This code prevents you from rolling your head too far back / into your chest
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //This code rotates the camera
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        //This code orients the camera with the player
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
