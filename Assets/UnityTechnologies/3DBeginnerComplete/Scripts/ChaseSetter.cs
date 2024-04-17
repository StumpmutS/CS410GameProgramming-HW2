using System.Collections.Generic;
using UnityEngine;

public class ChaseSetter : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private List<WaypointPatrol> patrols;

    public void AcivateChase()
    {
        foreach (var patrol in patrols)
        {
            patrol.enabled = false;
            if (!patrol.TryGetComponent<Chase>(out var chase)) chase = patrol.gameObject.AddComponent<Chase>();
            chase.Init(target);
        }
    }
}