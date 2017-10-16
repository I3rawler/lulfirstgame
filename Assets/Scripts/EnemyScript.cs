using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	public float speed;
	public Transform player;
	private Rigidbody2D rb2d;

	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	void FixedUpdate () 
	{
		float z = Mathf.Atan2 ((player.transform.position.y - transform.position.y), 
			          (player.transform.position.x - transform.position.x)) *
		          Mathf.Rad2Deg - 90;

		transform.eulerAngles = new Vector3 (0, 0, z);

		rb2d.AddForce (gameObject.transform.up * speed);
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Bullet") 
		{
			Destroy (gameObject);
		}
	}
}
