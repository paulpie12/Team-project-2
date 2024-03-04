using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{
    static public bool isCheating = false;

    public void infiniteCanis()
    {
        isCheating = !isCheating;
        if(isCheating == true)
        {
        Throwable.totalThrows = 999;
        Debug.Log(Throwable.totalThrows);
        }
       
        if(isCheating == false)
        {
        Throwable.totalThrows = 3;
        Debug.Log(Throwable.totalThrows);
        }
    }


}
