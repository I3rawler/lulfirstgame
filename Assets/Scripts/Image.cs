﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Image : MonoBehaviour {

	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("Player") == null)
        {
            gameObject.transform.position = Vector3.zero;
        }
    }
}