using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour {

	public float speed = 10;

	private Rigidbody2D rb2d;

	void Start () 
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		var mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation (transform.position - mousePosition, Vector3.forward);


		transform.rotation = rot;
		transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);

		float input = Input.GetAxis ("Vertical");
		rb2d.AddForce (gameObject.transform.up * speed * input);
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Enemy") 
		{
			Destroy (gameObject);
		}

	}
}

