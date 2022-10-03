using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBridge : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject door2;

    [Header("Gate 1 positions")]
    [SerializeField] float doorXpos;
    [SerializeField] float doorYpos;
    [SerializeField] float doorZpos;
    [Header("Gate 2 positions")]
    [SerializeField] float door2Xpos;
    [SerializeField] float door2Ypos;
    [SerializeField] float door2Zpos;

    private void OnTriggerEnter(Collider other)
    {
        door.transform.position = new Vector3(doorXpos, doorYpos, doorZpos);
        door2.transform.position = new Vector3(door2Xpos, door2Ypos, door2Zpos);
    }
}
