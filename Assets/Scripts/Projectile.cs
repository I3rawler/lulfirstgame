using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public GameObject projectilePrefab;
	private List<GameObject> Projectiles = new List<GameObject> ();

	private float projectileVelocity;

	//private Rigidbody2D rb2d;
	public float speed;

	// Use this for initialization
	void Start () 
	{
		projectileVelocity = 10;
		// b2d = GetComponent<Rigidbody2D> ();
		// rb2d.AddForce(transform.forward * speed);
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetButtonDown ("Fire1")) 
		{

			Vector3 worldMousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Vector2 direction = (Vector2)((worldMousePos - transform.position));
			direction.Normalize ();

			GameObject bullet = (GameObject)Instantiate(projectilePrefab, transform.position + (Vector3)(direction * 0.5f), Quaternion.identity);
			// GameObject bullet = (GameObject)Instantiate(projectilePrefab, transform.position, Quaternion.identity);
			Projectiles.Add (bullet);
			bullet.GetComponent<Rigidbody2D>().velocity = direction * projectileVelocity;
		}

		for(int i = 0; i < Projectiles.Count; i++)
		{
			GameObject goBullet = Projectiles[i];
			if (goBullet != null)
			{
				

				//goBullet.transform.Translate(new Vector2 (0,1) * Time.deltaTime * projectileVelocity);

				Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint (goBullet.transform.position);
				if (bulletScreenPos.y >= Screen.height || bulletScreenPos.y <= 0) 
				{
					DestroyObject (goBullet);
					Projectiles.Remove (goBullet);
				}

				if (bulletScreenPos.x >= Screen.width || bulletScreenPos.x <= 0) 
				{
					DestroyObject (goBullet);
					Projectiles.Remove (goBullet);
				}
			}
		}
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "Enemy") 
		{
			Destroy (gameObject);
		}
	}


}
