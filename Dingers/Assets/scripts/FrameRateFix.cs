﻿using UnityEngine;

#if UNITY_EDITOR

using System.Collections;
using System.Collections.Generic;

public class FrameRateFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (UnityEditorInternal.ProfilerDriver.firstFrameIndex > 0)
        {
            UnityEditorInternal.ProfilerDriver.ClearAllFrames();
        }
    }
}

#endif
