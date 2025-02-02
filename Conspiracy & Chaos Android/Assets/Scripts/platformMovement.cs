﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{

    private Vector3 posA;

    private Vector3 posB;

    private Vector3 nexPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransfrom;

    [SerializeField]
    private Transform transformB;

    // Start is called before the first frame update
    void Start()
    {
        posA = childTransfrom.localPosition;
        posB = transformB.localPosition;
        nexPos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        childTransfrom.localPosition = Vector3.MoveTowards(childTransfrom.localPosition, nexPos, speed * Time.deltaTime);

        if (Vector3.Distance(childTransfrom.localPosition, nexPos) <= 0.1)
        {
            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        nexPos = nexPos != posA ? posA : posB;
    }
}
