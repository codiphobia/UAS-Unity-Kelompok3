﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformPositions : MonoBehaviour
{
    [SerializeField]
    Transform transTarget;
   

    // Update is called once per frame
    void Update()
    {
         transform.position = transTarget.position;
    }
}
