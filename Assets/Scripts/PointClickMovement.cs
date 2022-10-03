using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

public class PointClickMovement : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public Animator playerAnimator;
    public GameObject targetDestination;
    public float timeToMove;
    public float maxTime = 3;

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && (timeToMove <= maxTime))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if(Physics.Raycast(ray, out hitPoint))
            {
                
                targetDestination.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);
                Debug.Log(timeToMove);
               
            }
        }

        if (player.velocity != new Vector3(0, 0, 0))
        {
            timeToMove = timeToMove + Time.deltaTime;
            
        }

        if (timeToMove >= maxTime)
        {
            player.ResetPath();
        }

    }



}
