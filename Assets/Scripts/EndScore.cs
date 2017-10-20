using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (GameObject.FindWithTag("Player") == null)
        {
            transform.position = new Vector3(1.5f, -2.3f, 0);
        }
    }
}
