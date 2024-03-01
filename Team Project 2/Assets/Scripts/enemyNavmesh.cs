using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyNavmesh : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public LayerMask whatIsPlayer;
    public Transform Enemypos;

    public float sightRange;
    public bool playerInSight;
    private void Awake()
    {
        Player = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);


        if(playerInSight == true)
        {
            enemy.SetDestination(Player.position);
        }

        if (playerInSight != true)
        {
            enemy.SetDestination(Enemypos.position);
        }
    }
}
