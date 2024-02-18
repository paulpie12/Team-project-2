using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    //This code makes the camera move with the player
    public Transform cameraPosition;

    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
