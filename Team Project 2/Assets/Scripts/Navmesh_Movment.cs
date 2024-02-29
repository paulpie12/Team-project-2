using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navmesh_Movment : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public Transform Player;
    public Transform Distraction;

    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (Throwable.doesDistractionExist == false)
        {
            Enemy.SetDestination(Player.position);
            Debug.Log("Donut is targeting the player");
        }
        
        else
        {
            Enemy.SetDestination(Distraction.position);
            Debug.Log("Donut is targeting a distraction object");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered collision with " + collision.gameObject.name);
    }
}
