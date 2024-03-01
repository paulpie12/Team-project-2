using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyNavmesh : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public Transform Enemypos;
    public Transform Canis;

    public LayerMask whatIsPlayer;
    public LayerMask whatIsCanis;

    public float sightRange;
    public bool playerInSight;

    private bool stunned;

    private void Awake()
    {
        Player = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (Throwable.doesDistractionExist == true)
        {
            Canis = GameObject.Find("Canis(Clone)").transform;
            enemy.SetDestination(Canis.position);
            Debug.Log("Enemy is targeting plusie");
        }

        else if (playerInSight == true)
        {
            enemy.SetDestination(Player.position);
            Debug.Log("Enemy is targeting player");
        }

        else if (playerInSight != true)
        {
            enemy.SetDestination(Enemypos.position);
            Debug.Log("Enemy is standing still");
        }


        if (stunned == true)
        {
            enemy.SetDestination(Enemypos.position);
            Invoke("stunevent", 3);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            stunned = true;
        }
    }
    private void stunevent()
    {
        stunned = false;
    }

}
