﻿using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Emilian Skoczylas
public class FindPlayer : MonoBehaviour
{
    public GameObject tPlayer;
    public Transform tFollowTarget;
    private CinemachineVirtualCamera vcam;


    private void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
    }
    private void Update()
    {
        if (tPlayer == null)
        {
            tPlayer = GameObject.FindWithTag("Player");
            if (tPlayer != null)
            {
                tFollowTarget = tPlayer.transform;
                vcam.Follow = tFollowTarget;
            }
        }
    }
}
