﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RottateObj : MonoBehaviour {
    public int x;
    public int y;
    public int z;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.Rotate(new Vector3(x, y, z));
            
	}
}
