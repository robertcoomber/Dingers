﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAttach : MonoBehaviour {

    private FixedJoint Joint;
    public Rigidbody Bat;

    private void Awake()
    {
        Joint = GetComponent<FixedJoint>();
        Joint.connectedBody = Bat;
        Joint.enablePreprocessing = false;
    }
}
