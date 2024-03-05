using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAI : MonoBehaviour
{
    public NavMeshAgent Navigation;
    public GameObject Target;
    void Update()
    {
        //Navigation.destination = Target.transform.position;
    }
}
