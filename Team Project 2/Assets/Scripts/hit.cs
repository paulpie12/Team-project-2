using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    private float life = 2;

     void Awake()
    {
        Destroy(gameObject, life);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
    }
}
