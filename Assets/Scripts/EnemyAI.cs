using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private Transform _player;
    [SerializeField] private LayerMask _whatIsGround, _whatIsPlayer;
    [SerializeField] private Animator anim;
    [SerializeField] private float sightRange;
    [SerializeField] private bool playerInSightRange;
    private void Awake()
    {
        _player = GameObject.Find("Player").transform;
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, _whatIsPlayer);
        if (!playerInSightRange)
            Idle();
        if (playerInSightRange)
            Run();
    }

    private void Idle()
    {
        anim.SetTrigger("idle");
    }

    private void Run()
    {
        anim.SetTrigger("run");
    }

    private void ChasePlayer()
    {
        _agent.SetDestination(_player.position);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
             Destroy(this.gameObject);
             Destroy(col.gameObject,1);
        }
    }
}
