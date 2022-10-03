using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Script : MonoBehaviour
{
    [Header("Gates")]
    [SerializeField] GameObject gateA;
    [SerializeField] GameObject gateB;
    [SerializeField] GameObject gateC;
    [SerializeField] GameObject gateD;
    [SerializeField] GameObject gateE;

    [Header("Gate A Open")]
    [SerializeField] float gateAXpos;
    [SerializeField] float gateAYpos;
    [SerializeField] float gateAZpos;
    [Header("Gate B Open")]
    [SerializeField] float gateBXpos;
    [SerializeField] float gateBYpos;
    [SerializeField] float gateBZpos;
    [Header("Gate C Open")]
    [SerializeField] float gateCXpos;
    [SerializeField] float gateCYpos;
    [SerializeField] float gateCZpos;
    [Header("Gate D Open")]
    [SerializeField] float gateDXpos;
    [SerializeField] float gateDYpos;
    [SerializeField] float gateDZpos;
    [Header("Gate E Open")]
    [SerializeField] float gateEXpos;
    [SerializeField] float gateEYpos;
    [SerializeField] float gateEZpos;

    private void OnTriggerEnter(Collider other)
    {
        //Gate A
        gateA.transform.position = new Vector3(gateAXpos, gateAYpos, gateAZpos);
        // GateB
        gateB.transform.position = new Vector3(gateBXpos, gateBYpos, gateBZpos);
        //Gate C
        gateC.transform.position = new Vector3(gateCXpos, gateCYpos, gateCZpos);
        //Gate D
        gateD.transform.position = new Vector3(gateDXpos, gateDYpos, gateDZpos);
        //Gate E
        gateE.transform.position = new Vector3(gateEXpos, gateEYpos, gateEZpos);

    }





}
