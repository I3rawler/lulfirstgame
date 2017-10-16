using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class BulletShooter : MonoBehaviour {


		public float speed;
		public float tilt;
		public Boundary boundary;

		public GameObject shot;
		public Transform shotSpawn;
		public float fireRate;

		private float nextFire;
		private Rigidbody2D rb2d;

	void Start () 
		{
		rb2d = GetComponent<Rigidbody2D> ();	
		}
		
	void Update ()
		{
			if (Input.GetButton("Fire1") && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
			}
		}

		void FixedUpdate ()
		{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
			Rigidbody2D.velocity = movement * speed;

			Rigidbody2D.position = new Vector2 (
					Mathf.Clamp (Rigidbody2D.position.x, boundary.xMin, boundary.xMax), 
					0.0f, 
					Mathf.Clamp (Rigidbody2D.position.y, boundary.yMin, boundary.yMax));

			Rigidbody2D.rotation = Quaternion.Euler (0.0f, Rigidbody2D.velocity.x);
		}
	}*/