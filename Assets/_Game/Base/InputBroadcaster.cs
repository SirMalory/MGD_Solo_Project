using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class InputBroadcaster : MonoBehaviour
{
    //private GameController _controller;
    [SerializeField] private NavMeshAgent _navMeshAgent;

    public NavMeshAgent NavMeshAgent => _navMeshAgent;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    _navMeshAgent.destination = hit.point;
                }
            }
        }
    }

}
