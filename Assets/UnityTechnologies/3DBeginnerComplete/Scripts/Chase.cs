using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Chase : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Transform _target;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void Init(Transform target)
    {
        _target = target;
    }

    public void Update()
    {
        // Chase target only if they are turned away
        var direction = _target.position - transform.position;
        _navMeshAgent.SetDestination(Vector3.Dot(direction, _target.forward) >= 0
            ? _target.position
            : transform.position);
    }
}